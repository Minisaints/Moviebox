namespace MovieBox.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddedMovieAvailability : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "AvailableAmount", c => c.Byte(nullable: false));
            Sql("UPDATE Movies SET AvailableAmount = Stock");
        }

        public override void Down()
        {
            DropColumn("dbo.Movies", "AvailableAmount");
        }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
