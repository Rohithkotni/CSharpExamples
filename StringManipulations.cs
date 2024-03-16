using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    public class StringManipulations
    {
        public static void Manipulations()
        {
            var name = "Rohith";
            //String Concatenation
            Console.WriteLine("My Name is " + name);
            //String Format
            Console.WriteLine("My Name is {0}", name);
            //String Interpolation
            Console.WriteLine($"My Name is {name}");
            //Verbatim Strings, prints as it is as inside Quotes ignore white spaces and new lines
            Console.WriteLine(@"My Name is {name}-> Rohith \n ");
        }
    }
}
