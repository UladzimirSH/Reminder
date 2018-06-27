namespace Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BankCards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        BankId = c.Int(nullable: false),
                        Number = c.Int(nullable: false),
                        ExpiryDate = c.DateTime(nullable: false),
                        Note = c.String(maxLength: 256),
                        NotifyType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Banks", t => t.BankId, cascadeDelete: true)
                .Index(t => t.BankId);
            
            CreateTable(
                "dbo.Banks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Friends",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        FirstName = c.String(maxLength: 50),
                        LastName = c.String(maxLength: 50),
                        Note = c.String(maxLength: 256),
                        DateOfBirth = c.DateTime(nullable: false),
                        DateOfWedding = c.DateTime(nullable: false),
                        IsNotify = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(maxLength: 256),
                        Password = c.String(maxLength: 256),
                        PhoneNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserPreferences",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        HourOfNotification = c.Int(nullable: false),
                        IsPhoneNotificationEnabled = c.Boolean(nullable: false),
                        IsEmailNotificationEnabled = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BankCards", "BankId", "dbo.Banks");
            DropIndex("dbo.BankCards", new[] { "BankId" });
            DropTable("dbo.UserPreferences");
            DropTable("dbo.Users");
            DropTable("dbo.Friends");
            DropTable("dbo.Banks");
            DropTable("dbo.BankCards");
        }
    }
}
