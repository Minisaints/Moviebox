namespace MovieBox.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
<<<<<<< HEAD
    
=======

>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
    public partial class AddDrivingLicense : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "DrivingLicence", c => c.String(nullable: false, maxLength: 100));
        }
<<<<<<< HEAD
        
=======

>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "DrivingLicence");
        }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
