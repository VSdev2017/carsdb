namespace Sport.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Year = c.Int(nullable: false),
                        model_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Models", t => t.model_id)
                .Index(t => t.model_id);
            
            CreateTable(
                "dbo.Models",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        manufacturer_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Manufacturers", t => t.manufacturer_id)
                .Index(t => t.manufacturer_id);
            
            CreateTable(
                "dbo.Manufacturers",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Country = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "model_id", "dbo.Models");
            DropForeignKey("dbo.Models", "manufacturer_id", "dbo.Manufacturers");
            DropIndex("dbo.Models", new[] { "manufacturer_id" });
            DropIndex("dbo.Cars", new[] { "model_id" });
            DropTable("dbo.Manufacturers");
            DropTable("dbo.Models");
            DropTable("dbo.Cars");
        }
    }
}
