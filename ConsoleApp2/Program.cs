using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double meal_cost = 100;
            int tip_percent = 15;
            int tax_percent = 8;
            Console.WriteLine("用餐費用：" + (meal_cost + tip_percent + tax_percent));
        }
    }
}
