using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class FootballPlayer
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public int ShirtNumber { get; set; }

        public void ValidateAll()
        {
            IdValidator();
            NameValidator();
            AgeValidator();
            ShirtNumberValidator();
        }

        public bool IdValidator()
        {
            if (Id == 0)
                throw new ArgumentNullException("Id must have a value");

            return true;
        }

        public bool NameValidator()
        {
            if (Name == null)
                throw new ArgumentNullException("Name must be defined");
            if (Name.Length < 3)
                throw new ArgumentOutOfRangeException("Name must be at least two characters long");

            return true;
        }

        public bool AgeValidator()
        {
            if (Age < 2)
                throw new ArgumentOutOfRangeException("Age must be bigger than one");

            return true;
        }

        public bool ShirtNumberValidator()
        {
            if (ShirtNumber < 1 || ShirtNumber > 99)
                throw new ArgumentOutOfRangeException("Shirt number must be bigger than 0 and less than 100");

            return true;
        }
    }
}
