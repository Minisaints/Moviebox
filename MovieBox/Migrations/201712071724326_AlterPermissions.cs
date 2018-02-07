namespace MovieBox.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AlterPermissions : DbMigration
    {
        public override void Up()
        {
            Sql(@"UPDATE [dbo].[AspNetRoles] SET Name = 'isAdministrator'");
        }

        public override void Down()
        {
        }
    }
}
