using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleToWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {

        //[Route("{id:int:min(10)}")] //  value must be greater than 10 // http://localhost:25512/api/books/15
        //public string GetMinById(int id)
        //{
        //    return "Min ID: " + id;
        //}

        //[Route("max/{id:int:min(10):max(100)}")] //  value must be greater than 10 and less than 100 // http://localhost:25512/api/books/max/100
        [Route("{id:int:min(10):max(100)}")] // http://localhost:25512/api/books/90
        public string GetMaxById(int id)
        {
            return "Max ID: " + id;
        }

        [Route("{id:minlength(5):alpha}")] // http://localhost:25512/api/books/991nn
        public string GetIdByString(string id)
        {
            return "String ID: " + id;
        }

        [Route("{id:regex(a(b|c))}")] // a must be followed by b or c
        public string GetIdByRegex(string id)
        {
            return "REgex ID: " + id;
        }
    }
}
