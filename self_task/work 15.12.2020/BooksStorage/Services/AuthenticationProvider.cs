using System.Data.SqlClient;

namespace BooksStorage.Services
{
    public class AuthenticationProvider
    {
        public SqlConnection Connection { get; private set; }

        public AuthenticationProvider()
        {
            Connection = CreateConnection();
        }

        private SqlConnection CreateConnection() 
        {
            var builder = new SqlConnectionStringBuilder 
            {
                DataSource = @"USERPC\PERSON",
                InitialCatalog = "BooksStorage",
                IntegratedSecurity = true
            };

            return new SqlConnection(builder.ToString());
        }
    }
}