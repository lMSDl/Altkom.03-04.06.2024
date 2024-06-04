
using System;
using ConsoleApp.Delegates;
//namespace ConsoleApp
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {




//Examples.HelloWorld();
//Examples.StringsAndNumbers();
//Examples.ArraysAndLists();
//Examples.Classes();

new DelegatesExample().Test();
new MulticastDelegateExample().Test();

Console.WriteLine("-----------");
EventsExample eventsExample = new EventsExample();
eventsExample.OddNumberDelegate += Odd;
eventsExample.OddNumberEvent += Odd;
eventsExample.Test();
void Odd()
{
    Console.WriteLine("!!!");
}

Console.ReadLine();
//        }
//   }
//}