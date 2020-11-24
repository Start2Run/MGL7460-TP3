using System;
using TechTalk.SpecFlow;

namespace SpecFlow_BDD.Steps
{
    [Binding]
    public class QueryRestApiEndpointSteps
    {
        [Given(@"a valid endpoint address is configured in the application configuration file")]
        public void GivenAValidEndpointAddressIsConfiguredInTheApplicationConfigurationFile()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the request is sent to a Rest Api endpoint")]
        public void WhenTheRequestIsSentToARestApiEndpoint()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the returned body data should have the format JSON data model")]
        public void ThenTheReturnedBodyDataShouldHaveTheFormatJSONDataModel()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
