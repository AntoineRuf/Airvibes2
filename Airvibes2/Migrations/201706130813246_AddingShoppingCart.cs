namespace Airvibes2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingShoppingCart : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ShoppingCartItems",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    SongsId = c.Int(nullable: false),
                    MemberId = c.String(),
                })
                .PrimaryKey(t => t.Id);
        }
        
        public override void Down()
        {
            DropTable("dbo.ShoppingCartItems");
        }
    }
}
