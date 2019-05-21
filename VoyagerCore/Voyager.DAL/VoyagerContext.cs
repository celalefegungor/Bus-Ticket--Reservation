using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voyager.Entities;

namespace Voyager.DAL
{
    public class VoyagerContext : DbContext
    {
        public DbSet<PersonPoc> People { get; set; }
        public DbSet<TicketPoc> Tickets { get; set; }
        public DbSet<BusPoc> Buses { get; set; }
        public DbSet<ExpeditionPoc> Expeditions { get; set; }
        public DbSet<HostPoc> Hosts { get; set; }
        public DbSet<BusTypePoc> BusTypes { get; set; }

        public VoyagerContext() : base("VoyagerConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<VoyagerContext, Voyager.DAL.Migrations.Configuration>());
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);
            //CASCADE
            // When wiping the Driver Person to not give error using Cascade with Fluent API
            modelBuilder.Entity<DriverPoc>().HasRequired<PersonPoc>(d => d.Person).WithMany().WillCascadeOnDelete(false);
            //Host-Person
            modelBuilder.Entity<HostPoc>().HasRequired<PersonPoc>(d => d.Person).WithMany().WillCascadeOnDelete(false);
            //Expediton - Ticket
            modelBuilder.Entity<ExpeditionPoc>().HasRequired<TicketPoc>(e => e.Ticket).WithMany().WillCascadeOnDelete(false);
            //Bus - BusType
            modelBuilder.Entity<BusPoc>().HasRequired<BusTypePoc>(b => b.BusType).WithMany().WillCascadeOnDelete(false);
            //Expedition - Bus
            modelBuilder.Entity<ExpeditionPoc>().HasRequired<BusPoc>(e => e.Bus).WithMany().WillCascadeOnDelete(false);
           




        }
    }
}
