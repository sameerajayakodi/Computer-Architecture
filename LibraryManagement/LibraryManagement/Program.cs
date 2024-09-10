using LibraryManagement;

class Program
{
    static void Main(string[] args)
    {
        
        LibraryManager library = LibraryManager.GetInstance();

        
        library.AddBook("Madolduwa");
        library.AddBook("Maths");

        
        library.AddUser("Sameera");
        library.AddUser("Jayakodi");
    }
}
