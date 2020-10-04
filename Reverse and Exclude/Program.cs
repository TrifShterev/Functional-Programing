using System;
using System.IO;
using System.Linq;

namespace Reverse_and_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            int numToDivideOn =int.Parse(Console.ReadLine());

            Func<double, bool> filtredNumbers = n => n % numToDivideOn != 0;

          var reversedNumbers = numbers.Reverse().Where(filtredNumbers);

            Console.WriteLine(string.Join(" ",reversedNumbers));

        }
        
    }
}
