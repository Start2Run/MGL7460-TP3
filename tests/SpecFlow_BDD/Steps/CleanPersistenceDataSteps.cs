﻿using AutoFixture;
using AutoFixture.AutoMoq;
using Common;
using Common.Models;
using Moq;
using Persistence.Contracts;
using Persistence.Managers;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlow_BDD.Steps
{
    [Binding]
    public class CleanPersistenceDataSteps
    {
        private readonly IConfigurationModel _configuration;
        private readonly DatabaseManager _databaseManager;
        private readonly IDatabaseHandler _databaseHandler;

        public CleanPersistenceDataSteps(ScenarioContext scenarioContext)
        {
            var mFixture = new Fixture()
                .Customize(new AutoMoqCustomization());
            _databaseHandler = mFixture.Create<IDatabaseHandler>();
            _configuration = mFixture.Create<IConfigurationModel>();
            _databaseManager = new DatabaseManager(_databaseHandler);
        }

        [Given(@"a database file name is configured in the application configuration file")]
        public void GivenADatabaseFileNameIsConfiguredInTheApplicationConfigurationFile()
        {
            Mock.Get(_configuration).SetupGet(config => config.DatabaseName).Returns(Globals.DatabaseName);
        }
        
        [When(@"a query is created to clean the DB")]
        public async Task WhenAQueryIsCreatedToCleanTheDB()
        {
            await _databaseManager.ClearAsync();
        }
        
        [Then(@"all the existing persisted temperature data should be deleted from the DB")]
        public void ThenAllTheExistingPersistedTemperatureDataShouldBeDeletedFromTheDB()
        {
            Mock.Get(_databaseHandler).Verify(x => x.Clear(), Times.Once);
        }
    }
}
