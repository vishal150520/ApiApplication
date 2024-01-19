using ApiApplication.Models;
using Microsoft.EntityFrameworkCore;
namespace ApiApplication.Services
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        // entities        
        public DbSet<Users> Users { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<UserRoles> Userroles { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedRoles(builder);
        }
        private static void SeedRoles(ModelBuilder builder)
        {
            builder.Entity<Roles>().HasData
            (
                new Roles() {RoleID=1, RoleName="Admin",IsActive=true},
                new Roles() {RoleID =2, RoleName = "Company", IsActive = true },
                new Roles() {RoleID =3,RoleName = "Candidate", IsActive = true }
            );
        }
    }
}
