namespace Voyager.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deneme : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Make = c.String(nullable: false, maxLength: 64),
                        Plate = c.String(nullable: false, maxLength: 16),
                        BusTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BusType", t => t.BusTypeId)
                .Index(t => t.BusTypeId);
            
            CreateTable(
                "dbo.BusType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 64),
                        SeatCount = c.Int(nullable: false),
                        HasToilet = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Expedition",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EstimatedDepartureTime = c.DateTime(nullable: false),
                        EstimatedArrivalTime = c.DateTime(nullable: false),
                        HasSnackService = c.Boolean(nullable: false),
                        DepartureLocation = c.String(nullable: false, maxLength: 64),
                        ArrivalLocation = c.String(nullable: false, maxLength: 64),
                        Distance = c.Int(nullable: false),
                        RouteName = c.String(nullable: false, maxLength: 64),
                        BusId = c.Int(nullable: false),
                        RouteId = c.Int(nullable: false),
                        Ticket_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Bus", t => t.BusId)
                .ForeignKey("dbo.Route", t => t.RouteId, cascadeDelete: true)
                .ForeignKey("dbo.Ticket", t => t.Ticket_Id)
                .Index(t => t.BusId)
                .Index(t => t.RouteId)
                .Index(t => t.Ticket_Id);
            
            CreateTable(
                "dbo.Driver",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LicenseType = c.Int(nullable: false),
                        PersonId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Person", t => t.PersonId)
                .Index(t => t.PersonId);
            
            CreateTable(
                "dbo.Person",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdentityNumber = c.String(nullable: false, maxLength: 11),
                        Age = c.Int(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 64),
                        LastName = c.String(nullable: false, maxLength: 64),
                        DateOfBirth = c.DateTime(nullable: false),
                        Gender = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Host",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Person", t => t.PersonId)
                .Index(t => t.PersonId);
            
            CreateTable(
                "dbo.Route",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DepartureLocation = c.String(),
                        ArrivalLocation = c.String(),
                        Distance = c.Int(nullable: false),
                        Duration = c.Int(nullable: false),
                        BreakCount = c.Int(nullable: false),
                        BasePrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ticket",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SeatNumber = c.Int(nullable: false),
                        PaidAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PersonId = c.Int(nullable: false),
                        ExpeditionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Expedition", t => t.ExpeditionId, cascadeDelete: true)
                .ForeignKey("dbo.Person", t => t.PersonId, cascadeDelete: true)
                .Index(t => t.PersonId)
                .Index(t => t.ExpeditionId);
            
            CreateTable(
                "dbo.DriverPocExpeditionPocs",
                c => new
                    {
                        DriverPoc_Id = c.Int(nullable: false),
                        ExpeditionPoc_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.DriverPoc_Id, t.ExpeditionPoc_Id })
                .ForeignKey("dbo.Driver", t => t.DriverPoc_Id, cascadeDelete: true)
                .ForeignKey("dbo.Expedition", t => t.ExpeditionPoc_Id, cascadeDelete: true)
                .Index(t => t.DriverPoc_Id)
                .Index(t => t.ExpeditionPoc_Id);
            
            CreateTable(
                "dbo.HostPocExpeditionPocs",
                c => new
                    {
                        HostPoc_Id = c.Int(nullable: false),
                        ExpeditionPoc_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.HostPoc_Id, t.ExpeditionPoc_Id })
                .ForeignKey("dbo.Host", t => t.HostPoc_Id, cascadeDelete: true)
                .ForeignKey("dbo.Expedition", t => t.ExpeditionPoc_Id, cascadeDelete: true)
                .Index(t => t.HostPoc_Id)
                .Index(t => t.ExpeditionPoc_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Expedition", "Ticket_Id", "dbo.Ticket");
            DropForeignKey("dbo.Ticket", "PersonId", "dbo.Person");
            DropForeignKey("dbo.Ticket", "ExpeditionId", "dbo.Expedition");
            DropForeignKey("dbo.Expedition", "RouteId", "dbo.Route");
            DropForeignKey("dbo.Host", "PersonId", "dbo.Person");
            DropForeignKey("dbo.HostPocExpeditionPocs", "ExpeditionPoc_Id", "dbo.Expedition");
            DropForeignKey("dbo.HostPocExpeditionPocs", "HostPoc_Id", "dbo.Host");
            DropForeignKey("dbo.Driver", "PersonId", "dbo.Person");
            DropForeignKey("dbo.DriverPocExpeditionPocs", "ExpeditionPoc_Id", "dbo.Expedition");
            DropForeignKey("dbo.DriverPocExpeditionPocs", "DriverPoc_Id", "dbo.Driver");
            DropForeignKey("dbo.Expedition", "BusId", "dbo.Bus");
            DropForeignKey("dbo.Bus", "BusTypeId", "dbo.BusType");
            DropIndex("dbo.HostPocExpeditionPocs", new[] { "ExpeditionPoc_Id" });
            DropIndex("dbo.HostPocExpeditionPocs", new[] { "HostPoc_Id" });
            DropIndex("dbo.DriverPocExpeditionPocs", new[] { "ExpeditionPoc_Id" });
            DropIndex("dbo.DriverPocExpeditionPocs", new[] { "DriverPoc_Id" });
            DropIndex("dbo.Ticket", new[] { "ExpeditionId" });
            DropIndex("dbo.Ticket", new[] { "PersonId" });
            DropIndex("dbo.Host", new[] { "PersonId" });
            DropIndex("dbo.Driver", new[] { "PersonId" });
            DropIndex("dbo.Expedition", new[] { "Ticket_Id" });
            DropIndex("dbo.Expedition", new[] { "RouteId" });
            DropIndex("dbo.Expedition", new[] { "BusId" });
            DropIndex("dbo.Bus", new[] { "BusTypeId" });
            DropTable("dbo.HostPocExpeditionPocs");
            DropTable("dbo.DriverPocExpeditionPocs");
            DropTable("dbo.Ticket");
            DropTable("dbo.Route");
            DropTable("dbo.Host");
            DropTable("dbo.Person");
            DropTable("dbo.Driver");
            DropTable("dbo.Expedition");
            DropTable("dbo.BusType");
            DropTable("dbo.Bus");
        }
    }
}
