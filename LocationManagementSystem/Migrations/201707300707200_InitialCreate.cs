namespace LocationManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BlockedPersonInfo",
                c => new
                    {
                        BlockedPersonInfoId = c.Int(nullable: false, identity: true),
                        CNICNumber = c.String(),
                        BlockedBy = c.String(),
                        BlockedReason = c.String(),
                        UnBlockedBy = c.String(),
                        UnBlockedReason = c.String(),
                        Blocked = c.Boolean(nullable: false),
                        BlockedTime = c.DateTime(nullable: false),
                        UnBlockTime = c.DateTime(nullable: false),
                        BlockedInPlant = c.Boolean(nullable: false),
                        BlockedInColony = c.Boolean(nullable: false),
                        CardHolderId = c.Int(),
                        VisitorId = c.Int(),
                        DailyCardHolderId = c.Int(),
                    })
                .PrimaryKey(t => t.BlockedPersonInfoId)
                .ForeignKey("dbo.CardHolder", t => t.CardHolderId)
                .ForeignKey("dbo.DailyCardHolder", t => t.DailyCardHolderId)
                .ForeignKey("dbo.Visitor", t => t.VisitorId)
                .Index(t => t.CardHolderId)
                .Index(t => t.VisitorId)
                .Index(t => t.DailyCardHolderId);
            
            CreateTable(
                "dbo.CardHolder",
                c => new
                    {
                        CardHolderId = c.Int(nullable: false, identity: true),
                        FTItemId = c.Int(nullable: false),
                        CardNumber = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        BloodGroup = c.String(),
                        CadreId = c.Int(),
                        CrewId = c.Int(),
                        DateOfBirth = c.String(),
                        DepartmentId = c.Int(),
                        DesignationId = c.Int(),
                        ContactNumber = c.String(),
                        CNICNumber = c.String(),
                        PNumber = c.String(),
                        SectionId = c.Int(),
                        CompanyId = c.Int(),
                        WONumber = c.String(),
                        IsTemp = c.Boolean(nullable: false),
                        Picture = c.Binary(storeType: "image"),
                        ConstractorInfo = c.String(),
                    })
                .PrimaryKey(t => t.CardHolderId)
                .ForeignKey("dbo.Cadre", t => t.CadreId)
                .ForeignKey("dbo.Company", t => t.CompanyId)
                .ForeignKey("dbo.Crew", t => t.CrewId)
                .ForeignKey("dbo.Department", t => t.DepartmentId)
                .ForeignKey("dbo.Designation", t => t.DesignationId)
                .ForeignKey("dbo.Section", t => t.SectionId)
                .Index(t => t.CadreId)
                .Index(t => t.CrewId)
                .Index(t => t.DepartmentId)
                .Index(t => t.DesignationId)
                .Index(t => t.SectionId)
                .Index(t => t.CompanyId);
            
            CreateTable(
                "dbo.Cadre",
                c => new
                    {
                        CadreId = c.Int(nullable: false, identity: true),
                        CadreName = c.String(),
                    })
                .PrimaryKey(t => t.CadreId);
            
            CreateTable(
                "dbo.CheckInInfo",
                c => new
                    {
                        CheckInInfoId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        CNICNumber = c.String(),
                        CardNumber = c.String(),
                        VehicleNmuber = c.String(),
                        NoOfMaleGuest = c.Decimal(nullable: false, precision: 18, scale: 2),
                        NoOfFemaleGuest = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DurationOfStay = c.Decimal(nullable: false, precision: 18, scale: 2),
                        NoOfChildren = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AreaOfVisit = c.String(),
                        HostName = c.String(),
                        DateTimeIn = c.DateTime(nullable: false),
                        DateTimeOut = c.DateTime(nullable: false),
                        CheckedIn = c.Boolean(nullable: false),
                        CheckInToPlant = c.Boolean(nullable: false),
                        CheckInToColony = c.Boolean(nullable: false),
                        CardHolderId = c.Int(),
                        VisitorId = c.Int(),
                        DailyCardHolderId = c.Int(),
                    })
                .PrimaryKey(t => t.CheckInInfoId)
                .ForeignKey("dbo.CardHolder", t => t.CardHolderId)
                .ForeignKey("dbo.DailyCardHolder", t => t.DailyCardHolderId)
                .ForeignKey("dbo.Visitor", t => t.VisitorId)
                .Index(t => t.CardHolderId)
                .Index(t => t.VisitorId)
                .Index(t => t.DailyCardHolderId);
            
            CreateTable(
                "dbo.DailyCardHolder",
                c => new
                    {
                        DailyCardHolderId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        CompanyName = c.String(),
                        Cadre = c.String(),
                        Department = c.String(),
                        Designation = c.String(),
                        Section = c.String(),
                        ContactNumber = c.String(),
                        CNICNumber = c.String(),
                        WONumber = c.String(),
                        Picture = c.Binary(storeType: "image"),
                        ClubType = c.String(),
                        ConstractorInfo = c.String(),
                        AreaOfWork = c.String(),
                    })
                .PrimaryKey(t => t.DailyCardHolderId);
            
            CreateTable(
                "dbo.Visitor",
                c => new
                    {
                        VisitorId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Address = c.String(),
                        Gender = c.String(),
                        PostCode = c.String(),
                        City = c.String(),
                        CNICNumber = c.String(),
                        State = c.String(),
                        CompanyName = c.String(),
                        ContactNo = c.String(),
                        ContantPerson = c.String(),
                        EmergencytNumber = c.String(),
                        VisitorType = c.String(),
                        IsOnPlant = c.Boolean(nullable: false),
                        Picture = c.Binary(storeType: "image"),
                        SchoolName = c.String(),
                        VisitorInfo = c.String(),
                    })
                .PrimaryKey(t => t.VisitorId);
            
            CreateTable(
                "dbo.Company",
                c => new
                    {
                        CompanyId = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(),
                    })
                .PrimaryKey(t => t.CompanyId);
            
            CreateTable(
                "dbo.Crew",
                c => new
                    {
                        CrewId = c.Int(nullable: false, identity: true),
                        CrewName = c.String(),
                    })
                .PrimaryKey(t => t.CrewId);
            
            CreateTable(
                "dbo.Department",
                c => new
                    {
                        DepartmentId = c.Int(nullable: false, identity: true),
                        DepartmentName = c.String(),
                    })
                .PrimaryKey(t => t.DepartmentId);
            
            CreateTable(
                "dbo.Designation",
                c => new
                    {
                        DesignationId = c.Int(nullable: false, identity: true),
                        Designation = c.String(),
                    })
                .PrimaryKey(t => t.DesignationId);
            
            CreateTable(
                "dbo.Section",
                c => new
                    {
                        SectionId = c.Int(nullable: false, identity: true),
                        SectionName = c.String(),
                    })
                .PrimaryKey(t => t.SectionId);
            
            CreateTable(
                "dbo.VisitingLocations",
                c => new
                    {
                        VisitingLocationsId = c.Int(nullable: false, identity: true),
                        Location = c.String(),
                        IsOnPlant = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.VisitingLocationsId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BlockedPersonInfo", "VisitorId", "dbo.Visitor");
            DropForeignKey("dbo.BlockedPersonInfo", "DailyCardHolderId", "dbo.DailyCardHolder");
            DropForeignKey("dbo.BlockedPersonInfo", "CardHolderId", "dbo.CardHolder");
            DropForeignKey("dbo.CardHolder", "SectionId", "dbo.Section");
            DropForeignKey("dbo.CardHolder", "DesignationId", "dbo.Designation");
            DropForeignKey("dbo.CardHolder", "DepartmentId", "dbo.Department");
            DropForeignKey("dbo.CardHolder", "CrewId", "dbo.Crew");
            DropForeignKey("dbo.CardHolder", "CompanyId", "dbo.Company");
            DropForeignKey("dbo.CheckInInfo", "VisitorId", "dbo.Visitor");
            DropForeignKey("dbo.CheckInInfo", "DailyCardHolderId", "dbo.DailyCardHolder");
            DropForeignKey("dbo.CheckInInfo", "CardHolderId", "dbo.CardHolder");
            DropForeignKey("dbo.CardHolder", "CadreId", "dbo.Cadre");
            DropIndex("dbo.CheckInInfo", new[] { "DailyCardHolderId" });
            DropIndex("dbo.CheckInInfo", new[] { "VisitorId" });
            DropIndex("dbo.CheckInInfo", new[] { "CardHolderId" });
            DropIndex("dbo.CardHolder", new[] { "CompanyId" });
            DropIndex("dbo.CardHolder", new[] { "SectionId" });
            DropIndex("dbo.CardHolder", new[] { "DesignationId" });
            DropIndex("dbo.CardHolder", new[] { "DepartmentId" });
            DropIndex("dbo.CardHolder", new[] { "CrewId" });
            DropIndex("dbo.CardHolder", new[] { "CadreId" });
            DropIndex("dbo.BlockedPersonInfo", new[] { "DailyCardHolderId" });
            DropIndex("dbo.BlockedPersonInfo", new[] { "VisitorId" });
            DropIndex("dbo.BlockedPersonInfo", new[] { "CardHolderId" });
            DropTable("dbo.VisitingLocations");
            DropTable("dbo.Section");
            DropTable("dbo.Designation");
            DropTable("dbo.Department");
            DropTable("dbo.Crew");
            DropTable("dbo.Company");
            DropTable("dbo.Visitor");
            DropTable("dbo.DailyCardHolder");
            DropTable("dbo.CheckInInfo");
            DropTable("dbo.Cadre");
            DropTable("dbo.CardHolder");
            DropTable("dbo.BlockedPersonInfo");
        }
    }
}
