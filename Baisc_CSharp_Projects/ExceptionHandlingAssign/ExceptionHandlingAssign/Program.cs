using System;
using System.Collections.Generic;

namespace ExceptionHandlingAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            //try to catch any errors
            try
            {
                //Create list of numbers
                List<int> myNums = new List<int>();
                myNums.Add(10);
                myNums.Add(20);
                myNums.Add(30);
                myNums.Add(40);
                myNums.Add(50);
                myNums.Add(60);
                myNums.Add(70);
                myNums.Add(80);
                myNums.Add(90);
                myNums.Add(100);

                //prompt user to input a dividend
                Console.WriteLine("Please enter a number to divide the List of numbers by: ");
                int userNum = Convert.ToInt32(Console.ReadLine());


                //loop will divide that number and print the result
                foreach (int num in myNums)
                {
                    int dividedNum = num / userNum;
                    Console.WriteLine(num + " divided by " + userNum + " is: " + dividedNum);
                }
                Console.ReadLine();
            }
            //catch blocks for my code
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            { 
                Console.WriteLine("Try/Catch block has run, proceeding with program execution.");
            }
        }
    }
}
