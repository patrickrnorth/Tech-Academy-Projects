using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciate new employee and set their name
            Employee person1 = new Employee() { FirstName = "Sample", LastName = "Student" } ;
            //Call the inherited person method to display the Employee name
            person1.SayName();
        }
    }
}
