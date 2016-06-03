namespace MyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataMigration2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "Position", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "Position", c => c.String(nullable: false));
        }
    }
}
