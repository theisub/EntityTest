namespace EntityTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedNameForTime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "EventEndTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.Events", "EventEndTiem");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Events", "EventEndTiem", c => c.DateTime(nullable: false));
            DropColumn("dbo.Events", "EventEndTime");
        }
    }
}
