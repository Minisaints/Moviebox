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
<<<<<<< HEAD
}
=======
}
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
