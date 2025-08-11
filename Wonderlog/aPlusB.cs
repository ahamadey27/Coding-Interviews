using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wonderlog
{
    public class aPlusB
    {
        /*
        Problem
        Tudor is sitting in math class, on his laptop. Clearly, he is not paying attention in this situation. However, he gets called on by his math teacher to do some problems. Since his math teacher did not expect much from Tudor, he only needs to do some simple addition problems. However, simple for you and I may not be simple for Tudor, so please help him!

        Input Specification
        The first line will contain an integer 
        (
        ), the number of addition problems Tudor needs to do. The next 
        lines will each contain two space-separated integers whose absolute value is less than 
        , the two integers Tudor needs to add.

        Output Specification
        Output 
        lines of one integer each, the solutions to the addition problems in order.

        Input
        1 1 
        -1 0

        Output
        2
        -1
        */

        public static void APLusBFunction(params string[] userInput)
        {

            foreach (string line in userInput)
            {
                string[] parts = line.Split(' ');
                int a = int.Parse(parts[0]);
                int b = int.Parse(parts[1]);

                Console.WriteLine(a + b);
            }

        }
    }
}