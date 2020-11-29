using Persistence.Contracts;
using Persistence.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Persistence.Managers
{
    public class DatabaseManager : IDbManager
    {
        private readonly IDatabaseHandler _handler;
        public DatabaseManager(IDatabaseHandler handler)
        {
            _handler = handler;
        }

        public Task Clear()
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<DbModel>> GetAllData()
        {
            throw new System.NotImplementedException();
        }

        public Task Insert(DbModel model)
        {
            throw new System.NotImplementedException();
        }
    }
}
