using System;
using TechTalk.SpecFlow;

namespace SpecFlow_BDD.Steps
{
    [Binding]
    public class CleanPersistanceDataSteps
    {
        private readonly ScenarioContext _scenarioContext;

        public CleanPersistanceDataSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"a database name is configured in the application configuration file")]
        public void GivenADatabaseNameIsConfiguredInTheApplicationConfigurationFile()
        {
            _scenarioContext.Pending();
        }
        
        [When(@"a query is created to celan the DB")]
        public void WhenAQueryIsCreatedToCelanTheDB()
        {
            _scenarioContext.Pending();
        }
        
        [Then(@"all the existing peristed temperature data should be deleted from the DB")]
        public void ThenAllTheExistingPeristedTemperatureDataShouldBeDeletedFromTheDB()
        {
            _scenarioContext.Pending();
        }
    }
}
