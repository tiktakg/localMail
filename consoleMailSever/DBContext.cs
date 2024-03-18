using consoleMailSever.entitys;
using Microsoft.EntityFrameworkCore;




namespace consoleMailSever
{
    public class DBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=TikTakM;Initial Catalog=mailDB;Integrated Security=True;Trust Server Certificate=True");
            }
        }

        public DbSet<users> users { get; set; } = null;
        public DbSet<messenges> msg { get; set; } = null;

    }
}
