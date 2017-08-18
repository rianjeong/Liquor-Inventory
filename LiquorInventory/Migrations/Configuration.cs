namespace LiquorInventory.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LiquorInventory.DAL.LiquorContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LiquorInventory.DAL.LiquorContext context)
        {
            /*
            var Liquors = new List<Liquor>
            {
            
            new Liquor { liquorName = "Grey Goose", liquorCost = 39.99, liquorInventory = .4},
            new Liquor { liquorName = "Woodford Reserve", liquorCost = 52.99, liquorInventory = .8 },
            new Liquor { liquorName = "Bombay Saphire", liquorCost = 36.99, liquorInventory = .3 },
            new Liquor { liquorName = "Bacardi Rum", liquorCost = 25.99, liquorInventory = .7},
            new Liquor { liquorName = "Patron Silver", liquorCost = 43.99, liquorInventory = .5 },
            new Liquor { liquorName = "Triple Sec", liquorCost = 11.99, liquorInventory = .8},
            new Liquor { liquorName = "Dry Vermouth", liquorCost = 9.99, liquorInventory = .2},
            new Liquor { liquorName = "Hennesy VS", liquorCost = 56.99, liquorInventory = .1 }
            };
           
            Liquors.ForEach(s => context.Liquors.Add(s));
            context.SaveChanges();

            var Cocktails = new List<Cocktail>
            {
            new Cocktail { cocktailName = "Lemon Drop", cocktailPrice = 11.00 },
            new Cocktail { cocktailName = "Side Car", cocktailPrice = 12.00 },
            new Cocktail { cocktailName = "Gin Martini", cocktailPrice = 14.00 },
            new Cocktail { cocktailName = "Old Fashion", cocktailPrice = 13.00 },
            new Cocktail { cocktailName = "Margarita", cocktailPrice = 9.00 },
            new Cocktail { cocktailName = "Daquiri", cocktailPrice = 12.00 }
            };

            Cocktails.ForEach(s => context.Cocktails.Add(s));
            context.SaveChanges();

            var Ingredients = new List<Ingredient>
            {
            new Ingredient { IngID = 0, IngName = "Lemon Juice"},
            new Ingredient { IngID = 1, IngName = "Lime Juice" },
            new Ingredient { IngID = 2, IngName = "Sugar Cube" },
            new Ingredient { IngID = 3, IngName = "Orange" },
            new Ingredient { IngID = 4, IngName = "Cherry" },
            new Ingredient { IngID = 5, IngName = "olive" }
            };

            Ingredients.ForEach(s => context.Ingredients.Add(s));
            context.SaveChanges();

            var MonthlyCosts = new List<MonthlyCost>
            {
            new MonthlyCost { Month = "June", CurrentInventoryCost = 3100, PreviousMonth = "May", PreviousInventoryCost = 4995, Difference = -1895, MonthlySales = 8345 },
            new MonthlyCost { Month = "July", CurrentInventoryCost = 2500, PreviousMonth = "June", PreviousInventoryCost =  3100, Difference = 600, MonthlySales = 7253},
            new MonthlyCost { Month = "August", CurrentInventoryCost = 3800, PreviousMonth = "July", PreviousInventoryCost =  2500, Difference = 1300, MonthlySales = 7800}
            };
            MonthlyCosts.ForEach(s => context.MonthlyCosts.Add(s));
            context.SaveChanges();
            */

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
