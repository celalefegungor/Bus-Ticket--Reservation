using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voyager.BLL
{
    public class StandartBus:Bus
    {
        override public int Capacity
        {
            get
            {
                return 30;
            }
        }

        override public bool HasToilet
        {
            get
            {
                return false;
            }
        }

        public override SeatInformation GetSeatInformation(int seatNumber)
        {
            SeatCategory sCategory = new SeatCategory();
            SeatSection sSection = new SeatSection();


            if (seatNumber % 3 == 1)
            {
                sCategory = SeatCategory.Singular;
                sSection = SeatSection.LeftSide;
            }
            else if (seatNumber % 3 == 2)
            {
                sCategory = SeatCategory.Corridor;
                sSection = SeatSection.RightSide;
            }
            else
            {
                sCategory = SeatCategory.Window;
                sSection = SeatSection.RightSide;
            }

            SeatInformation seatInformation = new SeatInformation(seatNumber, sSection, sCategory);
            return seatInformation;
        }
    }
}
