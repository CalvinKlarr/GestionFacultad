namespace GestionFacultad.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cursoes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Cur = c.String(),
                        Division = c.String(),
                        aula_Id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Aulas", t => t.aula_Id)
                .Index(t => t.aula_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cursoes", "aula_Id", "dbo.Aulas");
            DropIndex("dbo.Cursoes", new[] { "aula_Id" });
            DropTable("dbo.Cursoes");
        }
    }
}
