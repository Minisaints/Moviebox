namespace MovieBox.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
<<<<<<< HEAD
    
=======

>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
    public partial class AddInitialRentalModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
<<<<<<< HEAD
                "dbo.Rentals",
                c => new
=======
                    "dbo.Rentals",
                    c => new
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateRented = c.DateTime(nullable: false),
                        DateReturned = c.DateTime(),
                        Customer_Id = c.Int(nullable: false),
                        Movie_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Customer_Id, cascadeDelete: true)
                .ForeignKey("dbo.Movies", t => t.Movie_Id, cascadeDelete: true)
                .Index(t => t.Customer_Id)
                .Index(t => t.Movie_Id);
<<<<<<< HEAD
            
        }
        
=======
        }

>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
        public override void Down()
        {
            DropForeignKey("dbo.Rentals", "Movie_Id", "dbo.Movies");
            DropForeignKey("dbo.Rentals", "Customer_Id", "dbo.Customers");
<<<<<<< HEAD
            DropIndex("dbo.Rentals", new[] { "Movie_Id" });
            DropIndex("dbo.Rentals", new[] { "Customer_Id" });
            DropTable("dbo.Rentals");
        }
    }
}
=======
            DropIndex("dbo.Rentals", new[] {"Movie_Id"});
            DropIndex("dbo.Rentals", new[] {"Customer_Id"});
            DropTable("dbo.Rentals");
        }
    }
}
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
