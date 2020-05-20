using System;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Prompt user to input package weight
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please input your package weight:");
            string packageWeightStr = Console.ReadLine();
            int packageWeight = Convert.ToInt32(packageWeightStr);
            
            //determine if the package is too heavy
            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return;
            }

            //Prompt user to input package width
            Console.WriteLine("Please input your package width:");
            string packageWidthStr = Console.ReadLine();
            int packageWidth = Convert.ToInt32(packageWidthStr);

            //Prompt user to input package height
            Console.WriteLine("Please input your package height:");
            string packageHeighStr = Console.ReadLine();
            int packageHeight = Convert.ToInt32(packageHeighStr);

            //Prompt user to input package length
            Console.WriteLine("Please input your package length:");
            string packageLengthStr = Console.ReadLine();
            int packageLength = Convert.ToInt32(packageLengthStr);

            //determine if the package is too heavy
            if ((packageWidth + packageHeight + packageLength) > 50)
            {
                Console.WriteLine("Package too big to be shipped via package Express.");
                return;                
            }

            //Determine quote for package and print to user
            float quote = (packageWidth * packageHeight * packageLength * packageWeight) / 100.0f;
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote);
            Console.WriteLine("Thank you.");
            Console.ReadLine();
        }
    }
}
