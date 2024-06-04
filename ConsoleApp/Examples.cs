using System;
using System.Linq;

namespace ConsoleApp
{
    internal class Examples
    {
        public static void ArraysAndLists()
        {

            int a = 5;
            int b = 10;
            int c = 15;


            //deklaracja tablicy przechowującej dane typu int
            //[] - tablica
            int[] array;

            //inicjalizujemy zmienną nową tablicą typu int o rozmiarze 3
            //tablica wypełniana jest wartościami domyślnymi zadeklarowanego typu (dla int jest to 0)
            array = new int[3];

            Console.WriteLine();

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

            foreach (int i in array)
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
            //var strings = new List<string>();
            List<string> strings = new();

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


        }


        public static void StringsAndNumbers()
        {
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
        }

        public static void HelloWorld()
        {
            Console.WriteLine("Hello, World!");
            void Sth() { }


            int? a = 5;
            a = null;

            Person? p = new Person();
            p.SetFirstName("Ewa");

            p = new Person();

            ChangeInt(a);

            //p = null;

            if (p != null)
                ChangePerson(p);

            Console.WriteLine(a);
            Console.WriteLine(p.GetFistName());
            p.LastName = "Ewowska";
            //Console.WriteLine( PersonExtensions.GetFullName(p) );
            Console.WriteLine(p.GetFullName());

            void ChangeInt(int? a)
            {
                a = 6;
            }

            void ChangePerson(Person p)
            {
                p.SetFirstName("Adam");
            }
        }

        public static void Classes()
        {
            Person p1 = new Person();

            Console.WriteLine(p1.GenerateInfo());


            //Person p2 = new Person("Ewa", "Ewowska", 24);
            Person.CreateAsync("Ewa", "Ewowska", 24).ContinueWith(t =>
            {
                Console.WriteLine(t.Result.GenerateInfo());
            });

            //wykorzystanie inicjalizatora
            Person p3 = new Person() { Age = 30, LastName = "Adamski" };
            p3.SetFirstName("Adam");
            Person p4 = new Person("Monika", "Monikowska", 42);
            Console.WriteLine(p3.GenerateInfo());
            Console.WriteLine(p4.GenerateInfo());

            Person p5 = p3 + p4;


            Console.WriteLine(p5.GenerateInfo());




            Plant plant = new Plant("drzewo");
        }


    }
}
