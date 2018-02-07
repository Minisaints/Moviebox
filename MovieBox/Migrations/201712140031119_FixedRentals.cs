namespace MovieBox.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
<<<<<<< HEAD
    
=======

>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
    public partial class FixedRentals : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Rentals", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.Rentals", "Movie_Id", "dbo.Movies");
<<<<<<< HEAD
            DropIndex("dbo.Rentals", new[] { "Customer_Id" });
            DropIndex("dbo.Rentals", new[] { "Movie_Id" });
=======
            DropIndex("dbo.Rentals", new[] {"Customer_Id"});
            DropIndex("dbo.Rentals", new[] {"Movie_Id"});
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
            AlterColumn("dbo.Rentals", "Customer_Id", c => c.Int());
            AlterColumn("dbo.Rentals", "Movie_Id", c => c.Int());
            CreateIndex("dbo.Rentals", "Customer_Id");
            CreateIndex("dbo.Rentals", "Movie_Id");
            AddForeignKey("dbo.Rentals", "Customer_Id", "dbo.Customers", "Id");
            AddForeignKey("dbo.Rentals", "Movie_Id", "dbo.Movies", "Id");
        }
<<<<<<< HEAD
        
=======

>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
        public override void Down()
        {
            DropForeignKey("dbo.Rentals", "Movie_Id", "dbo.Movies");
            DropForeignKey("dbo.Rentals", "Customer_Id", "dbo.Customers");
<<<<<<< HEAD
            DropIndex("dbo.Rentals", new[] { "Movie_Id" });
            DropIndex("dbo.Rentals", new[] { "Customer_Id" });
=======
            DropIndex("dbo.Rentals", new[] {"Movie_Id"});
            DropIndex("dbo.Rentals", new[] {"Customer_Id"});
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
            AlterColumn("dbo.Rentals", "Movie_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Rentals", "Customer_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Rentals", "Movie_Id");
            CreateIndex("dbo.Rentals", "Customer_Id");
            AddForeignKey("dbo.Rentals", "Movie_Id", "dbo.Movies", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Rentals", "Customer_Id", "dbo.Customers", "Id", cascadeDelete: true);
        }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
