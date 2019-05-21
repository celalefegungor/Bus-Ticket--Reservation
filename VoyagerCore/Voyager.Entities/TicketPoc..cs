using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voyager.Entities
{
    [Table("Ticket")]
    public class TicketPoc
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int SeatNumber { get; set; }

        [Required]
        public decimal PaidAmount { get; set; }


       
        [ForeignKey("Person")]
        [Required]
        public int PersonId { get; set; }
        public PersonPoc Person { get; set; }


       
        [ForeignKey("Expedition")]
        [Required]
        public int ExpeditionId { get; set; }
        public ExpeditionPoc Expedition { get; set; }
    }
}
