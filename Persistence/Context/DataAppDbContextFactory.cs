using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;


namespace APIProject.Persistence.Context
{
    public class DataAppDbContextFactory : IDesignTimeDbContextFactory<DataAppDbContext>
    {
        public DataAppDbContext CreateDbContext(string[] args)
        {
            var options = new DbContextOptionsBuilder<DataAppDbContext>();
            options.UseNpgsql("User ID=usuario;Password=1;Host=localhost;Port=5432;Database=banco;");
            return new DataAppDbContext(options.Options);
        }
    }
}