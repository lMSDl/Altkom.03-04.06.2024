
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


Person p2 = new Person("Ewa", "Ewowska", 24);

Console.WriteLine(p2.GenerateInfo());

//wykorzystanie inicjalizatora
Person p3 = new Person() { Age = 30, LastName = "Adamski" };


Plant plant = new Plant("drzewo");


//        }
//   }
//}