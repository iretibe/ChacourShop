using ChacourShop.EmailAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ChacourShop.EmailAPI.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<EmailLog> EmailLogs { get; set; }
    }
}
