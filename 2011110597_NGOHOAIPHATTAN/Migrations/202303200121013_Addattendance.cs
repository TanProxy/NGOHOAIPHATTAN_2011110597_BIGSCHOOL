namespace _2011110597_NGOHOAIPHATTAN.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addattendance : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attendances",
                c => new
                    {
                        CourseId = c.Int(nullable: false),
                        AttendeeId = c.String(nullable: false, maxLength: 128),
                        Attendee = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.CourseId, t.AttendeeId })
                .ForeignKey("dbo.Courses", t => t.CourseId)
                .Index(t => t.CourseId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Attendances", "CourseId", "dbo.Courses");
            DropIndex("dbo.Attendances", new[] { "CourseId" });
            DropTable("dbo.Attendances");
        }
    }
}
