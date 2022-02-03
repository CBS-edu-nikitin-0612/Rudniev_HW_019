using System;

namespace aditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите дату вашего рождения в формате (24/03): ");
            DateTime birthday = DateTime.Parse(Console.ReadLine());
            DateTime today = DateTime.Now;
            
            TimeSpan left;
            if (birthday >= today)
            {
                left = birthday - today;
                Console.WriteLine($"До дня рождения осталось {left.Days} дней");
            }
            else
            {
                left = today - birthday;
                Console.WriteLine($"До дня рождения осталось {365 - left.Days} дней");
            }
            
        }
    }
}
