namespace NurseCallMvc.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public sealed class Configuration : DbMigrationsConfiguration<NurseCallMvc.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(NurseCallMvc.Data.ApplicationDbContext context)
        {
        }
    }
}