using Microsoft.EntityFrameworkCore;
using System;

public class AppDbContext : DbContext
{
	public DbSet<Quiz>Quizzes { get; set; }
	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
	{
	}

}
