
using Inheritance.Models;

Shape1D shape1D = new Line(5);

Shape2D shape2D = new Rectangle(5, 15);

Shape2D triangle = new Triangle(5, 15, 30);


List<Shape2D> shapes2d = new List<Shape2D>();

shapes2d.Add(triangle);
shapes2d.Add(shape2D);
//shapes2d.Add(shape1D);

foreach (var item in shapes2d)
{
    item.Sth();
    Console.WriteLine(item.CalculateArea());
}


