namespace GestionFacultad.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class calif : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Calificacions",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        student_Id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Alumnoes", t => t.student_Id)
                .Index(t => t.student_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Calificacions", "student_Id", "dbo.Alumnoes");
            DropIndex("dbo.Calificacions", new[] { "student_Id" });
            DropTable("dbo.Calificacions");
        }
    }
}
