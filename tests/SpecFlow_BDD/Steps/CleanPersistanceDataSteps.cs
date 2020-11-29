using AutoFixture;
using AutoFixture.AutoMoq;
using Common;
using Common.Models;
using Moq;
using Persistence.Contracts;
using Persistence.Managers;
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

        [Given(@"a database name is configured in the application configuration file")]
        public void GivenADatabaseNameIsConfiguredInTheApplicationConfigurationFile()
        {
            Mock.Get(_configuration).SetupGet(config => config.DatabaseName).Returns(Globals.DatabaseName);
        }

        [When(@"a query is created to clean the DB")]
        public void WhenAQueryIsCreatedToCleanTheDb()
        {
            _databaseManager.Clear();
        }

        [Then(@"all the existing persisted temperature data should be deleted from the DB")]
        public void ThenAllTheExistingPersistedTemperatureDataShouldBeDeletedFromTheDb()
        {
            Mock.Get(_databaseHandler).Verify(x => x.Clear(), Times.Once);
        }
    }
}
