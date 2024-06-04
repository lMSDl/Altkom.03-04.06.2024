using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    //: - dziedziczenie
    internal abstract class Shape1D : Shape
    {
        //base - odwołanie się do konstruktora z klasy bazowej
        protected Shape1D(string name, float width) : base(name)
        {
            Width = width;
        }

        public float Width { get; private set; }  
        
        //virtual - pozwala zmienić implementację metody w klasach pochodnych (override)
        public virtual void Sth()
        {
            Console.WriteLine(Name);
        }
    }
}
