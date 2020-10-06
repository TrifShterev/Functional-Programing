using System;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Custom_Comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Array.Sort(numbers, (x, y) =>
            {                          //Same as IF:
                return (x % 2 == 0 && y % 2 != 0) ? -1 :

                         //Same as ELSE IF:
                         (x % 2 != 0 && y % 2 == 0) ? 1
                         
                         //Same as ELSE:
                         : x.CompareTo(y);

                
            });
            //Array.Sort(numbers, (x, y) =>
            //{
            //Its the Longer variation of the syntaxys above:
            //if (x%2==0&&y%2!=0)
            //{
            //    sorter = -1;
            //}
            //else if (x % 2!=0&& y %2==0)
            //{
            //    sorter = 1;
            //}
            //else
            //{
            //    return x - y;
            //}
            //return sorter;
            //}


            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
