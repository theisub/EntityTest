namespace EntityTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixingGeoPoint : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.GeoPoints", "GetPoint_PointId", "dbo.GeoPoints");
            DropIndex("dbo.GeoPoints", new[] { "GetPoint_PointId" });
            DropColumn("dbo.GeoPoints", "GetPoint_PointId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.GeoPoints", "GetPoint_PointId", c => c.Int());
            CreateIndex("dbo.GeoPoints", "GetPoint_PointId");
            AddForeignKey("dbo.GeoPoints", "GetPoint_PointId", "dbo.GeoPoints", "PointId");
        }
    }
}
