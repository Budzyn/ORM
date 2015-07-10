namespace entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class gdfg : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Asks",
                c => new
                    {
                        AskID = c.Int(nullable: false, identity: true),
                        Category = c.String(),
                        NameAsk = c.String(),
                    })
                .PrimaryKey(t => t.AskID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Lectures",
                c => new
                    {
                        LectureID = c.Int(nullable: false, identity: true),
                        TeacherID = c.Int(nullable: false),
                        Name = c.String(),
                        Category = c.String(),
                        Discriptions = c.String(),
                    })
                .PrimaryKey(t => t.LectureID);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        TeacherID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Lecture = c.String(),
                    })
                .PrimaryKey(t => t.TeacherID);
            
            CreateTable(
                "dbo.Tests",
                c => new
                    {
                        TestID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Category = c.String(),
                        ListAsk = c.String(),
                        TimeMax = c.Int(nullable: false),
                        Pass = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TestID);
            
            CreateTable(
                "dbo.DoTests",
                c => new
                    {
                        DoTestID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        UserID = c.Int(nullable: false),
                        Result = c.Int(nullable: false),
                        Time = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DoTestID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Age = c.Int(nullable: false),
                        City = c.String(),
                        University = c.String(),
                        Category = c.String(),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.DoTests");
            DropTable("dbo.Tests");
            DropTable("dbo.Teachers");
            DropTable("dbo.Lectures");
            DropTable("dbo.Categories");
            DropTable("dbo.Asks");
        }
    }
}
