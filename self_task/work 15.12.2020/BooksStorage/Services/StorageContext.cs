namespace BooksStorage.Services
{
    public class StorageContext
    {
        public UsersProvider UsersProvider { get; set; }

        public BooksProvider BooksProvider { get; set; }

        public StorageContext()
        {
            UsersProvider = new UsersProvider();
            BooksProvider = new BooksProvider();
        }
    }
}
