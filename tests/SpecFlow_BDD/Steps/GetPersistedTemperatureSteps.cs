using System;
using TechTalk.SpecFlow;

namespace SpecFlow_BDD.Steps
{
    [Binding]
    public class GetPersistedTemperatureSteps
    {
        private readonly ScenarioContext _scenarioContext;

        public GetPersistedTemperatureSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"a database name is configured in the application configuration file")]
        public void GivenADatabaseNameIsConfiguredInTheApplicationConfigurationFile()
        {
            _scenarioContext.Pending();
        }
        
        [When(@"a query is created to recuperate all the persisted temperature data")]
        public void WhenAQueryIsCreatedToRecuperateAllThePersistedTemperatureData()
        {
            _scenarioContext.Pending();
        }
        
        [Then(@"all the existing peristed temperature data should be retourned")]
        public void ThenAllTheExistingPeristedTemperatureDataShouldBeRetourned()
        {
            _scenarioContext.Pending();
        }
    }
}
