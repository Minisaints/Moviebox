namespace MovieBox.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteredAvailability : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "AvailableAmount", c => c.Byte());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "AvailableAmount", c => c.Byte(nullable: false));
        }
    }
}
