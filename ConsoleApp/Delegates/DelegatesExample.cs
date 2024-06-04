using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Delegates
{
    //delegaty to wskaźniki na funkcje
    public class DelegatesExample
    {

        delegate void VoidWithoutParameters();
        delegate void VoidWithStringParameter(string someString);
        delegate bool BoolWithTwoIntParameters(int x, int y);

        public void Func1()
        {
            Console.WriteLine("1");
        }
        public void Func2(string @string)
        {
            Console.WriteLine(@string);
        }
        public bool Func3(int a, int b)
        {
            Console.WriteLine("a = " + a + " ,b = " + b);
            return a == b;
        }

        BoolWithTwoIntParameters Delegate3 { get; set; }

        public void Test()
        {

            VoidWithoutParameters delegate1 = new VoidWithoutParameters(Func1);
            delegate1.Invoke();

            VoidWithStringParameter? delegate2 = null;
            delegate2 = Func2;
            
            delegate2.Invoke("Hello!");

            Delegate3 = Func3;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    var result = Delegate3(i, j);
                    if (result)
                        Console.WriteLine("==");
                }
            }
        }

    }
}
