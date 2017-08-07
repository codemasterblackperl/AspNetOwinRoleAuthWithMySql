namespace DarelWebV2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Calls");
            DropTable("dbo.Units");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Units",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        UserName = c.String(unicode: false),
                        Area = c.String(unicode: false),
                        Officers = c.String(unicode: false),
                        AdditionalInfo = c.String(unicode: false),
                        Dispatched = c.DateTime(nullable: false, precision: 0),
                        Finished = c.DateTime(nullable: false, precision: 0),
                        Status = c.Int(nullable: false),
                        TotalHours = c.Double(nullable: false),
                        CallId = c.Long(nullable: false),
                        CurrentLocation = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Calls",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        ControlNumber = c.String(unicode: false),
                        EnteredBy = c.String(unicode: false),
                        CallReceivedTime = c.DateTime(nullable: false, precision: 0),
                        Address = c.String(unicode: false),
                        Area = c.String(unicode: false),
                        BusinessName = c.String(unicode: false),
                        CallType = c.String(unicode: false),
                        AdditionalInfo = c.String(unicode: false),
                        Complainant = c.String(unicode: false),
                        ContactAt = c.String(unicode: false),
                        IncidentNotes = c.String(unicode: false),
                        UnitAssigned = c.String(unicode: false),
                        Dispatched = c.String(unicode: false),
                        Arived = c.String(unicode: false),
                        Finished = c.String(unicode: false),
                        Disposition = c.String(unicode: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
