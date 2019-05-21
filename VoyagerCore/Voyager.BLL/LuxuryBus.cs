using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voyager.BLL
{
    public class LuxuryBus:Bus
    {
        override public int Capacity
        {
            get { return 20; }
        }

        override public bool HasToilet
        {
            get
            {
                return true;
            }
        }

        public override SeatInformation GetSeatInformation(int seatNumber)
        {
            SeatCategory sCategory = new SeatCategory();
            SeatSection sSection = new SeatSection();

            if (seatNumber % 2 == 1)
            {
                sCategory = SeatCategory.Singular;
                sSection = SeatSection.LeftSide;
            }
            else
            {
                sCategory = SeatCategory.Singular;
                sSection = SeatSection.LeftSide;
            }

            SeatInformation seatInformation = new SeatInformation(seatNumber, sSection, sCategory);
            return seatInformation;

        }
    }
}
