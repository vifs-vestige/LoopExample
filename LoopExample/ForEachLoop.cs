using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopExample
{
    class ForEachLoop
    {

        public ForEachLoop()
        {
            Console.WriteLine("For Each");
            

            List<string> names = new List<String>();
            names.Add("bob");
            names.Add("hank");
            names.Add("jim");

            //basic way to loop over a collection
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");
        }

        public static void ForEachWhere()
        {
            Console.WriteLine("For Each where");
            Console.WriteLine("");

            List<int> numbers = new List<int>();
            for (int i = 0; i < 101; i++)
            {
                numbers.Add(i);
            }

            //in most languages, you can loop over a collection where you limit what is used in the loop
            foreach (var item in numbers.Where(x => x%5 == 0))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("");
        }
    }
}
