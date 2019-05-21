using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voyager.BLL
{
    public class Expedition
    {
        private Bus _bus;
        private string _code;
        public List<Driver> drivers = new List<Driver>();
        public List<Host> hosts = new List<Host>();
        public List<Ticket> tickets = new List<Ticket>();
        public Bus Bus
        {
            get { return _bus; }
            set
            {
                for (int i = 0; i < drivers.Count; i++)
                {
                    if (value is LuxuryBus && drivers[i].licenseType == LicenseType.NormalLicense)
                    {
                        throw new Exception("Sefere yetkisiz şöför atanmış.");
                    }
                }
                _bus = value;
            }
        }
        public Route Route { get; }
        public DateTime DepartureTime { get; set; }
        public bool HasSnackService { get; set; }
        public string Code
        {
            get
            {
                return BusCodeGenerator();
            }
        }
        
        public DateTime EstimatedDepartureTime { get; set; }

        public DateTime EstimatedArrivalTime
        {
            get
            {
                return EstimatedDepartureTime.AddMinutes(this.Route.Duration);
            }
        }

        public bool HasDelay
        {
            get
            {
                if (DepartureTime == EstimatedDepartureTime)
                    return false;
                return true;
            }
        }

        public Expedition(Route route,DateTime departure,DateTime estimated)
        {
            this.Route = route;
            this.DepartureTime = departure;
            this.EstimatedDepartureTime = estimated;
            Random random = new Random();
            this._code = Convert.ToString(random.Next(1000, 9999));
        }

        public string BusCodeGenerator()
        {
            String result = "";
            result = this.Route.DepartureLocation[0] + DepartureTime.ToString("yyyyMMdd") + "-";
            if (this.Bus is LuxuryBus)
                result += "LX-";
            else if (this.Bus is StandartBus)
                result += "ST-";
            result += this._code;
            return result;
        }

        public Ticket SellTicket(Person person, int seatNumber, decimal fee)
        {
            if (IsSeatAvailableFor(person.gender, seatNumber) && IsFeeEnough(person, fee))
            {
                Ticket ticket = new Ticket(this, this.Bus.GetSeatInformation(seatNumber), person, fee);
                tickets.Add(ticket);
                return ticket;
            }
            else { throw new Exception("This transaction was declined."); }
        }

        public Ticket[] SellDoubleTicket(Person person1, Person person2, int seatNumber, decimal fee)
        {
            int adjacentSeatNumber = seatNumber % 3 == 2 ? seatNumber + 1 : seatNumber - 1;
            if (this.Bus is StandartBus && this.Bus.GetSeatInformation(seatNumber).Section == SeatSection.RightSide && IsFeeEnough(person1, person2, fee) && IsSeatEmpty(seatNumber) && IsSeatEmpty(adjacentSeatNumber))
            {
                Ticket[] doubleTickets = new Ticket[2];
                doubleTickets[0] = new Ticket(this, this.Bus.GetSeatInformation(seatNumber), person1, fee / 2);
                doubleTickets[1] = new Ticket(this, this.Bus.GetSeatInformation(adjacentSeatNumber), person2, fee / 2);
                tickets.Add(doubleTickets[0]);
                tickets.Add(doubleTickets[1]);
                return doubleTickets;
            }
            throw new Exception("This seat can not be sold as doubles.");
        }

        private bool IsFeeEnough(Person person, Decimal fee)
        {
            if ((IsCompanyWorker(person) && fee >= Route.BasePrice) || fee >= Route.BasePrice * 1.05M)
                return true;
            return false;
        }

        private bool IsFeeEnough(Person person1, Person person2, Decimal fee)
        {
            if (((IsCompanyWorker(person1) || IsCompanyWorker(person2)) && fee >= this.Route.BasePrice * 2) || fee >= this.Route.BasePrice * 1.05M * 2)
                return true;
            return false;
        }

        private bool IsCompanyWorker(Person person)
        {
            if (person is Driver || person is Host)
                return true;
            return false;
        }

        public bool IsSeatEmpty(int seatNumber)
        {
            for (int i = 0; i < tickets.Count; i++)
            {
                if (tickets[i].SeatInformation.Number == seatNumber)
                { return false; }
            }
            return true;
        }

        public bool IsSeatAvailableFor(Gender gender, int seatNumber)
        {
            int nextSeatIndex = -1;
            if (IsSeatEmpty(seatNumber) && this.Bus is StandartBus && this.Bus.GetSeatInformation(seatNumber).Section == SeatSection.RightSide)
            {
                int adjacentSeatNumber = seatNumber % 3 == 2 ? seatNumber + 1 : seatNumber - 1;
                for (int i = 0; i < tickets.Count; i++)
                {
                    if (tickets[i].SeatInformation.Number == adjacentSeatNumber)
                    {
                        nextSeatIndex = i;
                        continue;
                    }
                }
            }

            if (nextSeatIndex == -1 && IsSeatEmpty(seatNumber))
                return true;
            else if (IsSeatEmpty(seatNumber) && tickets[nextSeatIndex].Passenger.gender == gender)
                return true;
            else
                return false;
        }
        
        public decimal GetPriceOf(int seatNumber)
        {
            if (this.Bus is StandartBus)
            {
                if (seatNumber % 3 == 1)
                { return this.Route.BasePrice * 1.25M; }
                else
                { return this.Route.BasePrice * 1.20M; }
            }
            else
            {
                return this.Route.BasePrice * 1.35M;
            }
        }

        public void AddDriver(Driver driver)
        {
            if (this.Bus is LuxuryBus && driver.licenseType == LicenseType.HighLicense)
            { drivers.Add(driver); }
            else if (this.Bus is StandartBus && (driver.licenseType == LicenseType.NormalLicense || driver.licenseType == LicenseType.HighLicense))
            { drivers.Add(driver); }
            else
                throw new Exception("Şöförün bu otobüsü kullanma yetkisi yok.");
        }

        public void AddHost(Host host)
        {
            hosts.Add(host);
        }

        public void RemoveDriver(Driver driver)
        {
            drivers.Remove(driver);
        }

        public void RemoveHost(Host host)
        {
            hosts.Remove(host);
        }

        public void CancelTicket(Ticket ticket)
        {
            tickets.Remove(ticket);
        }
    }
}
