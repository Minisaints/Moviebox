namespace MovieBox.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBeenReturned : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rentals", "BeenReturned", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rentals", "BeenReturned");
        }
    }
}
