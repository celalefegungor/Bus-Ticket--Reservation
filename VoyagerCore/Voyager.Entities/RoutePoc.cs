using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voyager.Entities
{
    [Table("Route")]
    public class RoutePoc
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DepartureLocation { get; set; }
        public string ArrivalLocation { get; set; }
        public int Distance { get; set; }
        public int Duration { get; set; }
        public int BreakCount { get; set; }
        public decimal BasePrice { get; set; }
    }
}
