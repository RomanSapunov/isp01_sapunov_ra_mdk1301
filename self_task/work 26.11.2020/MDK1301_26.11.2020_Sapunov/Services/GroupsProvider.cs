using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MDK1301_26._11._2020_Sapunov.Models;

namespace MDK1301_26._11._2020_Sapunov.Services
{
    class GroupsProvider
    {
        private SqlConnection _connection;

        public GroupsProvider(SqlConnection connection)
        {
            _connection = connection;
        }

        public List<Group> GetAllWithSpecialty()
        {
            List<Group> result = new List<Group>();

            try
            {
                _connection.Open();

                var command = new SqlCommand(
                    @"SELECT [id], [name], [year], [specialty_id], [Specialties].[code], [Specialties].[name]
                    FROM [Groups]
                    LEFT JOIN [Specialties]
                    ON [Groups].[specialty_id] = [Specialties].[id]"
                    ,
                    _connection
                );

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var specialty = new Specialty
                        {
                            Id = reader.GetInt32(3),
                            Code = reader.GetString(4),
                            Name = reader.GetString(5)
                        };

                        var group = new Group
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Year = reader.GetInt32(2),
                            SpecialtyId = reader.GetInt32(3),
                            Specialty = specialty
                        };

                        result.Add(group);
                    }
                }

                return result;
            }
            finally
            {
                _connection.Close();
            }
        }

        public List<Group> GetAll()
        {
            List<Group> result = new List<Group>();

            try
            {
                _connection.Open();

                var command = new SqlCommand(
                    @"SELECT [id], [name], [year], [specialty_id]
                    FROM [Groups]"
                    ,
                    _connection
                );

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var group = new Group
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Year = reader.GetInt32(2),
                            SpecialtyId = reader.GetInt32(3)
                        };

                        result.Add(group);
                    }
                }

                return result;
            }
            finally
            {
                _connection.Close();
            }
        }

        public bool Add(Group group)
        {
            bool result = false;

            try
            {
                _connection.Open();

                var command = new SqlCommand(
                    cmdText: @"
                        INSERT INTO [Specialties]
                            ([name], [year], [specialty_id])
                        VALUES
                            (@Name, @Year, @SpecialtyId)
                    ",
                    _connection
                );

                command.Parameters.AddWithValue("@Name", group.Name);
                command.Parameters.AddWithValue("@Year", group.Year);
                command.Parameters.AddWithValue("@SpecialtyId", group.SpecialtyId);

                result = command.ExecuteNonQuery() > 0;
            }
            finally
            {
                _connection.Close();
            }

            return result;
        }

        public bool Update(int id, Group group)
        {
            bool result = false;

            try
            {
                _connection.Open();

                var command = new SqlCommand(
                    @"
                        UPDATE [Specialties]
                        SET
                            [name] = @Name, 
                            [year] = @Year,
                            [specialty_id] = @SpecialtyId
                        WHERE
                            [id] = @Id
                    "
                    ,
                    _connection
                );

                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Name", group.Name);
                command.Parameters.AddWithValue("@Year", group.Year);
                command.Parameters.AddWithValue("@SpecialtyId", group.SpecialtyId);

                result = command.ExecuteNonQuery() > 0;
            }
            finally
            {
                _connection.Close();
            }

            return result;
        }

        public bool Delete(int id)
        {
            bool result = false;

            try
            {
                _connection.Open();

                var command = new SqlCommand(
                    @"
                        DELETE FROM [Group]
                        WHERE [id] = @Id
                    "
                    ,
                    _connection
                );

                command.Parameters.AddWithValue("@Id", id);

                result = command.ExecuteNonQuery() > 0;
            }
            finally
            {
                _connection.Close();
            }

            return result;
        }
    }
}
