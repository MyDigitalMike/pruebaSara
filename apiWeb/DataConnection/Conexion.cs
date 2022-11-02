using Microsoft.Data.SqlClient;
namespace apiWeb.DataConnection
{
    public class Conexion
    {
        SqlConnection Connection = new SqlConnection(@"server=localhost; database=pruebaSara;Trusted_Connection= True;" +
            "MultipleActiveResultSets= True;TrustServerCertificate= False;Encrypt= False");
        public SqlConnection getcn
        {
            get { return Connection; }
        }
    }
}
