namespace MovieBox.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddedMembershipName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "MembershipName", c => c.String());
<<<<<<< HEAD

=======
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
        }

        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "MembershipName");
        }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
