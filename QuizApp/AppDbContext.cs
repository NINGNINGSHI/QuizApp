using Microsoft.EntityFrameworkCore;
using QuizApp.Entity;

/**
 * un objet de contexte représente une session avec la base de données, l’objet Context permet
 * l’interrogation et l’enregistrement des données
 */   
namespace QuizApp
{
    public class AppDbContext : DbContext
    {
        public DbSet<Quiz> Quizes { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Score> ScoreBoard { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Question>().HasOne(l => l.Quiz).WithMany(l => l.Questions)
          .HasForeignKey(l => l.QuizId);
            modelBuilder.Entity<Score>().HasOne(l => l.Quiz).WithMany(l => l.ScoreBoard)
          .HasForeignKey(l => l.QuizId);
            modelBuilder.Entity<Answer>().HasOne(l => l.Question).WithMany(l => l.Answers)
          .HasForeignKey(l => l.QuestionId);
        }
    }
}

