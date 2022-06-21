using Microsoft.EntityFrameworkCore;
using MudBlazorCRUD3.Entities;

namespace MudBlazorCRUD3.DataContext
{
    public class MyContext: DbContext
    {
        public MyContext()
        {
        }
        public MyContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Data Source=DESKTOP-6A148R0\\SQLEXPRESS;Initial Catalog=MudBlazorCRUD;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
