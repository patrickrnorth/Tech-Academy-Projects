using System;
using System.Collections.Generic;

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
            }
            for (int i = 0; i < stuff.Things.Count; i++)
            {                
                Console.WriteLine(otherStuff.Things[i]);
            }

        //    employee person1 = new employee();
        //    employee person2 = new employee();

        //    person1.firstname = "sample";
        //    person1.lastname = "student";
        //    person1.id = convert.toint32("1234");
        //    person1.sayname();

        //    person2.firstname = "bill";
        //    person2.lastname = "north";
        //    person2.id = convert.toint32("1234");
        //    person2.sayname();

        //    if (person1 == person2)
        //        console.writeline("the two employee's have the same id.");
        //    else
        //        console.writeline("the two employee's have different id's");


        //    //use polymorphism to create an object of type iquittable and call the quit() method on it.
        //    person1.quit(person1);
        //    person2.quit(person2);
        }
    }
}
