using AutoFixture;
using AutoFixture.AutoMoq;
using Business.Contracts;
using Business.Managers;
using Common.Models;
using Communication.Contracts;
using Moq;
using Persistence.Contracts;
using System;
using System.Threading.Tasks;
using Xunit;

namespace BusinessTests
{
    public class MenuManagerTests
    {
        [Fact]
        public void ShouldCallSchedulerManagerWhenTheUserSelectsToGetTemperatureFromRestApi()
        {
            var fixture = new Fixture()
               .Customize(new AutoMoqCustomization());
            var requestManager = fixture.Create<IRequestManager>();
            var schedulerManager = fixture.Create<ISchedulerManager>();
            var dbManager = fixture.Create<IDbManager>();
            var configuration = fixture.Create<IConfigurationModel>();
            var consoleWrapper = fixture.Create<IConsoleWrapper>();

            var menuManager = new MenuManager(requestManager, schedulerManager, dbManager, configuration, consoleWrapper);
            menuManager.SelectOption(Common.Enums.MenuOption.GetTemperatureFromRestApi);

            Mock.Get(schedulerManager).Verify(x => x.Start(It.IsAny<Func<Task>>()),Times.Once);
        }

        [Fact]
        public void ShouldCallDbGetAllDataWhenTheUserSelectsToGetTemperatureFromDb()
        {
            var fixture = new Fixture()
               .Customize(new AutoMoqCustomization());
            var requestManager = fixture.Create<IRequestManager>();
            var schedulerManager = fixture.Create<ISchedulerManager>();
            var dbManager = fixture.Create<IDbManager>();
            var configuration = fixture.Create<IConfigurationModel>();
            var consoleWrapper = fixture.Create<IConsoleWrapper>();

            var menuManager = new MenuManager(requestManager, schedulerManager, dbManager, configuration, consoleWrapper);
            menuManager.SelectOption(Common.Enums.MenuOption.GetTemperatureFromDb);

            Mock.Get(dbManager).Verify(x => x.GetAllData(), Times.Once);
        }

        [Fact]
        public void ShouldCallDbClearWhenTheUserSelectsToClearDb()
        {
            var fixture = new Fixture()
               .Customize(new AutoMoqCustomization());
            var requestManager = fixture.Create<IRequestManager>();
            var schedulerManager = fixture.Create<ISchedulerManager>();
            var dbManager = fixture.Create<IDbManager>();
            var configuration = fixture.Create<IConfigurationModel>();
            var consoleWrapper = fixture.Create<IConsoleWrapper>();

            var menuManager = new MenuManager(requestManager, schedulerManager, dbManager, configuration, consoleWrapper);
            menuManager.SelectOption(Common.Enums.MenuOption.ClearDb);

            Mock.Get(dbManager).Verify(x => x.Clear(), Times.Once);
        }

        [Fact]
        public void ShouldRetunFalseWhenTheUserSelectToExit()
        {
            var fixture = new Fixture()
               .Customize(new AutoMoqCustomization());
            var requestManager = fixture.Create<IRequestManager>();
            var schedulerManager = fixture.Create<ISchedulerManager>();
            var dbManager = fixture.Create<IDbManager>();
            var configuration = fixture.Create<IConfigurationModel>();
            var consoleWrapper = fixture.Create<IConsoleWrapper>();

            var menuManager = new MenuManager(requestManager, schedulerManager, dbManager, configuration, consoleWrapper);
            menuManager.SelectOption(Common.Enums.MenuOption.Exit);

            Mock.Get(schedulerManager).Verify(x => x.Start(It.IsAny<Func<Task>>()), Times.Never);
            Mock.Get(dbManager).Verify(x => x.GetAllData(), Times.Never);
            Mock.Get(dbManager).Verify(x => x.Clear(), Times.Never);
            Mock.Get(dbManager).Verify(x => x.Clear(), Times.Never);
        }
    }
}
