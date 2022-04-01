namespace NurseCallMvc.Web
{
    using System.Data.Entity;
    using NurseCallMvc.Data;
    using NurseCallMvc.Data.Migrations;

    public static class DatabaseConfig
    {
        public static void Config()
        {
            // Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());
        }
    }
}