using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voyager.BLL
{
    public class Route
    {

        public override string ToString()
        {
            return Name;
        }
        public const int distancePerBreak = 200;
        public const decimal pricePerUnitUnderDropDistance = 5;
        public const decimal pricePerUnitOverDropDistance = 4.25M;
        public const int distanceUnitForPriceIncrement = 25;
        public const int secondsPerKilometer = 45;
        public const int secondsPerMinute = 60;
        public const decimal priceDropDistance = 300;
        public string Name { get; }
        public string DepartureLocation { get; }
        public string ArrivalLocation { get; }
        public int Distance { get; }
        public int Duration
        {
            get
            {
                return (((Distance * secondsPerKilometer + BreakCount * secondsPerMinute * 30) + secondsPerMinute - 1) / secondsPerMinute);
            }
        }
        private int _breakCount;
        public int BreakCount
        {

            get {
                if (Distance < distancePerBreak)
                    _breakCount = 0;
                else
                    _breakCount = Distance / distancePerBreak;
                return _breakCount; }
            set
            {
                
            }
        }
        public decimal BasePrice
        {
            get
            {
                decimal result = 0;
                if (Distance > priceDropDistance)
                {
                    result = (((Distance + distanceUnitForPriceIncrement - 1 - priceDropDistance) / distanceUnitForPriceIncrement) * pricePerUnitOverDropDistance) + secondsPerMinute;
                }
                else
                {
                    result = ((Distance + distanceUnitForPriceIncrement - 1) / distanceUnitForPriceIncrement) * pricePerUnitUnderDropDistance;
                }
                return result;
            }
        }

        public Route(string DepartureLocation, string ArrivalLocation, int Distance)
        {
            this.DepartureLocation = DepartureLocation;
            this.ArrivalLocation = ArrivalLocation;
            this.Distance = Distance;
            if (BreakCount != 0)
            {
                this.Name = DepartureLocation + " - " + ArrivalLocation + " / " + Distance + "'lik " + BreakCount + " Molalı Rota";
            }
            else
            {
                this.Name = DepartureLocation + " - " + ArrivalLocation + " / " + Distance + "'lik Express Rota.";
            }
        }
    }
}
