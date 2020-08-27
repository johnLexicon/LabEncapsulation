using System;
using System.Collections.Generic;

namespace LabEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = 2;

            var persons = new List<Person>();

            for (int i = 0; i < lines; i++)

            {
                Console.WriteLine("Add person info (firstName lastName Age Salary)");
                var cmdArgs = Console.ReadLine().Split();
                try
                {
                    var person = new Person(cmdArgs[0],
                    cmdArgs[1],
                    int.Parse(cmdArgs[2]),
                    decimal.Parse(cmdArgs[3]));

                    persons.Add(person);
                }
                catch (ArgumentException e)
                {
                    System.Console.WriteLine(e.Message);
                }

            }

            if (persons.Count == 0)
            {
                return;
            }

            var team = new Team("Lexicon");
            foreach (var person in persons)
            {
                team.AddPlayer(person);
            }
        }
    }
}
