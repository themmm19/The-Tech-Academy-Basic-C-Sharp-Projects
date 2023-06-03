using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee() { Id = 1};
            Employee employee2 = new Employee() { Id = 2};
            Employee employee3 = new Employee() { Id = 1};

            Console.WriteLine(employee1 == employee2);
            Console.WriteLine(employee1 == employee3);
            Console.ReadLine();
        }
    }
}
