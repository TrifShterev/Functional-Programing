using System;
using System.IO;

namespace Predicate_for_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split();
            Func<int, string> GetName = GetCorectName(n, names);

        }
        static Func<int,string> GetCorectName (int num,string[] names)
        {
            foreach (var name in names)
            {
                if (num>= name.Length)
                {
                    Console.WriteLine(name); ;
                }
                
            }
            return null;  
           
        }
       
    }
}
