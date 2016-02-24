namespace ShagManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sdata : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DayTasks", "ParentTask_Id", c => c.Int());
            AddColumn("dbo.DayTaskStatus", "Reason", c => c.String());
            CreateIndex("dbo.DayTasks", "ParentTask_Id");
            AddForeignKey("dbo.DayTasks", "ParentTask_Id", "dbo.DayTasks", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DayTasks", "ParentTask_Id", "dbo.DayTasks");
            DropIndex("dbo.DayTasks", new[] { "ParentTask_Id" });
            DropColumn("dbo.DayTaskStatus", "Reason");
            DropColumn("dbo.DayTasks", "ParentTask_Id");
        }
    }
}
