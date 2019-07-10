namespace GestionFacultad.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration_one : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alumnoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        aprobadasDB = c.String(),
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
                        correlativasDB = c.String(),
                        inscriptosDB = c.String(),
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
                "dbo.Calificacions",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Parcial_1 = c.Int(nullable: false),
                        Parcial_2 = c.Int(nullable: false),
                        Parcial_3 = c.Int(nullable: false),
                        Recup_1 = c.Int(nullable: false),
                        Recup_2 = c.Int(nullable: false),
                        Legajo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Cursoes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        asignaturasDB = c.String(),
                        alumnoIDDB = c.String(),
                        Cur = c.String(),
                        Division = c.String(),
                        CurDivision = c.String(),
                        aula_Id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Aulas", t => t.aula_Id)
                .Index(t => t.aula_Id);
            
            CreateTable(
                "dbo.Profesors",
                c => new
                    {
                        Dni_ID = c.Int(nullable: false, identity: true),
                        materiasDB = c.String(),
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
            DropForeignKey("dbo.Cursoes", "aula_Id", "dbo.Aulas");
            DropIndex("dbo.Cursoes", new[] { "aula_Id" });
            DropTable("dbo.Profesors");
            DropTable("dbo.Cursoes");
            DropTable("dbo.Calificacions");
            DropTable("dbo.Aulas");
            DropTable("dbo.Asignaturas");
            DropTable("dbo.Alumnoes");
        }
    }
}
