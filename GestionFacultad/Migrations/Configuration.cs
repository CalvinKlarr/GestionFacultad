namespace GestionFacultad.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GestionFacultad.ProgramControl>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "GestionFacultad.ProgramControl";
        }

        protected override void Seed(GestionFacultad.ProgramControl context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
