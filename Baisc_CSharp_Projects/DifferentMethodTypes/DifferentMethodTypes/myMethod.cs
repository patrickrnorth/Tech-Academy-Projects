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

        public static int myMethodOp(int userNum, int myNum)
        {
            int newNum = userNum + myNum;            
            return newNum;
        }
        //using out parameter
        public void myMethodOut(int userNum, out int extraNum)
        {
            extraNum = userNum + 1;
        }
    }
}
