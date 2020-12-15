using BooksStorage.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BooksStorage.Services
{
    public class BooksProvider
    {
        public AuthenticationProvider Authentication { get; private set; }

        private SqlConnection connection { get; set; }

        public BooksProvider()
        {
            Authentication = new AuthenticationProvider();
            connection = Authentication.Connection;
        }

        public List<Book> GetAll() 
        {
            try
            {
                connection.Open();

                List<Book> books = new List<Book>();

                SqlCommand command = new SqlCommand(
                    @"SELECT * FROM [Books]
                    WHERE [IsDeleted] = 'False'", 
                    connection
                );

                using (var reader = command.ExecuteReader()) 
                {
                    while (reader.Read())
                    {
                        Book book = new Book 
                        {
                            Id = reader.GetInt32(0),
                            Title = reader.GetString(1),
                            CountOfPages = reader.GetInt32(2),
                            Author = reader.GetString(3)
                        };

                        books.Add(book);
                    }
                }

                return books;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool Add(Book book) 
        {
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand(
                    @"INSERT [Books]
                        ([Title],
                        [CountOfPages],
                        [Author])
                    VALUES
                        (@Title,
                        @CountOfPages,
                        @Author)",
                    connection
                );

                command.Parameters.AddWithValue("@Title", book.Title);
                command.Parameters.AddWithValue("@CountOfPages", book.CountOfPages);
                command.Parameters.AddWithValue("@Author", book.Author);

                return command.ExecuteNonQuery() > 0;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool Update(int id, Book book)
        {
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand(
                    @"UPDATE [Books]
                    SET
                        [Title] = @Title,
                        [CountOfPages] = @CountOfPages,
                        [Author] = @Author
                    WHERE
                        [Id] = @Id
                    AND
                        [IsDeleted] = 'False'",
                    connection
                );

                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Title", book.Title);
                command.Parameters.AddWithValue("@CountOfPages", book.CountOfPages);
                command.Parameters.AddWithValue("@Author", book.Author);

                return command.ExecuteNonQuery() > 0;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool Delete(int id)
        {
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand(
                    @"UPDATE [Books]
                    SET
                        [IsDeleted] = 'True'
                    WHERE
                        [Id] = @Id",
                    connection
                );

                command.Parameters.AddWithValue("@Id", id);

                return command.ExecuteNonQuery() > 0;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}