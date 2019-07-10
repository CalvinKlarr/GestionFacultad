namespace GestionFacultad.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class str : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Asignaturas", "correlativasDB", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Asignaturas", "correlativasDB");
        }
    }
}
