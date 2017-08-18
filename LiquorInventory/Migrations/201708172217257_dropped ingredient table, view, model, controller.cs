namespace LiquorInventory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class droppedingredienttableviewmodelcontroller : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Ingredient", "Cocktail_cocktailId", "dbo.Cocktail");
            DropIndex("dbo.Ingredient", new[] { "Cocktail_cocktailId" });
            DropTable("dbo.Ingredient");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Ingredient",
                c => new
                    {
                        IngID = c.Int(nullable: false, identity: true),
                        IngName = c.String(),
                        IngCost = c.Double(nullable: false),
                        Cocktail_cocktailId = c.Int(),
                    })
                .PrimaryKey(t => t.IngID);
            
            CreateIndex("dbo.Ingredient", "Cocktail_cocktailId");
            AddForeignKey("dbo.Ingredient", "Cocktail_cocktailId", "dbo.Cocktail", "cocktailId");
        }
    }
}
