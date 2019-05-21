using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voyager.Entities
{
    [Table("Person")]
    public class PersonPoc
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(11)]
        [Required]
        public string IdentityNumber { get; set; }
        public int Age { get; set; }
        [MaxLength(64)]
        [Required]
        public string FirstName { get; set; }
        [MaxLength(64)]
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        [EnumDataType(typeof(Gender))]
        public Gender Gender { get; set; }
        public DriverPoc Driver;
        public HostPoc Host;
    }
}