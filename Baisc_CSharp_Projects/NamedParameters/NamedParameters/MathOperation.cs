using System;
using System.Collections.Generic;
using System.Text;

namespace NamedParameters
{
    public class MathOperation
    {
        public static void myOperation(int firstNum, int secondNum)
        {
            int myNumAdd = firstNum + 10;
            Console.WriteLine("The second number is: " + secondNum);
        }
    }
}
