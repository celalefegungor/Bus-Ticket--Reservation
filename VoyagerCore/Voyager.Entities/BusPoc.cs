using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voyager.Entities
{
    [Table("Bus")]
    public class BusPoc
    {
        [Key]
        public int Id { get; set; }
             
        [MaxLength(64)]
        [Required]
        public string Make { get; set; }
        [MaxLength(16)]
        [Required]
        public string Plate { get; set; }

        [ForeignKey("BusType")]
        [Required]
        public int BusTypeId { get; set; }
        
        public BusTypePoc BusType { get; set; }

    }
}