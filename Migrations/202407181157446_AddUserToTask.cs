namespace TaskManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserToTask : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tasks", "User_ID", c => c.Int());
            CreateIndex("dbo.Tasks", "User_ID");
            AddForeignKey("dbo.Tasks", "User_ID", "dbo.Users", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tasks", "User_ID", "dbo.Users");
            DropIndex("dbo.Tasks", new[] { "User_ID" });
            DropColumn("dbo.Tasks", "User_ID");
        }
    }
}
