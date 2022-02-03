using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine();
            Console.WriteLine("Введите номер цвета: ");
            byte color = Convert.ToByte(Console.ReadLine());
            Printer.Print(str, color);
            
        }
    }
}
