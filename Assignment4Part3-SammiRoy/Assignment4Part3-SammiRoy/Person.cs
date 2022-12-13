using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4Part3_SammiRoy
{
    internal class Person
    {
        // Fields
        private string _name;
        private DateTime _birthDate;

        // Propertires
        public string Name 
        { 
            get
            {
                return _name;
            }

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Name is blank or null!");
                }
                else if (value.Length < 5)
                {
                    throw new ArgumentException("Name must contain 5 or more characters!");
                }
                _name = value; 
            }
        }
        public DateTime BirthDate 
        { 
            get
            {
                return _birthDate;
            }
            set
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentException("Birthdate cannot break the laws of physics!");
                }
                _birthDate = value;
            }
        }
        public int CurrentAge { get; }

        // Constructors
        public Person ()
        {

        }
        public Person (string name, DateTime birthDate)
        {
            Name = name;
            BirthDate = birthDate;
            // Current age is (currentTime - birthDate)
            DateTime currentDate = DateTime.Now;
            TimeSpan age = currentDate.Subtract(birthDate);
            int roundedAge = int.Parse(Math.Round(age.TotalDays, 0).ToString()); // Round age.TotalDays to 0 decimal places, convert it to a string and then parse as an int
            CurrentAge = roundedAge;
        }

        // Methods
        public int AgeOn(DateTime onDate)
        {
            DateTime birthDate = BirthDate;
            TimeSpan age = onDate.Subtract(birthDate);
            int roundedAge = int.Parse(Math.Round(age.TotalDays, 0).ToString()); // Round age.TotalDays to 0 decimal places, convert it to a string and then parse as an int
            return roundedAge;
        }

        public string ChineseZodiac()
        {
            switch(BirthDate.Year % 12)
            {
                case 0:
                    return "Monkey";
                case 1:
                    return "Rooster";
                case 2:
                    return "Dog";
                case 3:
                    return "Pig";
                case 4:
                    return "Rat";
                case 5:
                    return "Ox";
                case 6:
                    return "Tiger";
                case 7:
                    return "Rabbit";
                case 8:
                    return "Dragon";
                case 9:
                    return "Snake";
                case 10:
                    return "Horse";
                case 11:
                    return "Sheep";
                default:
                    return "What";
            }
        }

        public string AstrolgoicalSign()
        {

            if (((BirthDate.Month == 3) && (BirthDate.Day >= 21)) || ((BirthDate.Month == 4) && (BirthDate.Day <= 19)))
            {
                return "Aries";
            } else if (((BirthDate.Month == 4) && (BirthDate.Day >= 20)) || ((BirthDate.Month == 5) && (BirthDate.Day <= 20)))
            {
                return "Taurus";
            } else if (((BirthDate.Month == 5) && (BirthDate.Day >= 21)) || ((BirthDate.Month == 6) && (BirthDate.Day <= 21)))
            {
                return "Gemini";
            } else if (((BirthDate.Month == 6) && (BirthDate.Day >= 22)) || ((BirthDate.Month == 7) && (BirthDate.Day <= 22)))
            {
                return "Cancer";
            } else if (((BirthDate.Month == 7) && (BirthDate.Day >= 23)) || ((BirthDate.Month == 8) && (BirthDate.Day <= 22)))
            {
                return "Leo";
            } else if (((BirthDate.Month == 8) && (BirthDate.Day >= 23)) || ((BirthDate.Month == 9) && (BirthDate.Day <= 22)))
            {
                return "Virgo";
            } else if (((BirthDate.Month == 9) && (BirthDate.Day >= 23)) || ((BirthDate.Month == 10) && (BirthDate.Day <= 22)))
            {
                return "Libra";
            } else if (((BirthDate.Month == 10) && (BirthDate.Day >= 23)) || ((BirthDate.Month == 11) && (BirthDate.Day <= 22)))
            {
                return "Scorpio";
            } else if (((BirthDate.Month == 11) && (BirthDate.Day >= 23)) || ((BirthDate.Month == 12) && (BirthDate.Day <= 21)))
            {
                return "Sagittarius";
            } else if (((BirthDate.Month == 12) && (BirthDate.Day >= 22)) || ((BirthDate.Month == 1) && (BirthDate.Day <= 19)))
            {
                return "Capricorn";
            } else if (((BirthDate.Month == 1) && (BirthDate.Day >= 20)) || ((BirthDate.Month == 2) && (BirthDate.Day <= 18)))
            {
                return "Aquarius";
            } else if (((BirthDate.Month == 2) && (BirthDate.Day >= 19)) || ((BirthDate.Month == 3) && (BirthDate.Day <= 20)))
            {
                return "Pisces";
            } else
            {
                return "I am going to cry";
            }
        }
    }
}
