using BooksStorage.Models;
using System.Data.SqlClient;

namespace BooksStorage.Services
{
    public class UsersProvider
    {
        public AuthenticationProvider Authentication { get; private set; }

        private SqlConnection connection { get; set; }

        public UsersProvider()
        {
            Authentication = new AuthenticationProvider();
            connection = Authentication.Connection;
        }

        public User GetUserByLoginAndPassword(string login, string password) 
        {
            try
            {
                connection.Open();

                User user = null;

                SqlCommand command = new SqlCommand(
                    @"SELECT * FROM [Users]
                    WHERE 
                        [Login] = @Login
                    AND
                        [Password] = @Password", 
                    connection
                );

                command.Parameters.AddWithValue("@Login", login);
                command.Parameters.AddWithValue("@Password", password);

                using (var reader = command.ExecuteReader()) 
                {
                    while (reader.Read())
                    {
                        user = new User()
                        {
                            Id = reader.GetInt32(0),
                            Login = reader.GetString(1),
                            Password = reader.GetString(2),
                            Role = reader.GetString(3)
                        };
                    }
                }

                return user;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}