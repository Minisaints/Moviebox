namespace MovieBox.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
<<<<<<< HEAD
    
=======

>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
    public partial class AddedCustomerBirthDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "BirthDate", c => c.String());
        }
<<<<<<< HEAD
        
=======

>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
        public override void Down()
        {
            DropColumn("dbo.Customers", "BirthDate");
        }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
