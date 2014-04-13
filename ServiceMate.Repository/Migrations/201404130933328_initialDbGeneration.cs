namespace ServiceMate.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialDbGeneration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Consumers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        ProfileId = c.Int(),
                        ConsumerName = c.String(),
                        PhoneNumber = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                        EntityStatus = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Profiles", t => t.ProfileId)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.ProfileId);
            
            CreateTable(
                "dbo.Profiles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsDeleted = c.Boolean(nullable: false),
                        EntityStatus = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Password = c.String(),
                        Email = c.String(),
                        Token = c.String(),
                        UserType = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        EntityStatus = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ServiceProviders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        BusinessName = c.String(),
                        ABN = c.String(),
                        SuburbList = c.Int(nullable: false),
                        Range = c.Int(nullable: false),
                        ServiceProviderServiceList = c.Int(nullable: false),
                        ProfileId = c.Int(),
                        IsDeleted = c.Boolean(nullable: false),
                        EntityStatus = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Profiles", t => t.ProfileId)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.ProfileId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ServiceProviders", "UserId", "dbo.Users");
            DropForeignKey("dbo.ServiceProviders", "ProfileId", "dbo.Profiles");
            DropForeignKey("dbo.Consumers", "UserId", "dbo.Users");
            DropForeignKey("dbo.Consumers", "ProfileId", "dbo.Profiles");
            DropIndex("dbo.ServiceProviders", new[] { "ProfileId" });
            DropIndex("dbo.ServiceProviders", new[] { "UserId" });
            DropIndex("dbo.Consumers", new[] { "ProfileId" });
            DropIndex("dbo.Consumers", new[] { "UserId" });
            DropTable("dbo.ServiceProviders");
            DropTable("dbo.Users");
            DropTable("dbo.Profiles");
            DropTable("dbo.Consumers");
        }
    }
}
