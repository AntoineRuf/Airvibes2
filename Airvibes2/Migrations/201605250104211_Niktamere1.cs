namespace Airvibes2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Niktamere1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Songs", "Mark", c => c.Int());
            AddColumn("dbo.Songs", "NbrMarks", c => c.Int());
            DropColumn("dbo.Songs", "TotalRaters");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Songs", "TotalRaters", c => c.Int(nullable: false));
            DropColumn("dbo.Songs", "NbrMarks");
            DropColumn("dbo.Songs", "Mark");
        }
    }
}
