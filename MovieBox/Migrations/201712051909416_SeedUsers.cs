namespace MovieBox.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
<<<<<<< HEAD
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e5d41361-89ff-4384-9c6b-28249f9fc017', N'guest@MovieBox.com', 0, N'AJxjEPsek8MJoN/fSQGpMc4WQFsiu26BIapRAGRWXTzkDSUS6u3mN7ciREeVZR3Slg==', N'578e23ae-8e06-4b46-b4cd-dcf83fa0f60f', NULL, 0, 0, NULL, 1, 0, N'guest@MovieBox.com')
=======
            Sql(
                @"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e5d41361-89ff-4384-9c6b-28249f9fc017', N'guest@MovieBox.com', 0, N'AJxjEPsek8MJoN/fSQGpMc4WQFsiu26BIapRAGRWXTzkDSUS6u3mN7ciREeVZR3Slg==', N'578e23ae-8e06-4b46-b4cd-dcf83fa0f60f', NULL, 0, 0, NULL, 1, 0, N'guest@MovieBox.com')
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ecb14713-6231-4a8a-9a0c-682ede7878e4', N'admin@MovieBox.com', 0, N'ANQbjQsVFVg/yBeNMo8kmfCuuF4pdEfC8F3nTsm5aYky0oKNGn15Dbz1Rnzb8rGz9g==', N'94918f0b-ba1d-4d03-bd3f-22d7271382bf', NULL, 0, 0, NULL, 1, 0, N'admin@MovieBox.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'55f8f6a6-e032-48d1-9721-6bd9302f8778', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ecb14713-6231-4a8a-9a0c-682ede7878e4', N'55f8f6a6-e032-48d1-9721-6bd9302f8778')
");
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
