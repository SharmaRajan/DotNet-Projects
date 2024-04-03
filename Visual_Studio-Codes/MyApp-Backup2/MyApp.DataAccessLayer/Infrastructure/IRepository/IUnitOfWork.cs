using System;
namespace MyApp.DataAccessLayer.Infrastructure.IRepository
{
	public interface IUnitOfWork
	{
		ICategoryRepo Category { get; }

		void Save();
	}
}

