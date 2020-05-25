using System;

namespace BasicMathClasses.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer to perfrom math opperations on: ");
            int userNum = Convert.ToInt32(Console.ReadLine());
            
            int newNumAdd = mathFunc.addInt(userNum);
            int newNumSub = mathFunc.subInt(userNum);
            int newNumMult = mathFunc.multInt(userNum);

            Console.WriteLine("Your number plus 10 is: " + newNumAdd);
            Console.WriteLine("Your number subtracted by 5 is: " + newNumSub);
            Console.WriteLine("Your number multiplied by 10 is: " + newNumMult);
            Console.ReadLine();
        }
    }
}
