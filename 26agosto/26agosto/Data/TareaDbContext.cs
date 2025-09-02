using Microsoft.EntityFrameworkCore;
using _26agosto.Models;

namespace _26agosto.Data
{
    public class TareaDbContext : DbContext
    {
        public TareaDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Tarea> Tareas { get; set; }
        protected TareaDbContext()
        {
        }
    }
}
