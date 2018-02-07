namespace MovieBox.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
<<<<<<< HEAD
    
=======

>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
    public partial class AlteredAvailability : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "AvailableAmount", c => c.Byte());
        }
<<<<<<< HEAD
        
=======

>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
        public override void Down()
        {
            AlterColumn("dbo.Movies", "AvailableAmount", c => c.Byte(nullable: false));
        }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
