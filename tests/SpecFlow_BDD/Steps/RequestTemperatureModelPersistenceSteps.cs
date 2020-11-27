using TechTalk.SpecFlow;

namespace SpecFlow_BDD.Steps
{
    [Binding]
    public class RequestTemperatureModelPersistenceSteps
    {
        private readonly ScenarioContext _scenarioContext;

        public RequestTemperatureModelPersistenceSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"a valid endpoint address and database name are configured in the application configuration file")]
        public void GivenAValidEndpointAddressAndDatabaseNameAreConfiguredInTheApplicationConfigurationFile()
        {
            _scenarioContext.Pending();
        }
        
        [When(@"the request is sent with success to the endpoint address")]
        public void WhenTheRequestIsSentWithSuccessToTheEndpointAddress()
        {
            _scenarioContext.Pending();
        }
        
        [When(@"the request fails to be sent the endpoint address")]
        public void WhenTheRequestFailsToBeSentTheEndpointAddress()
        {
            _scenarioContext.Pending();
        }
        
        [Then(@"a temperature data model should be pesisted into the DB")]
        public void ThenATemperatureDataModelShouldBePesistedIntoTheDB()
        {
            _scenarioContext.Pending();
        }
        
        [Then(@"nothing should be pesisted into the DB")]
        public void ThenNothingShouldBePesistedIntoTheDB()
        {
            _scenarioContext.Pending();
        }
    }
}
