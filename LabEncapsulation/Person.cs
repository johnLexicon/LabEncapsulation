using System;

namespace LabEncapsulation
{
    internal class Person
    {
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public Person(string firstName, string lastName, int age, decimal salary) : this(firstName, lastName, age)
        {

            Salary = salary;
        }

        public string FirstName { get; }
        public string LastName { get; }
        public int Age { get; }
        public decimal Salary { get; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} is {Age} years old.";
        }

        internal void IncreaseSalary(decimal bonus)
        {
            throw new NotImplementedException();
        }
    }
}