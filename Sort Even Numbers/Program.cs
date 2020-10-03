using System;
using System.IO;
using System.Linq;

namespace Sort_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
          var numbers=  Console.ReadLine()
                     .Split(", ")
                     .Select(int.Parse)
                     .Where(x => x % 2 == 0)
                     .OrderBy(x => x)
                     .ToList();
            Console.WriteLine(string.Join(", ", numbers));

        }
    }
}
