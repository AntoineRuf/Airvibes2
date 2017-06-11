namespace Airvibes2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Artists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Photo = c.String(),
                        Name = c.String(),
                        Bio = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Records",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Artists_Id = c.Int(nullable: false),
                        Cover = c.String(),
                        Title = c.String(),
                        ReleaseDate = c.DateTime(),
                        Genre = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Artists", t => t.Artists_Id, cascadeDelete: true)
                .Index(t => t.Artists_Id);
            
            CreateTable(
                "dbo.Songs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Artists_Id = c.Int(nullable: false),
                        Records_Id = c.Int(nullable: false),
                        Title = c.String(),
                        Duration = c.Int(nullable: false),
                        TimesPlayed = c.Int(nullable: true),
                        FilePath = c.String(),
                        Rating = c.Int(nullable: true),
                        TotalRaters = c.Int(nullable: true),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Artists", t => t.Artists_Id, cascadeDelete: false)
                .ForeignKey("dbo.Records", t => t.Records_Id, cascadeDelete: false)
                .Index(t => t.Artists_Id)
                .Index(t => t.Records_Id);
            
            CreateTable(
                "dbo.SComments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Users_Id = c.String(maxLength: 128),
                        Songs_Id = c.Int(nullable: false),
                        Body = c.String(),
                        PostedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Songs", t => t.Songs_Id, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.Users_Id)
                .Index(t => t.Users_Id)
                .Index(t => t.Songs_Id);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Nom = c.String(nullable: false, maxLength: 50),
                        Prénom = c.String(nullable: false, maxLength: 50),
                        DateNaissance = c.DateTime(nullable: false),
                        Adresse = c.String(),
                        NumeroTelephone = c.String(),
                        Ville = c.String(),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.SComments", "Users_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.SComments", "Songs_Id", "dbo.Songs");
            DropForeignKey("dbo.Songs", "Records_Id", "dbo.Records");
            DropForeignKey("dbo.Songs", "Artists_Id", "dbo.Artists");
            DropForeignKey("dbo.Records", "Artists_Id", "dbo.Artists");
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.SComments", new[] { "Songs_Id" });
            DropIndex("dbo.SComments", new[] { "Users_Id" });
            DropIndex("dbo.Songs", new[] { "Records_Id" });
            DropIndex("dbo.Songs", new[] { "Artists_Id" });
            DropIndex("dbo.Records", new[] { "Artists_Id" });
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.SComments");
            DropTable("dbo.Songs");
            DropTable("dbo.Records");
            DropTable("dbo.Artists");
        }
    }
}
