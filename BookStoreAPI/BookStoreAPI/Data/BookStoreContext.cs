using System;
using Microsoft.EntityFrameworkCore;

namespace BookStoreAPI.Data
{
	public class BookStoreContext : DbContext
	{
		// pass options to the base class constructor
		public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options)
		{

		}

		public DbSet<Books> Books { get; set; }

   //     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
   //     {
			//optionsBuilder.UseSqlServer("");
   //         base.OnConfiguring(optionsBuilder);
   //     }
    }
}

