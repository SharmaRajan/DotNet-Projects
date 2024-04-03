using System;
using System.Linq.Expressions;

namespace MyApp.DataAccessLayer.Infrastructure.IRepository
{
	public interface IGenericRepo<T> where T : class
	{
		IEnumerable<T> GetAll();

        T GetT(Expression<Func<T, bool>> predicate);

		void Add(T entity);

		void Delete(T entity);

		//IEnumerable means multiple lists can come from one class

		void DeleteRange(IEnumerable<T> entity);
	}
}

