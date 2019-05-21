using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voyager.BLL
{
    public class Ticket
    {
        public Expedition Expedition { get; }
        public SeatInformation SeatInformation { get; }
        public Person Passenger { get; }
        public decimal PaidAmount { get; }

        internal Ticket(Expedition expedition, SeatInformation seatInformation, Person passenger, decimal paidAmount)
        {
            this.Expedition = expedition;
            this.SeatInformation = seatInformation;
            this.Passenger = passenger;
            this.PaidAmount = paidAmount;
        }
    }
}
