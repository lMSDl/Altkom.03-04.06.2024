using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    internal class Rectangle : Shape2D
    {
        public Rectangle(float width, float height ) : base("prostokąt", width, height)
        {
        }

        public override float CalculateArea()
        {
            return Width * Height;
        }
    }
}
