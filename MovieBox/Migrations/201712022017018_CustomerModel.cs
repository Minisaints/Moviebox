namespace MovieBox.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class CustomerModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
<<<<<<< HEAD
                "dbo.Customers",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                })
                .PrimaryKey(t => t.Id);

=======
                    "dbo.Customers",
                    c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
        }

        public override void Down()
        {
            DropTable("dbo.Customers");
        }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
