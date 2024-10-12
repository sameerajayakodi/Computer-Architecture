using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDesignPattern
{
    public class UserView
    {
        public void DisplayUserDetails(string userName, int userAge)
        {
            Console.WriteLine("User Details:");
            Console.WriteLine($"Name: {userName}");
            Console.WriteLine($"Age: {userAge}");
        }

        public string GetUserInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
    }
}
