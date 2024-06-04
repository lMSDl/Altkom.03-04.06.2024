using System.Linq;

namespace ConsoleApp.Delegates
{
    internal class LINQ
    {
        private readonly int[] numbers = new[] { 1, 2, 5, 7, 3, 8, 0, 9 };
        private readonly IEnumerable<string> strings = "Ala ma kota i dwa psy".Split(' ').ToList();
        private readonly IEnumerable<Person> People =
        [
            new Person ("Adam", "Adamski", 23 ),
            new Person ( "Ewa", "Adamska",  32 ),
            new Person ("Adam",  "Ewowski",  35 ),
            new Person ("Ewa",  "Ewowska",  63 ),
            new Person ("Piotr",  "Piotrowski",  33 ),
            new Person ("Piotr",  "Adamski",  66 ),
            new Person ("Ewa",  "Piotrowska",  72 ),
            new Person ("Piotr",  "Ewowski",  42 ),
            //new Person ("Tomasz",  "Tomaszewski",  42 ),
        ];

        public void Test()
        {

            var result1 = numbers.Where(number => number > 4).ToList();
            var result2 = numbers.Where(number => number > 4).OrderByDescending(x => x).ToList();
            var result3 = People.Where(x => x.Age > 35).Select(x => $"{x.GetFistName()} {x.LastName}").ToList();

            var result4 = People.Where(x => x.GetFistName() == "Tomasz")//.Single(); //kończy zapytanie i zwraca JEDEN rezultat 
                                                                        // .SingleOrDefault(); //orDefault = jeśli nie znaleziono to zwraca wartość domyślną
                                                                        //.First(); // -||- i zwraca pierwszy znaleziony
                                                                        .FirstOrDefault();
            //.Last(); // -||- ostatni znaleziony
            //.LastOrDefault();

            var result5 = People.Select(x => x.Age).Average();

            var result6 = People.Skip(1).Take(4).ToList();

            var result7 = strings.Where(x => x.Length >= 3).Where(x => x.Contains("a")).OrderBy(x => x).ToList();


            //1. posortować kolekcję strings po ilości liter w wyrazach
            //2. Zsumować wartości kolekcji numbers
            //3. Z People wybrać osoby, które mają na imię Piotr lub Ewa
        }
    }
}
