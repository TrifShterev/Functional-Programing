using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Party_Reservation_Filter_Module
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine()
                .Split()
                .ToList();
           List<string> filters = new List<string>();

            string inputCommand;
            while ((inputCommand = Console.ReadLine())!="Print")
            {
                string[] tokens = inputCommand.Split(";");
                string commandName = tokens[0];
                string filterType = tokens[1];
                string argument = tokens[2];

                if (commandName=="Add filter")
                {
                    filters.Add($"{filterType};{argument}");
                }
                else if (commandName=="Remove filter")
                {
                    filters.Remove($"{filterType};{argument}");
                }
            }
            foreach (var filter in filters)
            {
                string[] tokens = filter.Split(";");
                string filterType = tokens[0];
                string argument = tokens[1];

                switch (filterType)
                {
                    case "Starts with":
                        people = people.Where(p => !p.StartsWith(argument)).ToList();
                        break;
                    case "Ends with":
                        people = people.Where(p => !p.EndsWith(argument)).ToList();
                        break;
                    case "Length" :
                        people = people.Where(p => p.Length != int.Parse(argument)).ToList();
                        break;
                    case "Contains":
                        people = people.Where(p => !p.Contains(argument)).ToList();
                        break;
                }
            }
            Console.WriteLine(string.Join(" ",people));
        }
    }
}
