using Microsoft.EntityFrameworkCore;

namespace WebApplication3.Models
{
    public class BlogContext : DbContext
    {
     
 
        public DbSet<Blog> Blogs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>().HasData(
                new Blog
                {
                    Id = 1,
                    Name = "Food Blog",
                    Url = "https://www.myfood.eat"
                }
            );
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source =asp.dp");
            base.OnConfiguring(optionsBuilder);
        }
       
    }

}




