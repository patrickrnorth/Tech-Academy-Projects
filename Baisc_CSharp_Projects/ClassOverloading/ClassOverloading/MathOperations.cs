using System;
using System.Collections.Generic;
using System.Text;

namespace ClassOverloading
{
    public class MathOperations
    {
        //will receive int parameter and do an addition operation on it and return as an integer.
        public static int myOpperation(int userNum)
        {
            int myNum = userNum;
            int myNumAdd = myNum + 10;
            return myNumAdd;
        }

        //will receive decimal parameter and do an multiplication operation on it and return as an integer .
        public static int myOpperation(decimal userNum)
        {
            int myNum = Convert.ToInt32(userNum);
            int myNumMult = myNum * 10;
            return myNumMult;
        }

        //will recieve a string parameter, convert to integer then divide by 10 then return an integer.
        public static int myOpperation(string userNum)
        {
            int myNum = Convert.ToInt32(userNum);
            int myNumDivide = myNum / 10;
            return myNumDivide;
        }
        
    }
}
