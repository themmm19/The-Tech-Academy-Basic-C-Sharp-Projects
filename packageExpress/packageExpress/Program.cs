using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace packageExpress
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below");

            // getting the weight
            Console.WriteLine("Please enter the package weight");
            string packageWeight = Console.ReadLine();
            int pkgWeight = Convert.ToInt32(packageWeight);
            // checking if weight is within limit
            if (pkgWeight > 50)
            {
                Console.WriteLine("Your Package is too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {

                // getting the width
                Console.WriteLine("Please enter the package width");
                string packageWidth = Console.ReadLine();
                int pkgwidth = Convert.ToInt32(packageWidth);

                // getting the height
                Console.WriteLine("Please enter the package height");
                string packageHeight = Console.ReadLine();
                int pkgheight = Convert.ToInt32(packageHeight);

                // getting the length
                Console.WriteLine("Please enter the package length");
                string packageLength = Console.ReadLine();
                int pkglength = Convert.ToInt32(packageLength);
                

                int totalDmension = (pkgwidth + pkgheight + pkglength);



                // chekcing if the deimesntions are within limit
                if (totalDmension > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
               
                }
                // providing the quote if everyhting is good
                else
                {
                    decimal quote = pkgheight * pkglength * pkgwidth * pkgWeight / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: $" + quote + "\nThank you!");
                }

            
                
            

                
            
            }

            Console.ReadLine();
        }
    }
}
