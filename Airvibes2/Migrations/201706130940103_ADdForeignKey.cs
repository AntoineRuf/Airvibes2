namespace Airvibes2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ADdForeignKey : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.ShoppingCartItems", "SongsId");
            AddForeignKey("dbo.ShoppingCartItems", "SongsId", "dbo.Songs", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ShoppingCartItems", "SongsId", "dbo.Songs");
            DropIndex("dbo.ShoppingCartItems", new[] { "SongsId" });
        }
    }
}
