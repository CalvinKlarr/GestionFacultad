namespace GestionFacultad.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class curdivision : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cursoes", "CurDivision", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cursoes", "CurDivision");
        }
    }
}
