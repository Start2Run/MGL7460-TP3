using Common.Models.RestApi;
using Communication.Contracts;
using System;
using System.Threading.Tasks;
using Common.Models;

namespace Communication.Managers
{
    public class RequestManager : IRequestManager
    {
        private readonly IConfigurationModel _configuration;
        public RequestManager(IConfigurationModel configuration)
        {
            _configuration = configuration;
        }
        public Task<RestApiModel> GetRequestAsync()
        {
            throw new NotImplementedException();
        }
    }
}
