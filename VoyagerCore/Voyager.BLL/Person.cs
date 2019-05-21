using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voyager.BLL
{
    public enum Gender { None = 0, Female=1, Male=2 };
    public enum LicenseType { None = 0, NormalLicense, HighLicense };

    public class Person
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string FullName { get { return FirstName + " " + LastName; } }
        public string IdentityNumber { get; set; }
        public Gender gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get { return (DateTime.Now - DateOfBirth).Days / 365; } }

        public Person(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
    }
}
