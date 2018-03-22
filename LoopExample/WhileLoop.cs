using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopExample
{
    class WhileLoop
    {

        public WhileLoop()
        {
            Console.WriteLine("While Loop");
            Console.WriteLine("");

            int number = 0;
            var random = new Random();
            //while loops are ran until the condition is met
            while(number != 5)
            {
                var temp = random.Next(0, 9);
                Console.Write(temp);
                number = temp;

            }

            Console.WriteLine("");

        }

        public static void DoWhileLoop()
        {
            Console.WriteLine("Do While Loop");
            Console.WriteLine("");

            bool finish = false;
            //do while loops will always be ran once
            do
            {
                Console.WriteLine("Continue Y/N?");
                string input = Console.ReadLine();
                if (input == "Y")
                    finish = true;

            } while (finish == false);

            Console.WriteLine("Continuing");
            Console.WriteLine("");
                
        }
    }
}
