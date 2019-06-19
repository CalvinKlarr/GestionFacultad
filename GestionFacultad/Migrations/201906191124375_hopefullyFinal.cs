namespace GestionFacultad.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hopefullyFinal : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Calificacions", "student_Id", "dbo.Alumnoes");
            DropIndex("dbo.Calificacions", new[] { "student_Id" });
            AddColumn("dbo.Calificacions", "Parcial_1", c => c.Int(nullable: false));
            AddColumn("dbo.Calificacions", "Parcial_2", c => c.Int(nullable: false));
            AddColumn("dbo.Calificacions", "Parcial_3", c => c.Int(nullable: false));
            AddColumn("dbo.Calificacions", "Recup_1", c => c.Int(nullable: false));
            AddColumn("dbo.Calificacions", "Recup_2", c => c.Int(nullable: false));
            AddColumn("dbo.Calificacions", "Legajo", c => c.Int(nullable: false));
            DropColumn("dbo.Calificacions", "student_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Calificacions", "student_Id", c => c.Int());
            DropColumn("dbo.Calificacions", "Legajo");
            DropColumn("dbo.Calificacions", "Recup_2");
            DropColumn("dbo.Calificacions", "Recup_1");
            DropColumn("dbo.Calificacions", "Parcial_3");
            DropColumn("dbo.Calificacions", "Parcial_2");
            DropColumn("dbo.Calificacions", "Parcial_1");
            CreateIndex("dbo.Calificacions", "student_Id");
            AddForeignKey("dbo.Calificacions", "student_Id", "dbo.Alumnoes", "Id");
        }
    }
}
