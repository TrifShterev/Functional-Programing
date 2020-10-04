using System;
using System.Collections.Generic;
using System.Linq;

namespace Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            Func<int, int> Add = n => ++n;
            Func<int, int> Multiply = n => n * 2;
            Func<int, int> Subtract = n => --n;

            string input;
            while ((input=Console.ReadLine())!="end")
            {
                
                switch (input)
                {
                    case "add":
                     numbers= numbers.Select(Add).ToList();
                        break;
                    case "multiply":
                     numbers= numbers.Select(Multiply).ToList();
                        break;
                    case "subtract":
                      numbers=  numbers.Select(Subtract).ToList();
                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ",numbers));
                        break;
                }
            }
        }
      

      
        
    }
}
