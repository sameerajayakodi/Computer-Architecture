using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class LibraryManager
    {
        private static LibraryManager instance = null;
        private static readonly object _lock = new object();


        private List<string> books = new List<string>();
        private List<string> users = new List<string>();


        private LibraryManager() { }


        public static LibraryManager GetInstance()
        {
            lock (_lock)
            {
                if (instance == null)
                {
                    instance = new LibraryManager();
                }
            }
            return instance;
        }


        public void AddBook(string bookName)
        {
            books.Add(bookName);
            Console.WriteLine("Book " +bookName+" added to the library.");
        }


        public void AddUser(string userName)
        {
            users.Add(userName);
            Console.WriteLine("User "+userName+" added to the library system.");
        }
    }
}
