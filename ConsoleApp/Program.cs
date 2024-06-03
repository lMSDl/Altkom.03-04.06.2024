//namespace ConsoleApp
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {




//Examples.HelloWorld();
//Examples.StringsAndNumbers();


using System;

int a = 5;
int b = 10;
int c = 15;


//deklaracja tablicy przechowującej dane typu int
//[] - tablica
int[] array;

//inicjalizujemy zmienną nową tablicą typu int o rozmiarze 3
//tablica wypełniana jest wartościami domyślnymi zadeklarowanego typu (dla int jest to 0)
array = new int[3];

Console.WriteLine(  );

Console.WriteLine(array[0]);
Console.WriteLine(array[1]);
Console.WriteLine(array[2]);

//tablice są indeksowane od 0 (minimalny indeks)
//odwołujemy się do pierwszgo elemntu tablicy, czyli pod indeks 0
array[0] = a;
array[1] = 10;

foreach ( int i in array )
{
    Console.WriteLine(i);
}

//maksymalny indeks tablicy to rozmiar minus 1 (3 - 1 = 2)
//array[2] = c;
array[array.Length - 1] = int.Parse(System.Console.ReadLine());


for ( int i = 0; i < array.Length; i++ )
{
    Console.WriteLine(array[i]);
}

Console.WriteLine($"Tablica ma rozmiar {array.Length}");

Array.Resize(ref array, 6);

Console.WriteLine($"Tablica ma rozmiar {array.Length}");

string input = Console.ReadLine();

string[] splittedInput = input.Split();


Console.WriteLine($"Tablica ma rozmiar {splittedInput.Length}");
//        }
//   }
//}