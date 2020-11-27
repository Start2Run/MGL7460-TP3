using Persistence.Contracts;
using System.Data;

namespace Persistence.Managers
{
    public class DatabaseConnectionFactory : IDatabaseConnectionFactory
    {
        public IDbConnection GetConnection()
        {
            throw new System.NotImplementedException();
        }
    }
}
