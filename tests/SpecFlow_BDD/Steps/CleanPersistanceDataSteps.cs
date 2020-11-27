using System;
using TechTalk.SpecFlow;

namespace SpecFlow_BDD.Steps
{
    [Binding]
    public class CleanPersistanceDataSteps
    {
        [Given(@"a database name is configured in the application configuration file")]
        public void GivenADatabaseNameIsConfiguredInTheApplicationConfigurationFile()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"a query is created to celan the DB")]
        public void WhenAQueryIsCreatedToCelanTheDB()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"all the existing peristed temperature data should be deleted from the DB")]
        public void ThenAllTheExistingPeristedTemperatureDataShouldBeDeletedFromTheDB()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
