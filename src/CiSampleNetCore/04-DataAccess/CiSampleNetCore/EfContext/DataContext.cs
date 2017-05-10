using CiSampleNetCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace CiSampleNetCore.Data.EfContext
{
    public class DataContext : DbContext, IDataContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options) 
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=TestDb;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todo>().ToTable("Todos");
        }

        public DbSet<Todo> Todos { get; set; }

    }
}
