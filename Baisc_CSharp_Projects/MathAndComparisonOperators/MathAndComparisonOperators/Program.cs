using System;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            
            //Input Person 1 Hourly Rate
            Console.WriteLine("Hourly Rate?");
            string person1HourlyStr = Console.ReadLine();
            int person1Hourly = Convert.ToInt16(person1HourlyStr);
            
            //Input Person 1 Hours per week
            Console.WriteLine("Hours per week?");
            string person1HoursWeekStr = Console.ReadLine();
            int person1HoursWeek = Convert.ToInt16(person1HoursWeekStr);

            Console.WriteLine("Person 2");

            //Input Person 2 Hourly Rate
            Console.WriteLine("Hourly Rate?");
            string person2HourlyStr = Console.ReadLine();
            int person2Hourly = Convert.ToInt16(person2HourlyStr);

            //Input Person 2 Hours per week
            Console.WriteLine("Hours per week?");
            string person2HoursWeekStr = Console.ReadLine();
            int person2HoursWeek = Convert.ToInt16(person2HoursWeekStr);

            //Calculate annual salary for person 1
            int annualSalPerson1 = (person1Hourly * person1HoursWeek) * 52;
            Console.WriteLine("Annual salary of Person 1: " + annualSalPerson1);

            //Calculate annual salary for person 2
            int annualSalPerson2 = (person2Hourly * person2HoursWeek) * 52;
            Console.WriteLine("Annual salary of Person 2: " + annualSalPerson2);

            //Calculate which person makes more money
            bool makesMore = annualSalPerson1 > annualSalPerson2;
            Console.WriteLine("Does Person 1 make more money than Person 2? " + makesMore);

        }
    }
}
