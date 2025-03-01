using System;

namespace task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello,Estimate for carpet cleaning service");
            Console.Write("Number of small carpets:");
            double smallCarprts = Convert.ToDouble(Console.ReadLine());
            Console.Write("Number of large carpets:");
            double Largecarpets = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Price per small room: $25");
            Console.WriteLine("Price per large room: $35");
            double cost;
            cost = smallCarprts * 25 + Largecarpets * 35;
            Console.WriteLine($"Cost : {cost}" + "$");
            double tax;
            tax = cost * 0.06;
            Console.WriteLine($"Tax: {tax}" + "$");
            double totalestimate;
            totalestimate = cost + tax;
            Console.WriteLine("===============================");
            Console.WriteLine($"Total estimate:{totalestimate}" + "$");
            Console.WriteLine("This estimate is valid for 30 days");


        }
    }
}
