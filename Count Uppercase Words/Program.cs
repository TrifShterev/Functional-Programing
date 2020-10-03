using System;
using System.IO;
using System.Linq;

namespace Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ReadLine()
                .Split()
                .Where(word => char.IsUpper(word[0]))
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
