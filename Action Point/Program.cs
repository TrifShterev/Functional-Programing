using System;
using System.IO;

namespace Action_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split();
            Action<string> getName = PrintName(names);
        }
        static Action<string> PrintName(string[] names)
        {
            foreach (var name in names)
            {
                Console.WriteLine(name);

            }
            return null;
        }
    }
}
