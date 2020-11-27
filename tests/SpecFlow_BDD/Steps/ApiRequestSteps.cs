using TechTalk.SpecFlow;

namespace SpecFlow_BDD.Steps
{
    [Binding]
    public class ApiRequestSteps
    {
        private readonly ScenarioContext _scenarioContext;

        public ApiRequestSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"a valid endpoint address is configured in the application configuration file")]
        public void GivenAValidEndpointAddressIsConfiguredInTheApplicationConfigurationFile()
        {
            _scenarioContext.Pending();
        }
        
        [When(@"the request is sent to a Rest Api endpoint")]
        public void WhenTheRequestIsSentToARestApiEndpoint()
        {
            _scenarioContext.Pending();
        }
        
        [When(@"the enpoint address is no the same as the one from the configuration file")]
        public void WhenTheEnpointAddressIsNoTheSameAsTheOneFromTheConfigurationFile()
        {
            _scenarioContext.Pending();
        }
        
        [When(@"the request timeout")]
        public void WhenTheRequestTimeout()
        {
            _scenarioContext.Pending();
        }
        
        [Then(@"the returned body data should have the format JSON data model")]
        public void ThenTheReturnedBodyDataShouldHaveTheFormatJSONDataModel()
        {
            _scenarioContext.Pending();
        }
        
        [Then(@"the request should faild and return a null model")]
        public void ThenTheRequestShouldFaildAndReturnANullModel()
        {
            _scenarioContext.Pending();
        }
    }
}
