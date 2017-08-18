namespace LiquorInventory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tryingtoinitializedatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cocktail",
                c => new
                    {
                        cocktailId = c.Int(nullable: false, identity: true),
                        cocktailName = c.String(),
                        cocktailCost = c.Double(nullable: false),
                        cocktailPrice = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.cocktailId);
            
            CreateTable(
                "dbo.Ingredient",
                c => new
                    {
                        IngID = c.Int(nullable: false, identity: true),
                        IngName = c.String(),
                        IngCost = c.Double(nullable: false),
                        Cocktail_cocktailId = c.Int(),
                    })
                .PrimaryKey(t => t.IngID)
                .ForeignKey("dbo.Cocktail", t => t.Cocktail_cocktailId)
                .Index(t => t.Cocktail_cocktailId);
            
            CreateTable(
                "dbo.Liquor",
                c => new
                    {
                        liquorId = c.Int(nullable: false, identity: true),
                        liquorName = c.String(),
                        liquorCost = c.Double(nullable: false),
                        liquorInventory = c.Double(nullable: false),
                        liquorInventoryCost = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.liquorId);
            
            CreateTable(
                "dbo.MonthlyCost",
                c => new
                    {
                        MonthlyCostId = c.Int(nullable: false, identity: true),
                        Month = c.String(),
                        CurrentInventoryCost = c.Double(nullable: false),
                        PreviousMonth = c.String(),
                        PreviousInventoryCost = c.Double(nullable: false),
                        MonthlySales = c.Double(nullable: false),
                        Difference = c.Double(nullable: false),
                        PourCost = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.MonthlyCostId);
            
            CreateTable(
                "dbo.LiquorCocktail",
                c => new
                    {
                        Liquor_liquorId = c.Int(nullable: false),
                        Cocktail_cocktailId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Liquor_liquorId, t.Cocktail_cocktailId })
                .ForeignKey("dbo.Liquor", t => t.Liquor_liquorId, cascadeDelete: true)
                .ForeignKey("dbo.Cocktail", t => t.Cocktail_cocktailId, cascadeDelete: true)
                .Index(t => t.Liquor_liquorId)
                .Index(t => t.Cocktail_cocktailId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LiquorCocktail", "Cocktail_cocktailId", "dbo.Cocktail");
            DropForeignKey("dbo.LiquorCocktail", "Liquor_liquorId", "dbo.Liquor");
            DropForeignKey("dbo.Ingredient", "Cocktail_cocktailId", "dbo.Cocktail");
            DropIndex("dbo.LiquorCocktail", new[] { "Cocktail_cocktailId" });
            DropIndex("dbo.LiquorCocktail", new[] { "Liquor_liquorId" });
            DropIndex("dbo.Ingredient", new[] { "Cocktail_cocktailId" });
            DropTable("dbo.LiquorCocktail");
            DropTable("dbo.MonthlyCost");
            DropTable("dbo.Liquor");
            DropTable("dbo.Ingredient");
            DropTable("dbo.Cocktail");
        }
    }
}
