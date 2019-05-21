using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voyager.Entities
{
    [Table("Host")]
    public class HostPoc
    {
        public HostPoc()
        {
            this.Expeditions = new HashSet<ExpeditionPoc>();
        }
        [Key]
        public int Id { get; set; }

        public  ICollection<ExpeditionPoc> Expeditions { get; set; }

        
        [ForeignKey("Person")]
        [Required]
        public int PersonId { get; set; }
        public PersonPoc Person { get; set; }
    }
}
