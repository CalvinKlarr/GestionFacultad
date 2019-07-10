namespace GestionFacultad.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Asignaturas");
            AlterColumn("dbo.Asignaturas", "Asign", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Asignaturas", "Asign");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Asignaturas");
            AlterColumn("dbo.Asignaturas", "Asign", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Asignaturas", "Asign");
        }
    }
}
