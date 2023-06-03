using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    public class Employee
    {
        //employee properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //overriding == and !=
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            return emp1.Id == emp2.Id;
        }
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1.Id == emp2.Id);
        }
    }
}
