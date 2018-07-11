namespace LocationManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmailNotification : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AlertInfo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CNICNumber = c.String(),
                        DisableAlert = c.Boolean(nullable: false),
                        DisableAlertDate = c.DateTime(nullable: false),
                        EnableAlertDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EmailAddress",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SystemSetting",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DaysToEmailNotification = c.Int(nullable: false),
                        DaysToBlockUser = c.Int(nullable: false),
                        SmtpServer = c.String(),
                        SmtpPort = c.String(),
                        FromEmailAddress = c.String(),
                        FromEmailPassword = c.String(),
                        IsSmptSSL = c.Boolean(nullable: false),
                        IsSmptAuthRequired = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SystemSetting");
            DropTable("dbo.EmailAddress");
            DropTable("dbo.AlertInfo");
        }
    }
}
