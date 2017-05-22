namespace PeopleProTraining.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Building",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        number = c.Int(nullable: false),
                        address = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Department",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        BuildingID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Building", t => t.BuildingID, cascadeDelete: true)
                .Index(t => t.BuildingID);
            
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        firstName = c.String(),
                        lastName = c.String(),
                        DepartmentID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Department", t => t.DepartmentID, cascadeDelete: true)
                .Index(t => t.DepartmentID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employee", "DepartmentID", "dbo.Department");
            DropForeignKey("dbo.Department", "BuildingID", "dbo.Building");
            DropIndex("dbo.Employee", new[] { "DepartmentID" });
            DropIndex("dbo.Department", new[] { "BuildingID" });
            DropTable("dbo.Employee");
            DropTable("dbo.Department");
            DropTable("dbo.Building");
        }
    }
}
