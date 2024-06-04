
using System;
using ConsoleApp;
//namespace ConsoleApp
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {




//Examples.HelloWorld();
//Examples.StringsAndNumbers();
//Examples.ArraysAndLists();

Person p1 = new Person();

Console.WriteLine(p1.GenerateInfo());


//Person p2 = new Person("Ewa", "Ewowska", 24);
Person.CreateAsync("Ewa", "Ewowska", 24).ContinueWith(t =>
{
    Console.WriteLine(t.Result.GenerateInfo());
});

//wykorzystanie inicjalizatora
Person p3 = new Person() { Age = 30, LastName = "Adamski" };

Console.WriteLine(p3.GenerateInfo());

Plant plant = new Plant("drzewo");



Console.ReadLine();
//        }
//   }
//}