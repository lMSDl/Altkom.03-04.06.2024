//namespace - przestrzeń nazw, czyli adres pod którym "mieszka" klasa
//namespace zaciągamy używając "using"
using System;
using System.Xml.Linq;

namespace ConsoleApp
{
    //pełna nazwa klasy to <namespace>.<nazwaKlasy>

    //class - szablon opisujący zachowania i cechy obiektów (instancji klas), które są wytwarzane na jej podstawie
    //internal - modyfikator dostępu - oznacza, że z klasy można korzystać tylko w projekcie "rodzimym"
    //public - modyfikator dostępu - oznacza, że z klasy można korzystać wszędzie
    //brak modyfikatora dostępu = internal (najbardziej restrykcyjny modyfikator dostępu)

    // <modyfikator dostępu> class <nazwaKlasy>
    internal class Person
    {
        //pole klasy (field)
        //private - oznacza dostęp tylko dla elementów danej klasy
        //pola zazwyczaj są prywatne ze względu na hermetyzację, a dostęp realizowany jest przez metody dostępowe (getter i setter)
        //konwencje nazewnicta: nazwa / _nazwa / m_nazwa
        private string _firstName;

        //setter - do ustawiania wartości imienia - metoda przyjmuje parametr, który zostaje wpisany w odpowiednie pole (można dodać kod "obróbki danych")
        //void - metoda nic nie zwaraca
        public void SetFirstName(string firstName)
        {
            //this = wskazuje, że korzystamy z pola w klasie o tej samej nazwie co parametr metody
            //this.firstName = firstName;
            _firstName = firstName;
            //obróbka danych
            //_firstName = firstName.ToUpper();
        }

        //getter dobrania wartości pola _firstName - metoda zwraca typ zgodny z typem pola
        //string - metoda zwraca string
        public string GetFistName()
        {
            //instukcja zwracająca wynik działania metody - obowiązkowy gdy zadeklarowaliśmy, że klasa coś zwraca (jest inna niż void)
            return _firstName;
        }

        //Property - właściwość

        //auto-property
        //właściwość integruje w sobie pole i metody dostępowe (getter i setter)
        //jest możliwość zmiany modyfikatora dostępu dla getter lub setter (osobno)
        //możemy tylko ograniczać poziom dostępu dla gettera i settera (nie można określić właściwości jako private i następnie ustawić public get)
        public string LastName { get; /*private*/ set; }


        
        //backfield do full-property - pozwala na dodatkowy kod w setterze i getterze
        private int age;
        //full-property
        public int Age
        {
            //getter dla property
            get
            {
                return age;
            }
            //setter dla property - posiada niejawny parametr o nazwie value
            set
            {
                if (age <= 0)
                    throw new ArgumentException();

                age = value;
            }
        }
    }
}
