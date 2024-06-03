

using System;
using System.Linq;

//namespace ConsoleApp
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {




//Examples.HelloWorld();
//Examples.StringsAndNumbers();


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
//maksymalny indeks tablicy to rozmiar minus 1 (3 - 1 = 2)
//array[2] = c;
array[array.Length - 1] = int.Parse(System.Console.ReadLine());

foreach ( int i in array )
{
    Console.WriteLine(i);
}


Console.WriteLine($"Tablica ma rozmiar {array.Length}");

Array.Resize(ref array, 6);

Console.WriteLine($"Tablica ma rozmiar {array.Length}");

string input = Console.ReadLine();

string[] splittedInput = input.Split();


Console.WriteLine($"Tablica ma rozmiar {splittedInput.Length}");






//tworzymy nową listę. Lista po inicjalizacji jest pusta.
List<string> strings = new List<string>();

//dodajemy nowy element do listy, rozmiar tablicy się zwiększa
strings.Add("!");
strings.Add("ala");
strings.Add("kota");

//stawiamy element na konkretny indeks listy - pozostałe ementy przesuwają się
strings.Insert(2, "ma");

strings.Add("!");
strings.Add("!");


//usuwamy element pod indeksem 2 - rozmiar listy się zmniejsza
strings.RemoveAt(2);
//usuwamy element wg wartości - jeśli występuję więcej takich elementów, to usuwany jest pierwszy w kolejności
strings.Remove("!");


//w listach odwołujemy się do elementów po indeksach (tak jak w tablicach)
strings[strings.Count - 1] = "?";


strings = input.Split().ToList();

Console.WriteLine($"Lista ma rozmiar: {strings.Count}");



for (int i = 0; i < strings.Count; i++)
{
    Console.WriteLine(strings[i]);
}







//        }
//   }
//}