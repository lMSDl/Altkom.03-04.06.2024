using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Delegates
{
    internal class LambdaExpressionsExample
    {
        Func<int, int, int> Calculator { get; set; }
        Func<string> SomeFunc { get; set; }
        Action<int> SomeAction { get; set; }
        Action AnotherAction { get; set; }


        public void Test()
        {
            Calculator += Plus;

            Calculator += delegate (int a, int b) { return a + b; };
            //wyrażenie lambda
            //<opcjonalny parametr> <operator> <ciało>
            // (a, b) => {}
            //Calculator +=  (int a, int b) => { return a + b; };
            //Calculator += (a, b) => { return a + b; };
            Calculator += (a, b) => a + b;

            SomeFunc += //delegate { return "Hello!"; };
                        () => "Hello!";

            SomeAction += //delegate (int a) { Console.WriteLine(a); };
                          //(a) => Console.WriteLine(a);
                            a => Console.WriteLine(a);

            AnotherAction += //delegate { Console.WriteLine(); };
                                () => Console.WriteLine();

        }

        private int Plus(int a, int b)
        {
            return a + b;
        }
    }
}
