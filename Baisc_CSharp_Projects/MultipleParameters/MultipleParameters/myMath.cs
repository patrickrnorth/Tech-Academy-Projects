using System;
using System.Collections.Generic;
using System.Text;

namespace MultipleParameters
{
    public class myMath
    {
        public int AddInts(int userNum, int userNum2 = 0)
        {
            int newUserNum = userNum + userNum2;
            return newUserNum;
        }
    }
}
