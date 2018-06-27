namespace Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotations1 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Friends", "UserId");
            AddForeignKey("dbo.Friends", "UserId", "dbo.Users", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Friends", "UserId", "dbo.Users");
            DropIndex("dbo.Friends", new[] { "UserId" });
        }
    }
}
