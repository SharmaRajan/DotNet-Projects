using EComm.Models;
using Microsoft.AspNetCore.Mvc;

namespace EComm.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoryController : ControllerBase
{
    private List<Category> listOfCategories = new List<Category>
    {
        new Category{Id = 1, Title = "Samsung", DisplayOrder = 1},
        new Category{Id = 2, Title = "Motorola", DisplayOrder = 2},
        new Category{Id = 3, Title = "Nokia", DisplayOrder = 3},
        new Category{Id = 4, Title = "Apple", DisplayOrder = 4},
        new Category{Id = 5, Title = "LG", DisplayOrder = 5}
    };

    [HttpGet]
    public IEnumerable<Category> Get()
    {
        return listOfCategories;
    }

    [HttpPost]
    public void Post([FromBody]Category category)
    {
        listOfCategories.Add(category);
    }


    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Category category)
    {
        listOfCategories[id] = category;
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
        listOfCategories.RemoveAt(id);
    }
}