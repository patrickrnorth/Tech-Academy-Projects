﻿using System;

namespace MultipleParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input an integer: ");
            int userNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please input a second integer (optional): ");
            bool userNum2IsValid = int.TryParse(Console.ReadLine(), out int userNum2);

            myMath myNumObj = new myMath();

            int result = 0;
            if (userNum2IsValid)
            {
                result = myNumObj.AddInts(userNum, userNum2);
            }
            else
            {
                result = myNumObj.AddInts(userNum);
            }
                       

            Console.WriteLine("Your result is: " + result);
            Console.ReadLine();
        }
    }
}

