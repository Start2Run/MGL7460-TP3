using Persistence.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Persistence.Contracts
{
    public interface IDbManager
    {
        Task Insert(DbModel model);
        Task<IEnumerable<DbModel>> GetAllData();
        Task ClearAsync();
    }
}
