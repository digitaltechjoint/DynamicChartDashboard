using DynamicChartDashboard.Models;
using Microsoft.EntityFrameworkCore;

namespace DynamicChartDashboard.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<SalesData> SalesData { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //avoid silent trancation for money values 
            modelBuilder.Entity<SalesData>()
                .Property(x => x.SalesAmount)
                .HasPrecision(18, 2);

            // Seed sample sales data for 2024, 2025, and 2026
            modelBuilder.Entity<SalesData>().HasData(
                // ===== 2024 =====
                new SalesData { Id = 1, Year = 2024, Month = "January", MonthNumber = 1, SalesAmount = 98000 },
                new SalesData { Id = 2, Year = 2024, Month = "February", MonthNumber = 2, SalesAmount = 112000 },
                new SalesData { Id = 3, Year = 2024, Month = "March", MonthNumber = 3, SalesAmount = 135000 },
                new SalesData { Id = 4, Year = 2024, Month = "April", MonthNumber = 4, SalesAmount = 128000 },
                new SalesData { Id = 5, Year = 2024, Month = "May", MonthNumber = 5, SalesAmount = 142000 },
                new SalesData { Id = 6, Year = 2024, Month = "June", MonthNumber = 6, SalesAmount = 155000 },
                new SalesData { Id = 7, Year = 2024, Month = "July", MonthNumber = 7, SalesAmount = 148000 },
                new SalesData { Id = 8, Year = 2024, Month = "August", MonthNumber = 8, SalesAmount = 162000 },
                new SalesData { Id = 9, Year = 2024, Month = "September", MonthNumber = 9, SalesAmount = 158000 },
                new SalesData { Id = 10, Year = 2024, Month = "October", MonthNumber = 10, SalesAmount = 175000 },
                new SalesData { Id = 11, Year = 2024, Month = "November", MonthNumber = 11, SalesAmount = 188000 },
                new SalesData { Id = 12, Year = 2024, Month = "December", MonthNumber = 12, SalesAmount = 210000 },

                // ===== 2025 =====
                new SalesData { Id = 13, Year = 2025, Month = "January", MonthNumber = 1, SalesAmount = 110000 },
                new SalesData { Id = 14, Year = 2025, Month = "February", MonthNumber = 2, SalesAmount = 128000 },
                new SalesData { Id = 15, Year = 2025, Month = "March", MonthNumber = 3, SalesAmount = 152000 },
                new SalesData { Id = 16, Year = 2025, Month = "April", MonthNumber = 4, SalesAmount = 140000 },
                new SalesData { Id = 17, Year = 2025, Month = "May", MonthNumber = 5, SalesAmount = 160000 },
                new SalesData { Id = 18, Year = 2025, Month = "June", MonthNumber = 6, SalesAmount = 172000 },
                new SalesData { Id = 19, Year = 2025, Month = "July", MonthNumber = 7, SalesAmount = 168000 },
                new SalesData { Id = 20, Year = 2025, Month = "August", MonthNumber = 8, SalesAmount = 185000 },
                new SalesData { Id = 21, Year = 2025, Month = "September", MonthNumber = 9, SalesAmount = 178000 },
                new SalesData { Id = 22, Year = 2025, Month = "October", MonthNumber = 10, SalesAmount = 198000 },
                new SalesData { Id = 23, Year = 2025, Month = "November", MonthNumber = 11, SalesAmount = 215000 },
                new SalesData { Id = 24, Year = 2025, Month = "December", MonthNumber = 12, SalesAmount = 245000 },

                // ===== 2026 =====
                new SalesData { Id = 25, Year = 2026, Month = "January", MonthNumber = 1, SalesAmount = 125000 },
                new SalesData { Id = 26, Year = 2026, Month = "February", MonthNumber = 2, SalesAmount = 145000 },
                new SalesData { Id = 27, Year = 2026, Month = "March", MonthNumber = 3, SalesAmount = 168000 },
                new SalesData { Id = 28, Year = 2026, Month = "April", MonthNumber = 4, SalesAmount = 152000 },
                new SalesData { Id = 29, Year = 2026, Month = "May", MonthNumber = 5, SalesAmount = 175000 },
                new SalesData { Id = 30, Year = 2026, Month = "June", MonthNumber = 6, SalesAmount = 190000 },
                new SalesData { Id = 31, Year = 2026, Month = "July", MonthNumber = 7, SalesAmount = 185000 },
                new SalesData { Id = 32, Year = 2026, Month = "August", MonthNumber = 8, SalesAmount = 210000 },
                new SalesData { Id = 33, Year = 2026, Month = "September", MonthNumber = 9, SalesAmount = 198000 },
                new SalesData { Id = 34, Year = 2026, Month = "October", MonthNumber = 10, SalesAmount = 225000 },
                new SalesData { Id = 35, Year = 2026, Month = "November", MonthNumber = 11, SalesAmount = 240000 },
                new SalesData { Id = 36, Year = 2026, Month = "December", MonthNumber = 12, SalesAmount = 275000 }
            );
        }
    }
}
