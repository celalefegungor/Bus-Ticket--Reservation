using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voyager.Entities;

namespace Voyager.DAL
{
    public class UnitOfWork : IDisposable
    {
        private VoyagerContext db;

        public IRepo<PersonPoc> People { get; set; }
        public IRepo<TicketPoc> Tickets { get; set; }
        public IRepo<BusPoc> Buses { get; set; }
        public IRepo<ExpeditionPoc> Expeditions { get; set; }
        public IRepo<HostPoc> Hosts { get; set; }
        public IRepo<DriverPoc> Drivers { get; set; }
        public IRepo<BusTypePoc> BusTypes { get; set; }

        public UnitOfWork()
        {
            db = new VoyagerContext();

            People = new PersonRepo(db);
            Tickets = new TicketRepo(db);
            Buses = new BusRepo(db);
            Hosts = new HostRepo(db);
            Drivers = new DriverRepo(db);
            BusTypes = new BusTypeRepo(db);
        }


        public void Dispose()
        {
            db.Dispose();
        }

        public void SaveChanges()
        {
            db.SaveChanges();
        }
    }
}
