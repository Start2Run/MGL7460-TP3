using System.Data;

namespace Persistence.Contracts
{
    interface IDatabaseConnectionFactory
    {
        IDbConnection GetConnection();
    }
}
