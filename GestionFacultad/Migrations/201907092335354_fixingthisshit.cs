namespace GestionFacultad.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixingthisshit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Alumnoes", "aprobadasDB", c => c.String());
            AddColumn("dbo.Asignaturas", "inscriptosDB", c => c.String());
            AddColumn("dbo.Cursoes", "asignaturasDB", c => c.String());
            AddColumn("dbo.Cursoes", "alumnoIDDB", c => c.String());
            AddColumn("dbo.Profesors", "materiasDB", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Profesors", "materiasDB");
            DropColumn("dbo.Cursoes", "alumnoIDDB");
            DropColumn("dbo.Cursoes", "asignaturasDB");
            DropColumn("dbo.Asignaturas", "inscriptosDB");
            DropColumn("dbo.Alumnoes", "aprobadasDB");
        }
    }
}
