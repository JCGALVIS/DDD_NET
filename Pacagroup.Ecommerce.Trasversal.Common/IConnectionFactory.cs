using System.Data;

namespace Pacagroup.Ecommerce.Trasversal.Common
{
    public interface IConnectionFactory
    {
        IDbConnection GetConnection {  get; }
    }
}
