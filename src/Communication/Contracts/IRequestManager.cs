using Common.Models.RestApi;
using System.Threading.Tasks;

namespace Communication.Contracts
{
    public interface IRequestManager
    {
        Task<RestApiModel> GetRequestAsync();
    }
}
