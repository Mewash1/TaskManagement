namespace TaskManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTaskFields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tasks", "Created", c => c.DateTime(nullable: false));
            AddColumn("dbo.Tasks", "IsShared", c => c.Boolean(nullable: false));
            AddColumn("dbo.Users", "UserType_ID", c => c.Int());
            CreateIndex("dbo.Users", "UserType_ID");
            AddForeignKey("dbo.Users", "UserType_ID", "dbo.UserTypes", "ID");
            DropColumn("dbo.Users", "UserTypeID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "UserTypeID", c => c.Int(nullable: false));
            DropForeignKey("dbo.Users", "UserType_ID", "dbo.UserTypes");
            DropIndex("dbo.Users", new[] { "UserType_ID" });
            DropColumn("dbo.Users", "UserType_ID");
            DropColumn("dbo.Tasks", "IsShared");
            DropColumn("dbo.Tasks", "Created");
        }
    }
}
