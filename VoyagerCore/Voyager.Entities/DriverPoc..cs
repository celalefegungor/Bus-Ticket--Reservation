using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voyager.Entities
{
    [Table("Driver")]
    public class DriverPoc
    {
        public DriverPoc()
        {
            this.Expeditions = new HashSet<ExpeditionPoc>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public LicenseType LicenseType { get; set; }


        public ICollection<ExpeditionPoc> Expeditions { get; set; }

       
        [ForeignKey("Person")]
        [Required]
        public int PersonId { get; set; }
        public PersonPoc Person { get; set; }
    }
}
