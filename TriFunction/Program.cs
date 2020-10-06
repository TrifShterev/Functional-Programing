using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> people = Console.ReadLine()
                .Split()
                .ToList();
            Func<string, int> getAsciiSum = p => p.Select(c => (int)c).Sum();

         //   string person = GetName(people, n, getAsciiSum);

         //Solved by Functional way:
            Func<List<string>, int, Func<string, int>, string> nameFunc = (people, n, func) =>
               people.FirstOrDefault(p => func(p) >= n);
            string result = nameFunc(people, n, getAsciiSum);
            Console.WriteLine(result);
        }
        //Normaly solved:
        //static string GetName(List<string> people,int n,Func<string,int> func)
        //{
        //    string result = null;
        //    foreach (var person in people)
        //    {             

        //        if (func(person)>=n)
        //        {
        //            result= person;
        //        }
        //    }
        //    return result;
        //}
    }
}
