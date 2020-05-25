using System;

namespace ClassOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //User inputs integer to add 10 and return an integer then print the result to the display.
            MathOperations myOp = new MathOperations();//new MathOperations object
            
            Console.WriteLine("Please input an integer to operate on: ");
            int userNum = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Your integer plus 10 is: " + myOp.myOpperation(userNum));
            

            //User inputs decimal to add 10 and return an integer then print the result to the display.
            MathOperations myOp2 = new MathOperations();//new MathOperations object

            Console.WriteLine("Please input a decimal to operate on: ");
            decimal userNumFloat = Decimal.Parse(Console.ReadLine());
                       
            Console.WriteLine("Your decimal multiplied by 10 is: " + myOp2.myOpperation(userNumFloat));
            

            //User inputs string, class will recieve string parameter and convert to integer. Class will divide by 10 and return an int.
            MathOperations myOp3 = new MathOperations(); //new MathOperations object
            Console.WriteLine("Please input a integer to operate on: ");

            Console.WriteLine("Your integer divided by 10 is: " + myOp3.myOpperation(Console.ReadLine()));
            Console.ReadLine();
        }
    }
}
