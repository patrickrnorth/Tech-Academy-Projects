using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    class Class1
    {
        public string FirstName;
        public string LastName;

        public Class1(string firstName) : this(firstName, "")
        {

        }
        public Class1(string firstName, string lastName)
        {
            LastName = lastName;
            FirstName = firstName;
        }
    }
}
