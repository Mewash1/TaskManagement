namespace TaskManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNecessaryFieldsEmployee : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Employees", name: "Manager_ID", newName: "ManagerID");
            RenameColumn(table: "dbo.Employees", name: "Task_ID", newName: "TaskID");
            RenameIndex(table: "dbo.Employees", name: "IX_Task_ID", newName: "IX_TaskID");
            RenameIndex(table: "dbo.Employees", name: "IX_Manager_ID", newName: "IX_ManagerID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Employees", name: "IX_ManagerID", newName: "IX_Manager_ID");
            RenameIndex(table: "dbo.Employees", name: "IX_TaskID", newName: "IX_Task_ID");
            RenameColumn(table: "dbo.Employees", name: "TaskID", newName: "Task_ID");
            RenameColumn(table: "dbo.Employees", name: "ManagerID", newName: "Manager_ID");
        }
    }
}
