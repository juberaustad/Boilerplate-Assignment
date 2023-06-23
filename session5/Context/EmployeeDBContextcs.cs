using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace session5.Context
{
    public class EmployeeDBContextcs:IdentityDbContext<ApplicationUser>
    {
        public EmployeeDBContextcs(DbContextOptions<EmployeeDBContextcs> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
