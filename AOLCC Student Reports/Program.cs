using System;


namespace AOLCC_Student_Reports
{
    class Program
    {
        static void Main(string[] args)
        {
            //greetings just to display//
            Console.WriteLine("Academy of Learning Career College");
            Console.WriteLine("Student Daily Report");
            //asking What is your name? and having user put in an answer as a string//
            Console.WriteLine("What is your First and Last name?");
            string name = Console.ReadLine();
            //asking What course are you on? and having user input answer as a string//
            Console.WriteLine("What course are you studying right now?");
            string course = Console.ReadLine();
            //asking What page number? and having user input answer as a integer to be displayed//
            Console.WriteLine("What page are you on in the course?");
            int pageNumber = Convert.ToInt32(Console.ReadLine());
            //asking Do you need help with anything? Please answer “true” or “false”. as a string convert to boolean//
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            String helpWith = Console.ReadLine();
            bool helpWithbool = bool.Parse(helpWith);
            //asking Were there any positive experiences you’d like to share? Please give specifics. as as string for user to input//
            Console.WriteLine("Were there any positive experiences you'd like to share in detail?");
            String posExperiences = Console.ReadLine();
            //asking Is there any other feedback you’d like to provide? Please be specific. as as string for user to input//
            Console.WriteLine("Is there any specific feedback you'd like to give?"); 
            String feedBack = Console.ReadLine();
            //asking How many hours did you study today? as a string and convert to integer for the user to input//
            Console.WriteLine("How many hours did you spend studying today?");
            string studyHours = Console.ReadLine();
            int studyHoursNum = Convert.ToInt32(studyHours);
            //salutations for the user to read on display//
            Console.WriteLine("Thank you for your answers....Your Instructor will respond to you shortly.  Have a wonderful day!");
            //input to keep display up for user instead of auto closing//
            Console.ReadLine();

        }
    }
}
