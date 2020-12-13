using Project.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Project.Services
{
    public class AuthorsProvider
    {
        private SqlConnection _connection { get; set; }

        public AuthorsProvider(SqlConnection connection)
        {
            _connection = connection;
        }

        public List<Author> GetAll() 
        {
            try
            {
                _connection.Open();

                List<Author> authors = new List<Author>();

                SqlCommand command = new SqlCommand(
                    @"SELECT * FROM [Authors]
                    WHERE [IsDeleted] = 'False'", 
                    _connection
                );

                using (SqlDataReader reader = command.ExecuteReader()) 
                {
                    while (reader.Read())
                    {
                        Author author = new Author
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Surname = reader.GetString(2)
                        };

                        authors.Add(author);
                    }
                }

                return authors;
            }
            finally
            {
                _connection.Close();
            }
        }

        public bool Add(Author author)
        {
            try
            {
                _connection.Open();

                SqlCommand command = new SqlCommand(
                    @"INSERT [Authors] 
                        ([Name], [Surname])
                    VALUES 
                        (@Name, @Surname)",
                    _connection
                );

                command.Parameters.AddWithValue("@Name", author.Name);
                command.Parameters.AddWithValue("@Surname", author.Surname);

                return command.ExecuteNonQuery() > 0;
            }
            finally
            {
                _connection.Close();
            }
        }

        public bool Update(int id, Author author)
        {
            try
            {
                _connection.Open();

                SqlCommand command = new SqlCommand(
                    @"UPDATE [Authors]
                    SET
                        [Name] = @Name, 
                        [Surname] = @Surname
                    WHERE
                        [Id] = @Id
                    AND 
                        [IsDeleted] = 'False'",
                    _connection
                );

                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Name", author.Name);
                command.Parameters.AddWithValue("@Surname", author.Surname);

                return command.ExecuteNonQuery() > 0;
            }
            finally
            {
                _connection.Close();
            }
        }

        public bool Delete(int id)
        {
            try
            {
                _connection.Open();

                SqlCommand command = new SqlCommand(
                    @"UPDATE [Authors]
                    SET
                        [IsDeleted] = 'True'
                    WHERE
                        [Id] = @Id",
                    _connection
                );

                command.Parameters.AddWithValue("@Id", id);

                return command.ExecuteNonQuery() > 0;
            }
            finally
            {
                _connection.Close();
            }
        }
    }
}
