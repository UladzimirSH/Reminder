namespace Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotations : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.UserPreferences", "UserId");
            AddForeignKey("dbo.UserPreferences", "UserId", "dbo.Users", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserPreferences", "UserId", "dbo.Users");
            DropIndex("dbo.UserPreferences", new[] { "UserId" });
        }
    }
}
