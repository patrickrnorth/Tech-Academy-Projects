using System;

namespace ClassOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input an integer to operate on: ");
            int userNum = Convert.ToInt32(Console.ReadLine());

            int newNum = MathOperations.myOpperation(userNum);

            Console.WriteLine("Your integer plus 10 is: " + newNum);
            Console.ReadLine();

            Console.WriteLine("Please input a decimal to operate on: ");
            float userNumFloat = float.Parse(Console.ReadLine());

            float newNumFloat = MathOperations.myOpperation(userNumFloat);

            Console.WriteLine("Your decimal multiplied by 10 is: " + newNumFloat);
            Console.ReadLine();

            Console.WriteLine("Please input a integer to operate on: ");
            int newNumDivide = MathOperations.myOpperation(Console.ReadLine());

            Console.WriteLine("Your integer divided by 10 is: " + newNumDivide);
            Console.ReadLine();
        }
    }
}
