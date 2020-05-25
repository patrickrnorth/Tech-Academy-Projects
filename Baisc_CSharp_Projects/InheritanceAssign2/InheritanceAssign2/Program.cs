using System;

namespace InheritanceAssign2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee person1 = new Employee();
            person1.FirstName = "Sample";
            person1.LastName = "Student";
            person1.SayName();
        }
    }
}
