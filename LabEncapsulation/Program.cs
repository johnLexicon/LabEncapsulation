using System;
using System.Collections.Generic;
using System.Linq;

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
                var person = new Person(cmdArgs[0],

                            cmdArgs[1],

                            int.Parse(cmdArgs[2]),

                            decimal.Parse(cmdArgs[3]));


                persons.Add(person);

            }

            System.Console.Write("Add bonus: ");
            var bonus = decimal.Parse(Console.ReadLine());

            persons.ForEach(p => p.IncreaseSalary(bonus));

            persons.ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}
