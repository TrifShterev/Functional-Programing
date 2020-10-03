using System;
using System.Collections.Generic;
using System.IO;

namespace Filter_By_Age
{public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int totalPeople = int.Parse(Console.ReadLine());
            List<Person> persons = new List<Person>();

            for (int i = 0; i < totalPeople; i++)
            {
                var data = Console.ReadLine().Split(", ");
                var person = new Person { Name = data[0], Age = int.Parse(data[1]) };
                persons.Add(person);

            }
            var condition =Console.ReadLine();
            var ageFilter = int.Parse(Console.ReadLine());
            var format = Console.ReadLine();

            Func<Person, bool> conditionDelegate = GetCondition(condition, ageFilter);
            Action<Person> printerDelegate = GetPrinter(format);

            foreach (var person in persons)
            {
                if (conditionDelegate(person))
                {
                    printerDelegate(person);
                }
            }
            



        }static Action<Person> GetPrinter(string format)
        {
            switch (format)
            {
                case "name":
                    return p => { Console.WriteLine($"{p.Name}"); };
                case "age":
                    return p => { Console.WriteLine($"{p.Age}"); };
                case "name age":
                    return p => { Console.WriteLine($"{p.Name} - {p.Age}"); };
                default:
                    return null;
            }
        }
        static Func<Person, bool> GetCondition(string condition,int age) 
        {
            switch (condition)
            {
                case "older": return c => c.Age >= age;
                case "younger": return x => x.Age < age;
                default:
                    return null;
            }
   
           
            

        }
    }
}
