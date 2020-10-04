using System;
using System.IO;
using System.Linq;

namespace Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split();
            Action<string> appendedNames = AppendSomeText(names);
            
        }
        static Action<string> AppendSomeText(string[] names)
        {
            foreach (var name in names)
            {
                Console.WriteLine("Sir " + name); ;
            }
            return null;
        }
    }
}
