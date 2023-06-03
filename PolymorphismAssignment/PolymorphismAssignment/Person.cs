using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace PolymorphismAssignment
{
    // abstract class Person
    public abstract class Person
    {
        public Person(string fname, string lname) { firstName = fname; lastName = lname; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        // abstract method
        public abstract void SayName();
    }
}
