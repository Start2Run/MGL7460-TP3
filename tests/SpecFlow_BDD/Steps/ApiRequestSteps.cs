﻿using TechTalk.SpecFlow;

namespace SpecFlow_BDD.Steps
{
    [Binding]
    public class ApiRequestSteps
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
        
        [When(@"the enpoint address is no the same as the one from the configuration file")]
        public void WhenTheEnpointAddressIsNoTheSameAsTheOneFromTheConfigurationFile()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the request timeout")]
        public void WhenTheRequestTimeout()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the returned body data should have the format JSON data model")]
        public void ThenTheReturnedBodyDataShouldHaveTheFormatJSONDataModel()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the request should faild and return a null model")]
        public void ThenTheRequestShouldFaildAndReturnANullModel()
        {
            ScenarioContext.Current.Pending();
        }
    }
}