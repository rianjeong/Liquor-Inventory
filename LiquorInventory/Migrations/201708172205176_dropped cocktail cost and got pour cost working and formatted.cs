namespace LiquorInventory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class droppedcocktailcostandgotpourcostworkingandformatted : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Cocktail", "cocktailCost");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cocktail", "cocktailCost", c => c.Double(nullable: false));
        }
    }
}
