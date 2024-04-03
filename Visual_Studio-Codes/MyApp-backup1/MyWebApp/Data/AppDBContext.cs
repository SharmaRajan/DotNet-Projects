using Microsoft.EntityFrameworkCore;
using MyWebApp.Models;

namespace MyWebApp.Data
{
    public class AppDBContext : DbContext
	{

		public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
		{

		}

		public DbSet<CategoryModel> Categories { get; set; }

	}
}

