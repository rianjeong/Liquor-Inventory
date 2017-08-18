using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using LiquorInventory.Models; 

namespace LiquorInventory.DAL
{
    public class LiquorContext : DbContext
    {

        public LiquorContext() : base("LiquorContext")
        {
        }

        public DbSet<Liquor> Liquors { get; set; }
        public DbSet<Cocktail> Cocktails { get; set; }
        public DbSet<MonthlyCost> MonthlyCosts { get; set; }
       

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}