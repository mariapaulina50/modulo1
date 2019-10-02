namespace FoodHealthModulo1Final.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FoodHealthModulo1Final.Context.FoodHealthModulo1FinalContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "FoodHealthModulo1Final.Context.FoodHealthModulo1FinalContext";
        }

        protected override void Seed(FoodHealthModulo1Final.Context.FoodHealthModulo1FinalContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
