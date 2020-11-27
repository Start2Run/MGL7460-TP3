using Common.Models.RestApi;
using Communication.Contracts;
using System;
using System.Threading.Tasks;

namespace Communication.Managers
{
    public class RequestManager : IRequestManager
    {
        public Task<RestApiModel> GetRequestAsync()
        {
            throw new NotImplementedException();
        }
    }
}
