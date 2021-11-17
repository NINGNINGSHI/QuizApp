using Microsoft.EntityFrameworkCore;

namespace QuizApp
{
	public class AppDbContext : DbContext
	{
		public DbSet<Quiz> Quizes { get; set; }
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{
		}
    }
}

