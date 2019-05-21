using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voyager.BLL
{
    public abstract class Bus
    {
        public string Make { get; set; }
        public string Plate { get; set; }
        public abstract int Capacity { get; }
        public virtual bool HasToilet{ get; set; }
        public abstract SeatInformation GetSeatInformation(int seatNumber);

        public override string ToString()
        {
            return Plate;
        }
    }
}