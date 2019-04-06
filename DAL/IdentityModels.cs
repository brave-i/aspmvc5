using System.Data.Entity;
using DAL.DataModels;
using Microsoft.AspNet.Identity.EntityFramework;
using MySql.Data.Entity;

namespace DAL
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.

    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
           : base("DefaultConnection", throwIfV1Schema: false)
        {
            var _ = typeof(System.Data.Entity.SqlServer.SqlProviderServices);
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Organization> Organizations { get; set; }
    }
}