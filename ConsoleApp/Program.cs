using ConsoleApp;
using System;

//namespace ConsoleApp
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
            Console.WriteLine("Hello, World!");
            void Sth() { }


int? a = 5;
a = null;

Person? p = new Person();
p.Name = "Ewa";

ChangeInt(a);

p = null;

if(p != null)
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


//        }
//   }
//}