using System;
using System.Linq;

namespace Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split(", ")
                .Select(x => double.Parse(x) * 1.2)
                .ToList();

            foreach (var num in nums)
            {
                Console.WriteLine($"{num:f2}");
            }
        }
    }
}
