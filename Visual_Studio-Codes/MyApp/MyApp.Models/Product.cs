using System;
using System.ComponentModel.DataAnnotations;

namespace MyApp.Models
{
	public class Product
	{
		public int Id { get; set; }

		[Required]
		public string? Name { get; set; }

        [Required]
        public string? description { get; set; }

        [Required]
        public double Price { get; set; }

		public string? ImageUrl { get; set; }

		public int CategoryId { get; set; }

		public required CategoryModel Category { get; set; }


	}
}

