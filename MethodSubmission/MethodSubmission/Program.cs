using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instantiate the class.
            SimpleMethod simpleMethod = new SimpleMethod();

            //Call the method in the class, passing in two numbers. 
            simpleMethod.SimpleMath(5, 60);
            

            //Call the method in the class, specifying the parameters by name.
            simpleMethod.SimpleMath(numb1: 10, numb2: 20);
            Console.Read();



        }
    }
}
