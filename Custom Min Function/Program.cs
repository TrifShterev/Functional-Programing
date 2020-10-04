using System;
using System.IO;
using System.Linq;

namespace Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(double.Parse).ToArray();

            Func<double[], double> minNum = returnSmallestInteger;
            var min = minNum(nums);

            Console.WriteLine(min);
            
        }
        static double returnSmallestInteger(double[] nums)
        {
            double minNumber = nums.Max();
            foreach (var num in nums)
            {
                if (num<minNumber)
                {
                    minNumber = num;
                }
            }
            return minNumber;


        }
        
    }
}
