using Blog.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Blog.DataAccess.Concrete.EntityFramework
{
    public class BlogContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-AQEEA24\MSSQLSERVER03;Database=DenemeBlogu;Trusted_Connection=true");
        }

        public DbSet<Article> Article { get; set; }

    }
}
