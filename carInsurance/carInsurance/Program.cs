using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace carInsurance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Isurance application");
            Console.WriteLine("Waht is your age0?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you eevry had a DUI? (yes or no)");
            string answer = Console.ReadLine().ToLower();

            bool dui = answer == "yes";

            Console.WriteLine("How many tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Qualified for insurance?");
            bool qualified = (age > 18) && !dui && (tickets < 5);
            Console.WriteLine(qualified);
            Console.Read();
        }
    }
}
