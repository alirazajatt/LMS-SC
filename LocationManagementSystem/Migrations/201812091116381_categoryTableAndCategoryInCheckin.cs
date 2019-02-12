namespace LocationManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class categoryTableAndCategoryInCheckin : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CategoryInfo",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                        CategoryLocation = c.String(),
                        CategoryBlockCriteria = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            AddColumn("dbo.CheckInInfo", "Category", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.CheckInInfo", "Category");
            DropTable("dbo.CategoryInfo");
        }
    }
}
