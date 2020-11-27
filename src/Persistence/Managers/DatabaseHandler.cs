using Persistence.Contracts;
using Persistence.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Persistence.Managers
{
    public class DatabaseHandler : IDatabaseHandler
    {
        public Task Clear()
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<DbModel>> GetAllData()
        {
            throw new System.NotImplementedException();
        }

        public bool Init()
        {
            throw new System.NotImplementedException();
        }

        public Task Insert(DbModel model)
        {
            throw new System.NotImplementedException();
        }
    }
}
