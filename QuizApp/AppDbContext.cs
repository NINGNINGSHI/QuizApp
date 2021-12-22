using Microsoft.EntityFrameworkCore;
using QuizApp.Entity;

//un objet de contexte représente une session avec la base de données, l’objet Context permet
//l’interrogation et l’enregistrement des données
namespace QuizApp
{
	public class AppDbContext : DbContext
	{
		public DbSet<Quiz> Quizes { get; set; }
		public DbSet<Question> Questions { get; set; }
		public DbSet<Answer> Answers { get; set; }

		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{
		}
    }
}

