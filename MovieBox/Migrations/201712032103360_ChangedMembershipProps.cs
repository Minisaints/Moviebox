namespace MovieBox.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class ChangedMembershipProps : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MembershipTypes", "MembershipName", c => c.String());
            AlterColumn("dbo.Genres", "Name", c => c.String(nullable: false, maxLength: 100));
        }

        public override void Down()
        {
            AlterColumn("dbo.Genres", "Name", c => c.String());
            AlterColumn("dbo.MembershipTypes", "MembershipName", c => c.String());
        }
    }
}
