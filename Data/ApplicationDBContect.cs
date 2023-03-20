using Microsoft.EntityFrameworkCore;
using MoBooksWeb.Models;

namespace MoBooksWeb.Data
{
    public class ApplicationDBContect:DbContext
    {
        public ApplicationDBContect(DbContextOptions<ApplicationDBContect> options) : base(options)
        {
            
        }
        public DbSet<Category> categories { get; set; }

    }
}
