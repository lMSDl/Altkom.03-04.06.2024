//namespace - przestrzeń nazw, czyli adres pod którym "mieszka" klasa
//namespace zaciągamy używając "using"
using System;
using System.Xml.Linq;

namespace ConsoleApp
{

    internal partial class Person
    {
        public static int PopulationCounter { get; private set; }

        //brak określenia typu zwracanego i nazwa taka sama jak nazwa klasy
        //metoda konstrukcyjna  (konstruktor) - bezparametrowy
        //metody konstrukcyjne są potrzebne, aby wstępnie skonfigurować obiekt
        //jeśli klasa nie ma żadnego zdefiniowanego konstruktora, to konstruktor bezparametrowy jest generowany automatycznie
        public Person()
        {
            PopulationCounter += 1;

            _firstName = "none";
            LastName = "none";
        }

        //konstruktor parametrowy - służy do zapewnienia klasie wartości początkowych przekazanych jako parametry
        //jeśli w klasie występuje jakiś konstuktor parametrowy, to konstuktor bezparametrowy nie zostanie automatycznie wygenerowany
        //chcąc posiadać jednocześnie konstruktor parametrowy i bezparametrowy musimy go jawnie utworzyć
        //możemy tworzyć konstruktory teleskopowe, czyli łańcuch wywołań konstruktorów
        private Person(string firstName, string lastName, int age) : this(firstName, lastName)
        {
            this.age = age;
        }
        //przeciążenie metody = wiele metod o tej samej nazwie, ale przyjmujące inne parametry (konstruktor jest metodą)
        private Person(string firstName, string lastName) : this(lastName)
        {
            _firstName = firstName;
        }
        private Person(string lastName)
        {
            LastName = lastName.ToUpper();
        }


        public static async Task<Person> CreateAsync(string firstName, string lastName, int age)
        {
            Person p = new Person(firstName, lastName, age);

            await Task.Delay(5000);

            return p;
        }


        public bool IsInitialized { get; private set; }
        public void Initialize()
        {
            if (IsInitialized)
            {
                return;
            }

            //do sth
            Thread.Sleep(5000);

            IsInitialized = true;
        }
    }
}
