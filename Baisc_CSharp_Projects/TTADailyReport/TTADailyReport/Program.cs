using System;

namespace TTADailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome message
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            
            //Ask what course
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
            
            //Ask what page number
            Console.WriteLine("What page number?");
            string pageNumString = Console.ReadLine();
            short pageNumShort = Convert.ToInt16(pageNumString);

            //User help?
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\" ");
            string needHelpString = Console.ReadLine();
            bool needHelpBool = Convert.ToBoolean(needHelpString);

            //Positive Experiences?
            Console.WriteLine("Where there any positive experiences you'd like to share? Please give specifics.");
            string posExp = Console.ReadLine();

            //Feedback?
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            //Hours studied
            Console.WriteLine("How many hours did you study today?");
            string hoursStudyString = Console.ReadLine();
            short hoursStudyInt = Convert.ToInt16(hoursStudyString);

            //End message
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();


        }
    }
}
