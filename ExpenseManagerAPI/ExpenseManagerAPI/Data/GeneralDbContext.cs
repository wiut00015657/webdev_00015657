using ExpenseManageAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpenseManagerAPI.Data
{
    public class GeneralDbContext: DbContext
    {
        public GeneralDbContext(DbContextOptions<GeneralDbContext> o) : base(o) { }

        public DbSet<Expense> Expenses { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
