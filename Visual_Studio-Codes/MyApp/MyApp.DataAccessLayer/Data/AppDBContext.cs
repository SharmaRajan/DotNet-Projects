using Microsoft.EntityFrameworkCore;
using MyApp.Models;

namespace MyApp.DataAccessLayer.Data
{
    public class AppDBContext : DbContext
	{

		public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
		{

		}

		public DbSet<CategoryModel> Categories { get; set; }

	}
}

