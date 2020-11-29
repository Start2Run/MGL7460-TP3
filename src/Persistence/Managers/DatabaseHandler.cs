using Persistence.Contracts;
using Persistence.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Common.Models;

namespace Persistence.Managers
{
    public class DatabaseHandler : IDatabaseHandler
    {
        private readonly IDatabaseConnectionFactory _connectionFactory;
        private readonly IConfigurationModel _configuration;

        public DatabaseHandler(IDatabaseConnectionFactory connectionFactory, IConfigurationModel configuration)
        {
            _configuration = configuration;
            _connectionFactory = connectionFactory;
        }


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
