using ExpenseTrackingSystem.Models.DatabaseModels;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTrackingSystem.Models.DatabaseContexts
{
    public class ExpenseContext : DbContext
    {
        public ExpenseContext(DbContextOptions options): base(options)
        {
            //
        }

        public DbSet<ExpenseCategory> Categories { get; set; }
        public DbSet<ExpenseTransactions> Transactions { get; set; }
    }
}
