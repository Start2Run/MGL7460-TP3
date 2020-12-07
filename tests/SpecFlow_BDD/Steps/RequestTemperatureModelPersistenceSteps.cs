using System;
using System.Threading.Tasks;
using AutoFixture;
using AutoFixture.AutoMoq;
using Business.Managers;
using Common;
using Common.Enums;
using Common.Models;
using Common.Models.RestApi;
using Communication.Contracts;
using Microsoft.Reactive.Testing;
using Moq;
using Persistence.Contracts;
using Persistence.Models;
using TechTalk.SpecFlow;

namespace SpecFlow_BDD.Steps
{
    [Binding]
    public class RequestTemperatureModelPersistenceSteps
    {
        private readonly IConfigurationModel _configuration;
        private readonly IRequestManager _requestManager;
        private readonly MenuManager _menuManager;
        private readonly IDbManager _dbManager;
        private readonly TestScheduler _testScheduler;

        public RequestTemperatureModelPersistenceSteps(ScenarioContext scenarioContext)
        {
            var mFixture = new Fixture()
                .Customize(new AutoMoqCustomization());
            _configuration = mFixture.Create<IConfigurationModel>();
            _testScheduler = new TestScheduler();
            var schedulerManager = new SchedulerManager(_configuration, _testScheduler);
            _requestManager = mFixture.Create<IRequestManager>();
            _dbManager = mFixture.Create<IDbManager>();
            var consoleWrapper = mFixture.Create<Business.Contracts.IConsoleWrapper>();
            _menuManager = new MenuManager(_requestManager, schedulerManager, _dbManager, _configuration, consoleWrapper);

            Mock.Get(_configuration).SetupGet(config => config.PullIntervalInSeconds).Returns(30);
        }

        [Given(@"a valid endpoint address and database name are configured in the application configuration file")]
        public void GivenAValidEndpointAddressAndDatabaseNameAreConfiguredInTheApplicationConfigurationFile()
        {
            Mock.Get(_configuration).SetupGet(config => config.ApiAddress).Returns(Globals.ApiAddress);
            Mock.Get(_configuration).SetupGet(config => config.DatabaseName).Returns(Globals.DatabaseName);
        }

        [When(@"the request is sent with success to the endpoint address")]
        public void WhenTheRequestIsSentWithSuccessToTheEndpointAddress()
        {
            Mock.Get(_requestManager).Setup(rm => rm.GetRequestAsync()).Returns(async () => await Task.FromResult(new RestApiModel { IsSuccessful = true }));
            _menuManager.SelectOption(MenuOption.GetTemperatureFromRestApi);
            _testScheduler.AdvanceBy(TimeSpan.FromSeconds(31).Ticks);
        }

        [When(@"the request fails to be sent the endpoint address")]
        public void WhenTheRequestFailsToBeSentTheEndpointAddress()
        {
            Mock.Get(_requestManager).Setup(rm => rm.GetRequestAsync()).Returns(async () => await Task.FromResult(new RestApiModel { IsSuccessful = false }));
        }

        [Then(@"a temperature data model should be persisted into the DB")]
        public void ThenATemperatureDataModelShouldBePersistedIntoTheDb()
        {
            Mock.Get(_dbManager).Verify(x => x.Insert(It.IsAny<DbModel>()), Times.AtLeastOnce);
        }

        [Then(@"nothing should be persisted into the DB")]
        public void ThenNothingShouldBePersistedIntoTheDb()
        {
            Mock.Get(_dbManager).Verify(x => x.Insert(It.IsAny<DbModel>()), Times.Never);
        }
    }
}
