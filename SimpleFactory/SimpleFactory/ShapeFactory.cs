using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class ShapeFactory
    {
        public Shape GetShape(string shapeType)
        {
            if (shapeType == null) {
                return null;
            }else if (shapeType == "circle")
            {
                return new Circle();
            }else if(shapeType == "rectangle")
            {
                return new Rectangle(); 
            }else if(shapeType == "squre")
            {
                return new Squre;
            }
        }
    }
}
