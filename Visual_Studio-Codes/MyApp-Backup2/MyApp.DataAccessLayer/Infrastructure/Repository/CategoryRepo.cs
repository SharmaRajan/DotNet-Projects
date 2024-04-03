using System;
using MyApp.DataAccessLayer.Data;
using MyApp.DataAccessLayer.Infrastructure.IRepository;
using MyApp.Models;

namespace MyApp.DataAccessLayer.Infrastructure.Repository
{
    public class CategoryRepo : GenericRepo<CategoryModel>, ICategoryRepo
    {
        private readonly AppDBContext _context;

        public CategoryRepo(AppDBContext context) : base(context)
        {
            _context = context;
        }

        public void Update(CategoryModel category)
        {
            _context.Categories.Update(category);
        }
    }
}

