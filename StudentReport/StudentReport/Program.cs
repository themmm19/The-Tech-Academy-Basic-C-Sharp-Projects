using System;
using System.Runtime.Remoting.Lifetime;


namespace StudentReport
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            //What is your name?
            Console.WriteLine("\nWhat is your name?");
            string studentName = Console.ReadLine();

            // What course are you on?
            Console.WriteLine("What Course are you on?");
            string course = Console.ReadLine();

            //What page number?
            Console.WriteLine("What page number are you on?");
            string page = Console.ReadLine();
            int pageNumb = Convert.ToInt32(page);

            //Do you need help with anything? Please answer “true” or “false”.
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.");
            string help = Console.ReadLine();
            bool needHelp = Convert.ToBoolean(help);

            //Were there any positive experiences you’d like to share? Please give specifics.
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string expereince = Console.ReadLine();

            //Is there any other feedback you’d like to provide? Please be specific.
            Console.WriteLine("Is there any other feeback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            //How many hours did you study today ?
            Console.WriteLine("How many hours did you study today?");
            string hours = Console.ReadLine();
            int hoursTotal = Convert.ToInt32(hours);

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
