using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FoodHealthModulo1.Context
{
    public class FoodHealthModulo1Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public FoodHealthModulo1Context() : base("name=FoodHealthModulo1Context")
        {
        }

        public System.Data.Entity.DbSet<FoodHealthModulo1.Models.Cliente> Clientes { get; set; }

        public System.Data.Entity.DbSet<FoodHealthModulo1.Models.DocumentType> DocumentTypes { get; set; }

        public System.Data.Entity.DbSet<FoodHealthModulo1.Models.Employee> Employees { get; set; }

        public System.Data.Entity.DbSet<FoodHealthModulo1.Models.Role> Roles { get; set; }

        public System.Data.Entity.DbSet<FoodHealthModulo1.Models.Tracing> Tracings { get; set; }

        public System.Data.Entity.DbSet<FoodHealthModulo1.Models.Nutritionist> Nutritionists { get; set; }

        public System.Data.Entity.DbSet<FoodHealthModulo1.Models.Assessment> Assessments { get; set; }

        public System.Data.Entity.DbSet<FoodHealthModulo1.Models.Diary> Diaries { get; set; }
    }
}
