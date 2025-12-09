using Microsoft.Data.SqlClient;

namespace CarDealership.Data.Repositories;

public abstract class BaseAdoNetRepository : IDisposable
{
    protected readonly SqlConnection Connection;
    
    protected BaseAdoNetRepository(string connectionString)
    {
        Connection = new SqlConnection(connectionString);
        Connection.Open();
    }

    public void Dispose()
    {
        Connection.Close();
    }
}