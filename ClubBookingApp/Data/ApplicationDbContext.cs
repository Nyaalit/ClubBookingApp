using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ClubBookingApp.Data;

namespace ClubBookingApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ClubBookingApp.Data.Table>? Table { get; set; }
        public DbSet<ClubBookingApp.Data.Reservation>? Reservation { get; set; }
    }
}