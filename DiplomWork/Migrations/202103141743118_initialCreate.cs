namespace DiplomWork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Answers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Text = c.String(),
                        Rightanswer = c.String(),
                        Question_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Questions", t => t.Question_Id)
                .Index(t => t.Question_Id);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Questiontype = c.Int(nullable: false),
                        Value = c.Single(nullable: false),
                        Test_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tests", t => t.Test_Id)
                .Index(t => t.Test_Id);
            
            CreateTable(
                "dbo.Tests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Counteroftries = c.Int(nullable: false),
                        Time = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        Subject_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Subjects", t => t.Subject_Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.Subject_Id);
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Sign = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Name = c.String(nullable: false),
                        Surename = c.String(nullable: false),
                        Adress = c.String(),
                        Birthdate = c.String(),
                        Status = c.Int(nullable: false),
                        GroupId = c.Int(nullable: false),
                        Group_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Groups", t => t.Group_Id)
                .Index(t => t.Group_Id);
            
            CreateTable(
                "dbo.Grades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Values",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Testvalue = c.Single(nullable: false),
                        UserId = c.Int(nullable: false),
                        Subject_Id = c.Int(),
                        Test_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Subjects", t => t.Subject_Id)
                .ForeignKey("dbo.Tests", t => t.Test_Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.Subject_Id)
                .Index(t => t.Test_Id);
            
            CreateTable(
                "dbo.GroupTests",
                c => new
                    {
                        Group_Id = c.String(nullable: false, maxLength: 128),
                        Test_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Group_Id, t.Test_Id })
                .ForeignKey("dbo.Groups", t => t.Group_Id, cascadeDelete: true)
                .ForeignKey("dbo.Tests", t => t.Test_Id, cascadeDelete: true)
                .Index(t => t.Group_Id)
                .Index(t => t.Test_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Values", "UserId", "dbo.Users");
            DropForeignKey("dbo.Values", "Test_Id", "dbo.Tests");
            DropForeignKey("dbo.Values", "Subject_Id", "dbo.Subjects");
            DropForeignKey("dbo.Answers", "Question_Id", "dbo.Questions");
            DropForeignKey("dbo.Questions", "Test_Id", "dbo.Tests");
            DropForeignKey("dbo.Tests", "UserId", "dbo.Users");
            DropForeignKey("dbo.Users", "Group_Id", "dbo.Groups");
            DropForeignKey("dbo.Tests", "Subject_Id", "dbo.Subjects");
            DropForeignKey("dbo.GroupTests", "Test_Id", "dbo.Tests");
            DropForeignKey("dbo.GroupTests", "Group_Id", "dbo.Groups");
            DropIndex("dbo.GroupTests", new[] { "Test_Id" });
            DropIndex("dbo.GroupTests", new[] { "Group_Id" });
            DropIndex("dbo.Values", new[] { "Test_Id" });
            DropIndex("dbo.Values", new[] { "Subject_Id" });
            DropIndex("dbo.Values", new[] { "UserId" });
            DropIndex("dbo.Users", new[] { "Group_Id" });
            DropIndex("dbo.Tests", new[] { "Subject_Id" });
            DropIndex("dbo.Tests", new[] { "UserId" });
            DropIndex("dbo.Questions", new[] { "Test_Id" });
            DropIndex("dbo.Answers", new[] { "Question_Id" });
            DropTable("dbo.GroupTests");
            DropTable("dbo.Values");
            DropTable("dbo.Grades");
            DropTable("dbo.Users");
            DropTable("dbo.Subjects");
            DropTable("dbo.Groups");
            DropTable("dbo.Tests");
            DropTable("dbo.Questions");
            DropTable("dbo.Answers");
        }
    }
}
