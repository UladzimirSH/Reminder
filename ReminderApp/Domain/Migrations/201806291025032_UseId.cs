namespace Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UseId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Friends", "UserId", "dbo.Users");
            DropIndex("dbo.Friends", new[] { "UserId" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Friends", "UserId");
            AddForeignKey("dbo.Friends", "UserId", "dbo.Users", "Id", cascadeDelete: true);
        }
    }
}
