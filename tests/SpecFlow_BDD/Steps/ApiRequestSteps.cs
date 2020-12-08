using System.Threading.Tasks;
using AutoFixture;
using AutoFixture.AutoMoq;
using Common.Models;
using Common.Models.RestApi;
using Communication.Managers;
using Flurl.Http.Testing;
using Moq;
using Newtonsoft.Json;
using TechTalk.SpecFlow;
using Xunit;

namespace SpecFlow_BDD.Steps
{
    [Binding]
    public class ApiRequestSteps
    {
        private readonly IFixture _fixture;
        private readonly IConfigurationModel _configuration;
        private readonly RequestManager _requestManager;
        private RestApiModel _receivedBody;
        private HttpTest _httpTest;
        private string _expectedJson;

        private readonly string apiKey = "apiKey1";
        private readonly string apiHost = "apiHost1";
        private readonly string longitude = "10.0";
        private readonly string latitude = "15.2";

        public ApiRequestSteps(ScenarioContext scenarioContext)
        {
           _fixture = new Fixture().Customize(new AutoMoqCustomization());
           _configuration = _fixture.Create<IConfigurationModel>();
           _requestManager = new RequestManager(_configuration);
        }

        [Given(@"a valid endpoint address is configured in the application configuration file")]
        public void GivenAValidEndpointAddressIsConfiguredInTheApplicationConfigurationFile()
        {
            Mock.Get(_configuration).SetupGet(config => config.ApiAddress).Returns("https://localhost");
            Mock.Get(_configuration).SetupGet(config => config.ApiKey).Returns(apiKey);
            Mock.Get(_configuration).SetupGet(config => config.ApiHost).Returns(apiHost);
            Mock.Get(_configuration).SetupGet(config => config.Longitude).Returns(longitude);
            Mock.Get(_configuration).SetupGet(config => config.Latitude).Returns(latitude);
        }
        
        [When(@"the request is sent to a Rest Api endpoint")]
        public async Task WhenTheRequestIsSentToARestApiEndpoint()
        {
            _expectedJson = JsonConvert.SerializeObject(new Root());
            _httpTest = new HttpTest();
            using var httpTest = _httpTest;
            _httpTest.RespondWith(_expectedJson);
            _receivedBody = await _requestManager.GetRequestAsync();
        }
        
        [When(@"the endpoint address is not the same as the one from the configuration file")]
        public void WhenTheEndpointAddressIsNotTheSameAsTheOneFromTheConfigurationFile()
        {
            var _differentEndpointAddress = "https://localhost/otherEndpoint";
            Mock.Get(_configuration).SetupGet(config => config.ApiAddress).Returns(_differentEndpointAddress);
        }
        
        [When(@"the request timeout")]
        public async Task WhenTheRequestTimeout()
        {
            _httpTest = new HttpTest();
            using var httpTest = _httpTest;
            httpTest.SimulateTimeout();
            _receivedBody = await _requestManager.GetRequestAsync();
        }

        [Then(@"the returned body data should have the format JSON data model")]
        public void ThenTheReturnedBodyDataShouldHaveTheFormatJsonDataModel()
        {
            var receivedJson = JsonConvert.SerializeObject(_receivedBody.WeatherModel);
            Assert.Equal(_expectedJson, receivedJson);
        }
        
        [Then(@"the request should fail and return a null model")]
        public void ThenTheRequestShouldFailAndReturnANullModel()
        {
             var value = _requestManager.GetRequestAsync().GetAwaiter().GetResult();
            Assert.Null(value.WeatherModel);
            Assert.False(value.IsSuccessful);
        }
    }
}
