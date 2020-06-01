using System;

namespace ExceptionHandlingAssign2
{
    class Program
    {
        static void Main(string[] args)
        {
            int userAge=0;
            try
            {
                Console.WriteLine("What is your age?");
                userAge = Convert.ToInt32(Console.ReadLine());
                if (userAge == 0 || userAge < 0)
                {
                    throw new ZeroNegativeException();
                }
                int userBorn = DateTime.Now.Year - userAge;
                Console.WriteLine("You were born in: " + userBorn);
                Console.ReadLine();
            }            
            catch (ZeroNegativeException) 
            {
                Console.WriteLine("Please enter a number that is non zero and not negative.");
                Console.ReadLine();                
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong.");
            }
        }
    }
}
