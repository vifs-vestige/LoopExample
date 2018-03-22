using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopExample
{
    class ForLoop
    {

        public ForLoop()
        {
            Console.WriteLine("For Loop");
            Console.WriteLine("");
            //you can start at any value, this case 0
            //you can end at any value, this case 10
            //you can incrment by any value, this case add 1 every loop
            //i++ adds one to i after each loop, so this will run from 0-9
            //if you did ++i it would run 1-10
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i);
            }
            Console.WriteLine("");
        }

        public static void DifferentForLoop()
        {
            Console.WriteLine("Different For Loop");
            Console.WriteLine("");



            for (int i = 0; i < 100; i+=5)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("");
        }
    }
}
