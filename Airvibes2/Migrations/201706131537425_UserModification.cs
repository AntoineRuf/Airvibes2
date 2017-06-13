namespace Airvibes2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserModification : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Songs", "ApplicationUser_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Songs", "ApplicationUser_Id");
            AddForeignKey("dbo.Songs", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Songs", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Songs", new[] { "ApplicationUser_Id" });
            DropColumn("dbo.Songs", "ApplicationUser_Id");
        }
    }
}
