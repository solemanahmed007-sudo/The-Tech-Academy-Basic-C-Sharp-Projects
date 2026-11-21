
using CarInsurance.Models;
using Microsoft.EntityFrameworkCore;

namespace CarInsurance.Data
{
    // Database context for the insurance application.
    public class CarInsuranceContext : DbContext
    {
        // Configure the database connection.
        public CarInsuranceContext(
            DbContextOptions<CarInsuranceContext> options)
            : base(options)
        {
        }

        // Store insurance applicants in the database.
        public DbSet<Insuree> Insurees { get; set; } = null!;
    }
}
