using System;
using TechTalk.SpecFlow;

namespace SpecFlow_BDD.Steps
{
    [Binding]
    public class GetPersistedTemperatureSteps
    {
        [Given(@"a database name is configured in the application configuration file")]
        public void GivenADatabaseNameIsConfiguredInTheApplicationConfigurationFile()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"a query is created to recuperate all the persisted temperature data")]
        public void WhenAQueryIsCreatedToRecuperateAllThePersistedTemperatureData()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"all the existing peristed temperature data should be retourned")]
        public void ThenAllTheExistingPeristedTemperatureDataShouldBeRetourned()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
