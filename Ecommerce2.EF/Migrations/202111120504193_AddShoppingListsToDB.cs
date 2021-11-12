namespace Ecommerce2.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddShoppingListsToDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ShoppingLists",
                c => new
                    {
                        ShoppingListId = c.Int(nullable: false, identity: true),
                        TypeOfList = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ShoppingListId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ShoppingLists");
        }
    }
}
