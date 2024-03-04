using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DatabaseContext:DbContext
    {

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<AttendanceLogs> AttendanceLogs { get; set; }

        public DbSet<Employees> Employees { get; set; }
    }


}
