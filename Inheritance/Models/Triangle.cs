using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    internal class Triangle : Shape2D
    {
        public Triangle(float width, float height, float angle) : base("trójkąt", width, height)
        {
            Angle = angle;
        }

        public float Angle { get; private set; }

        //override - implementujemy metodę abstrakcyjną
        public override float CalculateArea()
        {
            return Height * Width * (float)Math.Cos(Angle);
        }

        //override - nadpisujemy metodę z klasy bazowej (czyli tej po której dziedziczymy)
        public override void Sth()
        {
            Console.WriteLine("Ala ma kota");
        }
    }
}
