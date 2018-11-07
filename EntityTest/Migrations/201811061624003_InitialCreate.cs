namespace EntityTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        EventId = c.Int(nullable: false, identity: true),
                        AdminId = c.Int(nullable: false),
                        EventName = c.String(),
                        EventDescription = c.String(),
                        EventStartTime = c.DateTime(nullable: false),
                        EventEndTiem = c.DateTime(nullable: false),
                        EventUrl = c.String(),
                    })
                .PrimaryKey(t => t.EventId);
            
            CreateTable(
                "dbo.GeoPoints",
                c => new
                    {
                        PointId = c.Int(nullable: false, identity: true),
                        EventId = c.Int(nullable: false),
                        PointLatitiude = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PointLongitude = c.Decimal(nullable: false, precision: 18, scale: 2),
                        GetPoint_PointId = c.Int(),
                    })
                .PrimaryKey(t => t.PointId)
                .ForeignKey("dbo.GeoPoints", t => t.GetPoint_PointId)
                .ForeignKey("dbo.Events", t => t.EventId, cascadeDelete: true)
                .Index(t => t.EventId)
                .Index(t => t.GetPoint_PointId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GeoPoints", "EventId", "dbo.Events");
            DropForeignKey("dbo.GeoPoints", "GetPoint_PointId", "dbo.GeoPoints");
            DropIndex("dbo.GeoPoints", new[] { "GetPoint_PointId" });
            DropIndex("dbo.GeoPoints", new[] { "EventId" });
            DropTable("dbo.GeoPoints");
            DropTable("dbo.Events");
        }
    }
}
