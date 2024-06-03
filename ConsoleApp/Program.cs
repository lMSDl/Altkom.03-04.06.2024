using ConsoleApp;
using System;
using System.Xml.Linq;

//namespace ConsoleApp
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {


//deklaracja z inicjalizacją
string helloVariable = "Hello";

Console.WriteLine("Podaj imię:");
string targetValue = Console.ReadLine();

Console.WriteLine(helloVariable);

Console.Write(helloVariable);
Console.WriteLine(targetValue);

//deklaracja zmiennej o typie string (ciąg/łańcuch znaków) i nazwie output
string output;
//nie możemy używać niezainicjalizowanej zmiennej

//inicjalizacja zmiennej - pierwsze przypisanie wartości
//łączenie stringów za pomocą operatora +
output = helloVariable + " " + targetValue + "!";
Console.WriteLine(output);


string format = "{0} {1}!"; //wartości w nazwiasach oznaczają indeks parametru, który ma być wstawiony w to miejsce
output = string.Format(format, helloVariable, targetValue); //łączenie stringów za pomocą funkcji format

Console.WriteLine(output);

//zmiana wartości - każde kolejne przypisanie wartości
output = "{helloVariable} {targetValue}!";
Console.WriteLine(output);

output = $"{helloVariable} {targetValue}!"; //łączenie wykorzystujące interpolację (string interpolowany)
Console.WriteLine(output);

string input = Console.ReadLine();

//parsowanie/konwersja string na float
//float a = float.Parse(input);
float a;

//TryParse - zwraca wartość bool mówiącą czy parsowanie się powiodło
//out - parameter wyjściowy - parametr przez który metoda może nam zwrócić jakąś dodatkową wartość (w tym przypadku jest to wynik parsowania)
// jeśli parsowanie się nie powiodło, to w parametrze wyjściowym będzie wpisana wartość domyślna typu (dla typów liczbowych jest to 0)
bool success = float.TryParse(input, out a);

if (success)
{
    float b = a * 6;

    Console.WriteLine(b);
}
else
{
    Console.WriteLine("Błędna wartość");
}

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