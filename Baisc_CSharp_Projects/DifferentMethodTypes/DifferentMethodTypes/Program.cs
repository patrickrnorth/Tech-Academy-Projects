using System;

namespace DifferentMethodTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate myMethod class
            myMethod newMethod = new myMethod();

            //User number is divided by two and is output within the method
            Console.WriteLine("Please input an integer: ");
            int userNum = Convert.ToInt32(Console.ReadLine());
            newMethod.myMethodOp(userNum);
            
            //static overload method with an out parameter
            int myNum = 1;
            Console.WriteLine("Your number plus my number is: " + myMethod.myMethodOp(userNum, myNum));
            newMethod.myMethodOut(userNum, out int extraNum);
            Console.WriteLine("That number plus one is: " + extraNum );
        }
    }
}
