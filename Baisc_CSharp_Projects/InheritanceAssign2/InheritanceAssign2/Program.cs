using System;

namespace InheritanceAssign2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee person1 = new Employee();
            Employee person2 = new Employee();
            person1.FirstName = "Sample";
            person1.LastName = "Student";
            person1.Id = Convert.ToInt32("1234");
            person1.SayName();

            person2.FirstName = "Bill";
            person2.LastName = "North";
            person2.Id = Convert.ToInt32("1234");
            person2.SayName();

            if (person1 == person2)
                Console.WriteLine("The two employee's have the same ID.");
            else
                Console.WriteLine("The two employee's have different ID's");

            
            //Use polymorphism to create an object of type IQuittable and call the Quit() method on it.
            person1.Quit(person1);
            person2.Quit(person2);
        }
    }
}
