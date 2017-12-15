namespace MovieBox.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddedMembershipName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "MembershipName", c => c.String());

        }

        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "MembershipName");
        }
    }
}
