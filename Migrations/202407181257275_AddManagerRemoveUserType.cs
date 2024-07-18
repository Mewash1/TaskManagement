namespace TaskManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddManagerRemoveUserType : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Users", "UserType_ID", "dbo.UserTypes");
            RenameTable(name: "dbo.Users", newName: "Employees");     
            DropForeignKey("dbo.Tasks", "User_ID", "dbo.Users");
            DropIndex("dbo.Tasks", new[] { "User_ID" });
            DropIndex("dbo.Employees", new[] { "UserType_ID" });
            AddColumn("dbo.Employees", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Employees", "Manager_ID", c => c.Int());
            AddColumn("dbo.Employees", "Task_ID", c => c.Int());
            CreateIndex("dbo.Employees", "Manager_ID");
            CreateIndex("dbo.Employees", "Task_ID");
            AddForeignKey("dbo.Employees", "Manager_ID", "dbo.Employees", "ID");
            AddForeignKey("dbo.Employees", "Task_ID", "dbo.Tasks", "ID");
            DropColumn("dbo.Tasks", "IsShared");
            DropColumn("dbo.Tasks", "User_ID");
            DropColumn("dbo.Employees", "UserType_ID");
            DropTable("dbo.UserTypes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.UserTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Employees", "UserType_ID", c => c.Int());
            AddColumn("dbo.Tasks", "User_ID", c => c.Int());
            AddColumn("dbo.Tasks", "IsShared", c => c.Boolean(nullable: false));
            DropForeignKey("dbo.Employees", "Task_ID", "dbo.Tasks");
            DropForeignKey("dbo.Employees", "Manager_ID", "dbo.Employees");
            DropIndex("dbo.Employees", new[] { "Task_ID" });
            DropIndex("dbo.Employees", new[] { "Manager_ID" });
            DropColumn("dbo.Employees", "Task_ID");
            DropColumn("dbo.Employees", "Manager_ID");
            DropColumn("dbo.Employees", "Discriminator");
            CreateIndex("dbo.Employees", "UserType_ID");
            CreateIndex("dbo.Tasks", "User_ID");
            AddForeignKey("dbo.Tasks", "User_ID", "dbo.Users", "ID");
            AddForeignKey("dbo.Users", "UserType_ID", "dbo.UserTypes", "ID");
            RenameTable(name: "dbo.Employees", newName: "Users");
        }
    }
}
