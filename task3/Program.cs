using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            if(Accountant.AskForBonus(Positions.junior, 190))
                Console.WriteLine("положена премия!"); 
            else
                Console.WriteLine("нет премии!");
            if (Accountant.AskForBonus(Positions.midle, 220))
                Console.WriteLine("положена премия!");
            else
                Console.WriteLine("нет премии!");
        }
    }
}
