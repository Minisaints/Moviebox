namespace MovieBox.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddedGenreModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
<<<<<<< HEAD
                "dbo.Movies",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false),
                    GenreId = c.Byte(nullable: false),
                })
=======
                    "dbo.Movies",
                    c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        GenreId = c.Byte(nullable: false),
                    })
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Genres", t => t.GenreId, cascadeDelete: true)
                .Index(t => t.GenreId);

            CreateTable(
<<<<<<< HEAD
                "dbo.Genres",
                c => new
                {
                    Id = c.Byte(nullable: false),
                    Name = c.String(),
                })
                .PrimaryKey(t => t.Id);

=======
                    "dbo.Genres",
                    c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
        }

        public override void Down()
        {
            DropForeignKey("dbo.Movies", "GenreId", "dbo.Genres");
<<<<<<< HEAD
            DropIndex("dbo.Movies", new[] { "GenreId" });
=======
            DropIndex("dbo.Movies", new[] {"GenreId"});
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
            DropTable("dbo.Genres");
            DropTable("dbo.Movies");
        }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
