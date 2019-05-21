using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voyager.BLL
{
    public class Driver:Person
    {
        public LicenseType licenseType { get; set; }
        public Driver(string FirstName, string LastName, LicenseType licenseType, DateTime dateOfBirth) : base(FirstName, LastName)
        {
            this.licenseType = licenseType;

            if ((DateTime.Now - dateOfBirth).Days / 365 <= 25)
            {
                throw new Exception("Şöför 25 yaşından küçük olamaz");
            }
            else
                this.DateOfBirth = dateOfBirth;
        }
    }
}
