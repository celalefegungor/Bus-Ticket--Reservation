using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voyager.BLL
{
    public class SeatInformation
    {
        public int Number { get; }
        public SeatSection Section { get; }
        public SeatCategory Category { get; }

        public SeatInformation(int Number, SeatSection seatSection, SeatCategory seatCategory)
        {
            this.Number = Number;
            this.Section = seatSection;
            this.Category = seatCategory;
        }
    }
}
