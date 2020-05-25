using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BasicMathClasses.cs
{
    class mathFunc
    {
        public static int addInt(int num)
        {
            int myNum = num;
            int myNumAdd = myNum + 10;
            return myNumAdd;
        }

        public static int subInt(int num)
        {
            int myNum = num;
            int myNumSub = myNum - 5 ;
            return myNumSub;
        }

        public static int multInt(int num)
        {
            int myNum = num;
            int myNumMult = myNum * 10;
            return myNumMult;
        }
    }
}
