namespace MovieBox.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddMembershipType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
<<<<<<< HEAD
                "dbo.MembershipTypes",
                c => new
                {
                    Id = c.Byte(nullable: false),
                    SignUpFee = c.Short(nullable: false),
                    DurationInMonths = c.Byte(nullable: false),
                    DiscountRate = c.Byte(nullable: false),
                })
=======
                    "dbo.MembershipTypes",
                    c => new
                    {
                        Id = c.Byte(nullable: false),
                        SignUpFee = c.Short(nullable: false),
                        DurationInMonths = c.Byte(nullable: false),
                        DiscountRate = c.Byte(nullable: false),
                    })
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
                .PrimaryKey(t => t.Id);

            AddColumn("dbo.Customers", "MembershipTypeId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Customers", "MembershipTypeId");
            AddForeignKey("dbo.Customers", "MembershipTypeId", "dbo.MembershipTypes", "Id", cascadeDelete: true);
        }

        public override void Down()
        {
            DropForeignKey("dbo.Customers", "MembershipTypeId", "dbo.MembershipTypes");
<<<<<<< HEAD
            DropIndex("dbo.Customers", new[] { "MembershipTypeId" });
=======
            DropIndex("dbo.Customers", new[] {"MembershipTypeId"});
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
            DropColumn("dbo.Customers", "MembershipTypeId");
            DropTable("dbo.MembershipTypes");
        }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
