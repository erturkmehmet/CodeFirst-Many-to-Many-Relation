namespace CodeFirst_MtoMRelation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OriginalDB2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TeacherStudents",
                c => new
                    {
                        Teacher_Id = c.Int(nullable: false),
                        Student_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Teacher_Id, t.Student_Id })
                .ForeignKey("dbo.Teachers", t => t.Teacher_Id, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.Student_Id, cascadeDelete: true)
                .Index(t => t.Teacher_Id)
                .Index(t => t.Student_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TeacherStudents", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.TeacherStudents", "Teacher_Id", "dbo.Teachers");
            DropIndex("dbo.TeacherStudents", new[] { "Student_Id" });
            DropIndex("dbo.TeacherStudents", new[] { "Teacher_Id" });
            DropTable("dbo.TeacherStudents");
            DropTable("dbo.Teachers");
            DropTable("dbo.Students");
        }
    }
}
