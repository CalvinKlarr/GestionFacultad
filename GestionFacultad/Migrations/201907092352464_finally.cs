namespace GestionFacultad.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _finally : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Asignaturas", "correlativasDB", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Asignaturas", "correlativasDB", c => c.String(nullable: false));
        }
    }
}
