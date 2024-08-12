using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class Rectangle:Shape
    {
        public void Drow()
        {
            Console.WriteLine("I am Creating Rectangle...");
        }
    }
}
