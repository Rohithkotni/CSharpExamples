using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Trail_Examples
{
    public class Loops
    {
        public static void ForLoop()
        {
            for (int i = -3; i < 4; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void WhileLoop()
        {
            int i = 3;
            while (i > -4)
            {
                Console.WriteLine(i--);
            }
        }
    }
}
