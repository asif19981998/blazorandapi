using LMS.Models.Auth;
using LMSApi.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LMSApi
{
    public class LMSDbContext : IdentityDbContext<ApplicationIdentityUser, ApplicationIdentityRole, string>
    {
        public LMSDbContext(DbContextOptions<LMSDbContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
    }
}
