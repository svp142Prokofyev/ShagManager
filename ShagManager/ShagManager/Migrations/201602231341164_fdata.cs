namespace ShagManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fdata : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DayTasks", "Type_Id", c => c.Int());
            CreateIndex("dbo.DayTasks", "Type_Id");
            AddForeignKey("dbo.DayTasks", "Type_Id", "dbo.DayTaskTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DayTasks", "Type_Id", "dbo.DayTaskTypes");
            DropIndex("dbo.DayTasks", new[] { "Type_Id" });
            DropColumn("dbo.DayTasks", "Type_Id");
        }
    }
}
