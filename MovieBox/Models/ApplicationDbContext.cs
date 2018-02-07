using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace MovieBox.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
<<<<<<< HEAD

=======
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<MembershipType> MembershipTypes { get; set; }
        public DbSet<Rental> Rentals { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}