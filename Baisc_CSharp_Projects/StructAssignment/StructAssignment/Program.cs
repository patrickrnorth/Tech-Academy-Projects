using System;

namespace StructAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Number myNum = new Number();
            myNum.Amount = 3.5m;          
            Console.WriteLine(myNum.Amount);
        }
        public struct Number
        {
            public decimal Amount;            
        }
    }
}
