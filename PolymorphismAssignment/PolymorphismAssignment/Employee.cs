using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace PolymorphismAssignment
{
    // class inheriting from Person and interface IQuittable
    public class Employee : Person, IQuittable
    {
        public Employee(string fname, string lname) : base(fname, lname) { }
        public int Id { get; set; }
        //implmentation of the abstract method
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }

        //  implementation of the methode inherited from an interface
        public void Quit()
        {
            Console.WriteLine("I quite!");
        }
    }
}
