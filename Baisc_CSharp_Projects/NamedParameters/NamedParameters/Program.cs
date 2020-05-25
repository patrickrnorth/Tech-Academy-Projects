using System;

namespace NamedParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNum = 10;
            int myNum2 = 12;
            MathOperation.myOperation(myNum, myNum2);
            MathOperation.myOperation(secondNum: myNum2, firstNum: myNum);
        }
    }
}
