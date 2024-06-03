using ConsoleApp;
using System;
using System.Xml.Linq;

//namespace ConsoleApp
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {


string helloVariable = "Hello";

Console.WriteLine("Podaj imię:");
string targetValue = Console.ReadLine();

Console.WriteLine(helloVariable);

Console.Write(helloVariable);
Console.WriteLine(targetValue);

string output;

//łączenie stringów za pomocą operatora +
output = helloVariable + " " + targetValue + "!";
Console.WriteLine(output);


string format = "{0} {1}!"; //wartości w nazwiasach oznaczają indeks parametru, który ma być wstawiony w to miejsce
output = string.Format(format, helloVariable, targetValue); //łączenie stringów za pomocą funkcji format

Console.WriteLine(output);

output = "{helloVariable} {targetValue}!";
Console.WriteLine(output);

output = $"{helloVariable} {targetValue}!"; //łączenie wykorzystujące interpolację (string interpolowany)
Console.WriteLine(output);




static void HelloWorld()
{
    Console.WriteLine("Hello, World!");
    void Sth() { }


    int? a = 5;
    a = null;

    Person? p = new Person();
    p.Name = "Ewa";

    ChangeInt(a);

    p = null;

    if (p != null)
        ChangePerson(p);

    Console.WriteLine(a);
    Console.WriteLine(p.Name);


    void ChangeInt(int? a)
    {
        a = 6;
    }

    void ChangePerson(Person p)
    {
        p.Name = "Adam";
    }
}


//        }
//   }
//}