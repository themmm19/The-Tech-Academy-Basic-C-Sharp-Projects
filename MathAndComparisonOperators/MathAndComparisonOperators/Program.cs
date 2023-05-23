using System;


namespace MathAndComparisonOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            // Person 1 credentials
            Console.WriteLine("\n\tPerson 1:");
            Console.WriteLine("Hourly Rate?");
            string hourlyRate1 = Console.ReadLine();


            Console.WriteLine("Hours worked per week?");
            string hours1 = Console.ReadLine();
            int salary1 = Convert.ToInt32(hours1)*Convert.ToInt32(hourlyRate1)*52;


            Console.WriteLine("\n\tPerson 2:");
            Console.WriteLine("Hourly Rate?");
            string hourlyRate2 = Console.ReadLine();


            Console.WriteLine("Hours worked per week?");
            string hours2 = Console.ReadLine();
            int salary2 = Convert.ToInt32(hours2) * Convert.ToInt32(hourlyRate2)*52;

            // Displays annual salary
            Console.WriteLine("Person 1 has an annual salary of " + salary1);
            Console.WriteLine("Person 2 has an annual salary of " + salary2);
            
            // Comparing salaries
            Console.WriteLine("\nDoes Person 1 make more money than Person 2?");
            bool isItMore = salary1 > salary2;
            Console.WriteLine(isItMore);
            Console.ReadLine();

        }
    }
}
