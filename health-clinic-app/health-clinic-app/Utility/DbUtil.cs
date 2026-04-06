using Microsoft.Data.SqlClient;

public static class DbUtil
{
    // Local SQL Server 
    private static readonly string connectionString="Server=.\\SQLEXPRESS;Database=HealthClinicDB;Trusted_Connection=true;TrustServerCertificate=true;";

    public static SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }
}
