namespace Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TaskType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                    "dbo.TaskType",
                    c => new
                    {                       
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Name);
        }
        
        public override void Down()
        {
            DropTable("dbo.TaskType");
        }
    }
}
