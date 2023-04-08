using Repository.Configuration;

namespace Models.Contexts
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<TblCompany>? Companies { get; set; }
        public DbSet<TblEmployee>? Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            
            // base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new CompanyConfiguration()); 
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());

            // modelBuilder.Entity<TblCompany> ( company => // Probar o Preguntar a moody como es
            //     {
            //         company.ToTable("Company","Practica");
            //     }

            // );

        }

    }
}