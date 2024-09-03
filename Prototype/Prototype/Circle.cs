using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Circle:ShapePrototype
    {
        private string Color;
        private int Size;


        public Circle(string color,int size)
        {
            this.Color = color;
            this.Size = size;
        }
        public ShapePrototype Clone()
        {
            return new Circle(this.Color,this.Size);
        }

        public void Draw()
        {
            Console.WriteLine("Drow a "+Color + "Color Circle of " + Size*2*7.22);
        }
    }
}
