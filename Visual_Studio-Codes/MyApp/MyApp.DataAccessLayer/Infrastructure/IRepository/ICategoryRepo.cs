using System;
using MyApp.Models;

namespace MyApp.DataAccessLayer.Infrastructure.IRepository
{
	public interface ICategoryRepo: IGenericRepo<CategoryModel>
	{
		void Update(CategoryModel category);
	}
}

