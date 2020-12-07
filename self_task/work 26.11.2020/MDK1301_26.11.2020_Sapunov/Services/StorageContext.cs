using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MDK1301_26._11._2020_Sapunov.Services
{
    class StorageContext
    {
        public SpecialtiesProvider Specialties { get; }
        public GroupsProvider Groups { get; private set; }
        public StudentsProvider Students { get; private set; }

        public StorageContext()
        {
            SqlConnection connection = CreateConnection();
            Specialties = new SpecialtiesProvider(connection);
            Groups = new GroupsProvider(connection);
            Students = new StudentsProvider(connection);
        }

        private SqlConnection CreateConnection()
        {
            var builder = new SqlConnectionStringBuilder
            {
                DataSource = @"USERPC\PERSON",
                InitialCatalog = "StudentsStorage",
                IntegratedSecurity = true
            };

            return new SqlConnection(builder.ToString());
        }
    }
}