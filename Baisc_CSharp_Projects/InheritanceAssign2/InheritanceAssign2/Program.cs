using System;

namespace InheritanceAssign2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> stuff = new Employee<string>();
            stuff.Things = new List<string> { "Book", "Car", "Ball", "Pool"};
            
            Employee<int> otherStuff = new Employee<int>();
            otherStuff.Things = new List<int> { 1, 4, 25, 66, 100 };
            
            
            for (int i = 0; i < stuff.Things.Count; i++)
            {
                Console.WriteLine(stuff.Things[i]);
                Console.WriteLine(otherStuff.Things[i]);
            }
            



            //Employee person1 = new Employee();
            //Employee person2 = new Employee();

            //person1.FirstName = "Sample";
            //person1.LastName = "Student";
            //person1.Id = Convert.ToInt32("1234");
            //person1.SayName();

            //person2.FirstName = "Bill";
            //person2.LastName = "North";
            //person2.Id = Convert.ToInt32("1234");
            //person2.SayName();

            //if (person1 == person2)
            //    Console.WriteLine("The two employee's have the same ID.");
            //else
            //    Console.WriteLine("The two employee's have different ID's");


            ////Use polymorphism to create an object of type IQuittable and call the Quit() method on it.
            //person1.Quit(person1);
            //person2.Quit(person2);
        }
    }
}
