using System.Data.SqlClient;

namespace Project.Services
{
    public class StorageContext
    {
        public AuthorsProvider authorsProvider { get; }

        public BooksProvider booksProvider { get; }

        public StorageContext()
        {
            authorsProvider = new AuthorsProvider(CreateConnection());
            booksProvider = new BooksProvider(CreateConnection());
        }

        private SqlConnection CreateConnection() 
        {
            var builder = new SqlConnectionStringBuilder()
            {
                DataSource = @"USERPC\PERSON",
                InitialCatalog = "BooksStorage",
                IntegratedSecurity = true
            };

            return new SqlConnection(builder.ToString());
        }
    }
}
