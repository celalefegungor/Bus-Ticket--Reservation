using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voyager.BLL
{
    public class App
    {
        public List<Expedition> allExpeditions { get; set; }
        public List<Bus> allBuses { get; set; }
        public List<Driver> allDrivers { get; set; }
        public List<Person> allPeople { get; set; }
        public List<Host> allHosts { get; set; }
        public List<Route> allRoutes { get; set; }
        public List<Ticket> allTickets { get; set; }


        public App()
        {
            allExpeditions = new List<Expedition>();
            allBuses = new List<Bus>();
            allDrivers = new List<Driver>();
            allPeople = new List<Person>();
            allHosts = new List<Host>();
            allRoutes = new List<Route>();
            allTickets = new List<Ticket>();
        }


    }
}
