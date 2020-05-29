using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace ConstVarChainConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            const string myName = "Ryan";
            var primeNumbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
          
        }

        public string FirstName;
        public string LastName;
        public void Person(string firstName) : this(firstName, "")
        {

        }
        public void Person(string firstName, string lastName)
        {
            LastName = lastName;
            FirstName = firstName;
        }

    }
}
