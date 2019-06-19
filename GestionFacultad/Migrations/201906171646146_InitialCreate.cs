namespace GestionFacultad.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alumnoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Dni = c.Int(nullable: false),
                        Tel = c.Int(nullable: false),
                        Direc = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Asignaturas",
                c => new
                    {
                        Asign = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Asign);
            
            CreateTable(
                "dbo.Aulas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Capacidad = c.Int(nullable: false),
                        ConexionARed = c.Boolean(nullable: false),
                        Proyeccion = c.Boolean(nullable: false),
                        Aul = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Profesors",
                c => new
                    {
                        Dni_ID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Dni = c.Int(nullable: false),
                        Tel = c.Int(nullable: false),
                        Direc = c.String(),
                    })
                .PrimaryKey(t => t.Dni_ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Profesors");
            DropTable("dbo.Aulas");
            DropTable("dbo.Asignaturas");
            DropTable("dbo.Alumnoes");
        }
    }
}
