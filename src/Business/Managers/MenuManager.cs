using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Contracts;
using Common;
using Common.Enums;
using Common.Models;
using Common.Models.RestApi;
using Communication.Contracts;
using Newtonsoft.Json;
using Persistence.Contracts;
using Persistence.Models;

namespace Business.Managers
{
    public class MenuManager : IMenuManager
    {
        private readonly IRequestManager _requestManager;
        private readonly ISchedulerManager _schedulerManager;
        private readonly IDbManager _dbManager;
        private readonly IConfigurationModel _configuration;
        private readonly IConsoleWrapper _consoleWrapper;

        public MenuManager(IRequestManager requestManager, ISchedulerManager schedulerManager, IDbManager dbManager, IConfigurationModel configuration, IConsoleWrapper consoleWrapper)
        {
            _requestManager = requestManager;
            _schedulerManager = schedulerManager;
            _dbManager = dbManager;
            _configuration = configuration;
            _consoleWrapper = consoleWrapper;
        }

        public void Dispose()
        {
            _schedulerManager?.Dispose();
        }

        public bool SelectOption(MenuOption menuOption)
        {
            switch (menuOption)
            {
                case MenuOption.GetTemperatureFromRestApi:
                    GetTemperatureFromRestApi();
                    return true;
                case MenuOption.GetTemperatureFromDb:
                    GetTemperatureFromDb().GetAwaiter();
                    return true;
                case MenuOption.ClearDb:
                    ClearDb().GetAwaiter();
                    return true;
                default:
                    return false;
            }
        }

        private async Task GetTemperatureFromDb()
        {
            _schedulerManager.Dispose();
            var entries = await _dbManager.GetAllData();
            foreach (var item in entries)
            {
                _consoleWrapper.Write(JsonConvert.SerializeObject(item, Formatting.Indented));
            }
            _consoleWrapper.Write("Press any key to continue...");
            _consoleWrapper.ReadKey();
        }

        private void GetTemperatureFromRestApi()
        {
            _consoleWrapper.Write($"Wait {_configuration.PullIntervalInSeconds} seconds to receive the data!!!");
            _schedulerManager.Start(DoWorkAsync);
            _consoleWrapper.Write("Press any key to continue...");
            _consoleWrapper.ReadKey();
            _schedulerManager.Dispose();
        }

        private async Task DoWorkAsync()
        {
            var model = await _requestManager.GetRequestAsync();

            if (!model.IsSuccessful)
            {
                _consoleWrapper.Write("Invalid request received");
                return;
            }

            var dbModels = GetDbModelFromRequest(model.WeatherModel);

            try
            {
                foreach (var dbModel in dbModels)
                {
                    await _dbManager.Insert(dbModel);
                    _consoleWrapper.Write(JsonConvert.SerializeObject(dbModel, Formatting.Indented));
                }
            }
            catch (Exception e)
            {
                _consoleWrapper.Write(e.StackTrace);
            }
        }

        private static IEnumerable<DbModel> GetDbModelFromRequest(Root root)
        {
            return root == null ? new List<DbModel>() : root.data.Select(data => new DbModel() { Latitude = data.lat, Longitude = data.lon, Temperature = data.temp, DateTime = DateTime.Now.ToLongTimeString() });
        }

        private async Task ClearDb()
        {
            await _dbManager.Clear();
            _consoleWrapper.Write($"Database table {Globals.TableName} has been cleared. Press any key to continue...");
            _consoleWrapper.ReadKey();
        }
    }
}
