namespace MyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataMigration1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Position", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Position");
        }
    }
}
