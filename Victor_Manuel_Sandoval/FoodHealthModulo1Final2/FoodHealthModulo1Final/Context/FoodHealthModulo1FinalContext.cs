using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FoodHealthModulo1Final.Context
{
    public class FoodHealthModulo1FinalContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public FoodHealthModulo1FinalContext() : base("name=FoodHealthModulo1FinalContext")
        {
        }

        public System.Data.Entity.DbSet<FoodHealthModulo1Final.Models.Profiles.Customer> Customers { get; set; }

        public System.Data.Entity.DbSet<FoodHealthModulo1Final.Models.Profiles.DocumentType> DocumentTypes { get; set; }

        public System.Data.Entity.DbSet<FoodHealthModulo1Final.Models.Profiles.Role> Roles { get; set; }

        public System.Data.Entity.DbSet<FoodHealthModulo1Final.Models.Profiles.Employee> Employees { get; set; }

        public System.Data.Entity.DbSet<FoodHealthModulo1Final.Models.Packages.PackageType> PackageTypes { get; set; }

        public System.Data.Entity.DbSet<FoodHealthModulo1Final.Models.Packages.Package> Packages { get; set; }

        public System.Data.Entity.DbSet<FoodHealthModulo1Final.Models.Diary.AppointmentType> AppointmentTypes { get; set; }

        public System.Data.Entity.DbSet<FoodHealthModulo1Final.Models.Diary.Diary> Diaries { get; set; }

        public System.Data.Entity.DbSet<FoodHealthModulo1Final.Models.Orders.Order> Orders { get; set; }

        public System.Data.Entity.DbSet<FoodHealthModulo1Final.Models.Orders.OrderDetail> OrderDetails { get; set; }
   
    }
}
