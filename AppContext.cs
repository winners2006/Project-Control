using System.Data.Entity;

namespace Project_Control
{
    class AppContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }

        public AppContext() : base("DefaultConnection") { }
    }
}
