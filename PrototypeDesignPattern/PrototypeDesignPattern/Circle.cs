using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern
{
    public class Circle: ShapePrototype
    {
        private string color;
        public Circle(string color)
        {
            this.color = color;
        }

        public ShapePrototype Clone()
        {
            return new Circle(this.color);
        }

        public void Drow()
        {
            Console.WriteLine("Drowing "+color+" Color Circle." );
        }
    }
}
