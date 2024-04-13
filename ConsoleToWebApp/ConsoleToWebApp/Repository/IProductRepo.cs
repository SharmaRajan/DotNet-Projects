using System;
using ConsoleToWebApp.Models;

namespace ConsoleToWebApp.Repository
{
	public interface IProductRepo
	{
         int AddProduct(ProductModel product);

         List<ProductModel> GetAllProducts();

        string GetName();
    }
}

