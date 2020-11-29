using Business.Contracts;
using Common.Enums;
using System;
using Common.Models;
using Communication.Contracts;
using Persistence.Contracts;

namespace Business.Managers
{
    public class MenuManager : IMenuManager
    {
        private readonly IRequestManager _requestManager;
        private readonly ISchedulerManager _schedulerManager;
        private readonly IDbManager _dbManager;
        private readonly IConfigurationModel _configuration;

        public MenuManager(IRequestManager requestManager, ISchedulerManager schedulerManager, IDbManager dbManager, IConfigurationModel configuration)
        {
            _requestManager = requestManager;
            _schedulerManager = schedulerManager;
            _dbManager = dbManager;
            _configuration = configuration;
        }

        public bool SelectOption(MenuOption menuOption)
        {
            throw new NotImplementedException();
        }
    }
}
