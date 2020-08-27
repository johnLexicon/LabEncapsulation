using System;

namespace LabEncapsulation
{
    internal class Person
    {
        private string _firstName;
        private string _lastName;
        private int _age;
        private decimal _salary;

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

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (value.Length < 3)
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
                _firstName = value;
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (value.Length < 3)
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
                _lastName = value;
            }
        }
        public int Age
        {
            get { return _age; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                _age = value;
            }
        }
        public decimal Salary
        {
            get { return _salary; }
            set
            {
                if (value < 460)
                    throw new ArgumentException("Salary cannot be less than 460 dollars!");
                _salary = value;
            }
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} receives {Salary} dollars.";
        }

        internal void IncreaseSalary(decimal bonus)
        {
            if (Age < 30)
            {
                bonus = bonus / 2;
            }
            Salary = (bonus / 100 + 1) * Salary;
        }
    }
}