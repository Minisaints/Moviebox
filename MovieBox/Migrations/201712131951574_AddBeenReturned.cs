namespace MovieBox.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
<<<<<<< HEAD
    
=======

>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
    public partial class AddBeenReturned : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rentals", "BeenReturned", c => c.Boolean(nullable: false));
        }
<<<<<<< HEAD
        
=======

>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
        public override void Down()
        {
            DropColumn("dbo.Rentals", "BeenReturned");
        }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
