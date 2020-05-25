using System;
using System.Collections.Generic;
using System.Text;

namespace DifferentMethodTypes
{
    public class myMethod
    {
        public void myMethodOp(int userNum)
        {
            Console.WriteLine("Your number divided by two is: " + (userNum / 2));
        }

        public static int myMethodOp(int userNum, int myNum, out int extraNum)
        {
            int newNum = userNum + myNum;
            extraNum = newNum + 10;
            return newNum;
        }


    }
}
