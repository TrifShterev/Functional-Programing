using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] givenNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string command = Console.ReadLine();

            List<int> numbers = new List<int>();
            for (int i = givenNumbers[0]; i <= givenNumbers[1]; i++)
            {
                numbers.Add(i);
            }
            switch (command)
            {
                case "even":
                   numbers= numbers.FindAll(isEven);                   
                    break;
                case"odd":
                  numbers= numbers.FindAll(isOdd);                    
                    break;
            }
            Console.WriteLine(string.Join(" ",numbers));

        }
        private static Predicate<int> isEven = i=>i % 2 == 0;
        private static Predicate<int> isOdd = i => i % 2 != 0;

    }
}
