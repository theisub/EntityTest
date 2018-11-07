namespace EntityTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedNullableToTimes : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Events", "EventStartTime", c => c.DateTime());
            AlterColumn("dbo.Events", "EventEndTime", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Events", "EventEndTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Events", "EventStartTime", c => c.DateTime(nullable: false));
        }
    }
}
