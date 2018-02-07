namespace MovieBox.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AnotherRentalFix : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Rentals", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.Rentals", "Movie_Id", "dbo.Movies");
            DropIndex("dbo.Rentals", new[] { "Customer_Id" });
            DropIndex("dbo.Rentals", new[] { "Movie_Id" });
            DropColumn("dbo.Rentals", "CustomerId");
            DropColumn("dbo.Rentals", "MovieId");
            RenameColumn(table: "dbo.Rentals", name: "Customer_Id", newName: "CustomerId");
            RenameColumn(table: "dbo.Rentals", name: "Movie_Id", newName: "MovieId");
            AlterColumn("dbo.Rentals", "MovieId", c => c.Int(nullable: false));
            AlterColumn("dbo.Rentals", "CustomerId", c => c.Int(nullable: false));
            AlterColumn("dbo.Rentals", "CustomerId", c => c.Int(nullable: false));
            AlterColumn("dbo.Rentals", "MovieId", c => c.Int(nullable: false));
            CreateIndex("dbo.Rentals", "MovieId");
            CreateIndex("dbo.Rentals", "CustomerId");
            AddForeignKey("dbo.Rentals", "CustomerId", "dbo.Customers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Rentals", "MovieId", "dbo.Movies", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rentals", "MovieId", "dbo.Movies");
            DropForeignKey("dbo.Rentals", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Rentals", new[] { "CustomerId" });
            DropIndex("dbo.Rentals", new[] { "MovieId" });
            AlterColumn("dbo.Rentals", "MovieId", c => c.Int());
            AlterColumn("dbo.Rentals", "CustomerId", c => c.Int());
            AlterColumn("dbo.Rentals", "CustomerId", c => c.Byte(nullable: false));
            AlterColumn("dbo.Rentals", "MovieId", c => c.Byte(nullable: false));
            RenameColumn(table: "dbo.Rentals", name: "MovieId", newName: "Movie_Id");
            RenameColumn(table: "dbo.Rentals", name: "CustomerId", newName: "Customer_Id");
            AddColumn("dbo.Rentals", "MovieId", c => c.Byte(nullable: false));
            AddColumn("dbo.Rentals", "CustomerId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Rentals", "Movie_Id");
            CreateIndex("dbo.Rentals", "Customer_Id");
            AddForeignKey("dbo.Rentals", "Movie_Id", "dbo.Movies", "Id");
            AddForeignKey("dbo.Rentals", "Customer_Id", "dbo.Customers", "Id");
        }
    }
}
