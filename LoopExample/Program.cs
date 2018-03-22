using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopExample
{
    class Program
    {
        static void Main(string[] args)
        {
            new ForLoop();
            Console.ReadLine();
            ForLoop.DifferentForLoop();
            Console.ReadLine();
            new ForEachLoop();
            Console.ReadLine();
            ForEachLoop.ForEachWhere();
            Console.ReadLine();
            new WhileLoop();
            Console.ReadLine();
            WhileLoop.DoWhileLoop();
            Console.ReadLine();
        }
    }
}
