using System;
using MyApp.DataAccessLayer.Data;
using MyApp.DataAccessLayer.Infrastructure.IRepository;

namespace MyApp.DataAccessLayer.Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private AppDBContext _context;
        public ICategoryRepo Category { get; private set; }

        public UnitOfWork(AppDBContext context)
        {
            _context = context;
            Category = new CategoryRepo(context);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}

