using EcommAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace EcommAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
            public DbSet<Category> Categories {  get; set; }  
    }
}
