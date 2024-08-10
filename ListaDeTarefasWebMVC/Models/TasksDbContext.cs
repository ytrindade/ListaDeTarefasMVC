using Microsoft.EntityFrameworkCore;

namespace ListaDeTarefasWebMVC.Models
{
    public class TasksDbContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }

        public TasksDbContext(DbContextOptions<TasksDbContext>options) : base(options)
        {
            
        }
    }
}
