using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class Circle:Shape
    {
        public void Drow()
        {
            Console.WriteLine("I am Creating Circle...");
        }
    }
}
