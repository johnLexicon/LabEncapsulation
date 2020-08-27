using System.Collections.Generic;

namespace LabEncapsulation
{
    internal class Team
    {
        private string _name;
        private readonly List<Person> _firstTeam = new List<Person>();
        private readonly List<Person> _reserveTeam = new List<Person>();

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public List<Person> FirstTeam
        {
            get { return new List<Person>(_firstTeam); } // Returns a shallow copy 
        }

        public List<Person> ReserveTeam
        {
            get { return new List<Person>(_reserveTeam); } // Returns a shallow copy 
        }

        public Team(string teamName)
        {
            Name = teamName;
        }

        internal void AddPlayer(Person person)
        {
            if (person.Age < 40)
            {
                _firstTeam.Add(person);
            }
            else
            {
                _reserveTeam.Add(person);
            }
        }
    }
}