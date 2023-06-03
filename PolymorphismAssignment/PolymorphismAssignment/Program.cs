using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //an instance of the calss employee using a constructor
            Employee employee = new Employee("Jack", "Ross");
            
            //calling employee methodes
            employee.SayName();

            //calling methode from the interface
            employee.Quit();
            Console.ReadLine(); 

        }
    }
}
