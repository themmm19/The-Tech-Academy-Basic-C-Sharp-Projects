using System;


namespace ConsoleApplication
{
    internal class Program
    {
        static void Main()
        {
            // Takes an input from the user, multiplies it by 50
            Console.WriteLine("Please input a number to be multiplied by 50:");
            string input1 = Console.ReadLine();
            int num1 = Convert.ToInt32(input1) * 50;
            Console.WriteLine(input1 + " times 50 equals " + num1);

            // Takes an input from the user, adds 25 to it
            Console.WriteLine("\nPlease input a number to be added to 25:");
            string input2 = Console.ReadLine();
            int num2 = Convert.ToInt32(input2) + 25;
            Console.WriteLine(input2 + " plus 25 equals " + num2);


            // Takes an input from the user, divides it by 12.5
            Console.WriteLine("\nPlease input a number to be divided by 12.5:");
            string input3 = Console.ReadLine();
            double num3 = Convert.ToDouble(input3) / 12.5;
            Console.WriteLine(input3 + " divided by 12.5 equals " + num3);

            // Takes an input from the user, checks if it is greater than 50
            Console.WriteLine("\nPlease input a number to be compared to 50:");
            string input4 = Console.ReadLine();
            bool num4 = Convert.ToInt32(input4) > 50;
            Console.WriteLine("Is " + input4 + " greater than 50? " + num4);

            // Takes an input from the user, divides it by 7
            Console.WriteLine("\nPlease input a number to find the remainder of dividing it by 7:");
            string input5 = Console.ReadLine();
            int num5 = Convert.ToInt32(input5) % 7;
            Console.WriteLine("The remainder of " + input5 + " divided by 7 is " + num5);
            Console.ReadLine();
        }
    }
}
