using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal static class PersonExtensions
    {

        public static string GetFullName(this Person person)
        {
            return $"{person.GetFistName()} {person.LastName}";
        }

    }
}
