using System;

namespace NamedParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNum = 10;
            int myNum2 = 12;
            
            //initialize a MathOperation object
            MathOperation myOp = new MathOperation();

            //Call the method in the class, passing in two numbers.
            myOp.myOperation(myNum, myNum2);
            //Call the method in the class, specifying the parameters by name.
            myOp.myOperation(secondNum: myNum2, firstNum: myNum);
        }
    }
}
