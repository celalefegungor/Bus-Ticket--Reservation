using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voyager.Entities
{
    [Table("BusType")]
    public class BusTypePoc
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(64)]
        [Required]
        public string Name { get; set; }
        [Required]
        public int SeatCount { get; set; }
        [Required]
        public bool HasToilet { get; set; }

    }
}
