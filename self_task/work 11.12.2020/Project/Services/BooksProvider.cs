using Project.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Project.Services
{
    public class BooksProvider
    {
        private SqlConnection _connection { get; set; }

        public BooksProvider(SqlConnection connection)
        {
            _connection = connection;
        }

        public List<Book> GetAll()
        {
            try
            {
                _connection.Open();

                List<Book> books = new List<Book>();

                SqlCommand command = new SqlCommand(
                    @"SELECT 
                        [Books].[Id], 
                        [Books].[Title], 
                        [Books].[CountOfPages], 
                        [Books].[AuthorId],
                        [Authors].[Name],
                        [Authors].[Surname]
                    FROM [Books] LEFT JOIN [Authors]
                    ON [Authors].[Id] = [Books].[AuthorId]
                    WHERE [Books].[IsDeleted] = 'False'",
                    _connection
                );

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Book book = new Book
                        {
                            Id = reader.GetInt32(0),
                            Title = reader.GetString(1),
                            CountOfPages = reader.GetInt32(2),
                            AuthorId = reader.GetInt32(3),
                            Author = new Author 
                            {
                                Id = reader.GetInt32(3),
                                Name = reader.GetString(4),
                                Surname = reader.GetString(5)
                            }
                        };

                        books.Add(book);
                    }
                }

                return books;
            }
            finally
            {
                _connection.Close();
            }
        }

        public bool Add(Book book)
        {
            try
            {
                _connection.Open();

                SqlCommand command = new SqlCommand(
                    @"INSERT [Books] 
                        ([Title], [CountOfPages], [AuthorId])
                    VALUES 
                        (@Title, @CountOfPages, @AuthorId)",
                    _connection
                );

                command.Parameters.AddWithValue("@Title", book.Title);
                command.Parameters.AddWithValue("@CountOfPages", book.CountOfPages);
                command.Parameters.AddWithValue("@AuthorId", book.AuthorId);

                return command.ExecuteNonQuery() > 0;
            }
            finally
            {
                _connection.Close();
            }
        }

        public bool Update(int id, Book book)
        {
            try
            {
                _connection.Open();

                SqlCommand command = new SqlCommand(
                    @"UPDATE [Books]
                    SET
                        [Title] = @Title, 
                        [CountOfPages] = @CountOfPages,
                        [AuthorId] = @AuthorId
                    WHERE
                        [Id] = @Id
                    AND 
                        [IsDeleted] = 'False'",
                    _connection
                );

                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Title", book.Title);
                command.Parameters.AddWithValue("@CountOfPages", book.CountOfPages);
                command.Parameters.AddWithValue("@AuthorId", book.AuthorId);

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
                    @"UPDATE [Books]
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