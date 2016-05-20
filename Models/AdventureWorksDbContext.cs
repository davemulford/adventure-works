using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace WebApp.Models
{
	public class AdventureWorksDbContext : DbContext
	{
		public DbSet<Department> Departments { get; set; }
		public DbSet<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; }
		public DbSet<Employee> Employees { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);

			// Get a ConfigurationBuilder object with environment variables so we can pull the connection string
			var builder = new ConfigurationBuilder();
			var configuration = builder
				.AddEnvironmentVariables()
				.Build();

			optionsBuilder.UseNpgsql(configuration["AW_CONNSTRING"]);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<EmployeeDepartmentHistory>()
				.HasKey(h => new { h.BusinessEntityID, h.DepartmentID, h.Shift, h.StartDate });
		}
	}
}
