using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voyager.BLL
{
    public class Host:Person
    {
        public Host(string FirstName, string LastName, DateTime dateOfBirth) : base(FirstName, LastName)
        {
            if ((DateTime.Now - dateOfBirth).Days / 365 <= 18)
            {
                throw new Exception("Muavin 18 yaşından küçük olamaz");
            }
            else
                this.DateOfBirth = dateOfBirth;
        }
    }
}
