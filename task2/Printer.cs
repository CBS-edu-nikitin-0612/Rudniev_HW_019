using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    static class Printer
    {
        public static void Print(string str, byte color)
        {

            Console.ForegroundColor = (ConsoleColor)(Colors)color;
            Console.WriteLine(str);
        }
    }
}
