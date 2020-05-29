using System;

namespace DateTimeAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;//Determine current time
            Console.WriteLine(dateTime);
            Console.WriteLine("Please enter a number: ");
            int userNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The time " + userNum + " hours from now is: " + dateTime.AddHours(userNum));//add user specified hours to current time and display it.

        }
    }
}
