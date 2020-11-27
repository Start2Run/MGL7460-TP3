using System;
using TechTalk.SpecFlow;

namespace SpecFlow_BDD.Steps
{
    [Binding]
    public class RequestTemperatureModelPersistenceSteps
    {
        [Given(@"a valid endpoint address and database name are configured in the application configuration file")]
        public void GivenAValidEndpointAddressAndDatabaseNameAreConfiguredInTheApplicationConfigurationFile()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the request is sent with success to the endpoint address")]
        public void WhenTheRequestIsSentWithSuccessToTheEndpointAddress()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the request fails to be sent the endpoint address")]
        public void WhenTheRequestFailsToBeSentTheEndpointAddress()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"a temperature data model should be pesisted into the DB")]
        public void ThenATemperatureDataModelShouldBePesistedIntoTheDB()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"nothing should be pesisted into the DB")]
        public void ThenNothingShouldBePesistedIntoTheDB()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
