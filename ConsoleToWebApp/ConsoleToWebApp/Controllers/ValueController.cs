using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleToWebApp.Controllers
{
    //[Route("api/[controller]")]
    [Route("[controller]/[action]")]
    [ApiController]
    public class ValueController : ControllerBase
    {
        //[Route("api/get-all")]
        //[Route("~/get-all")] //http://localhost:25512/get-all
        [Route("~/getall")] // http://localhost:25512/getall
        //[Route("[controller]/[action]")] // value/getall
        public string GetAll()
        {
            return "Hello from Value Controller GetAll()";
        }

        //[Route("api/get-authors")]
        //[Route("[controller]/[action]")]
        public string GetAllAuthors()
        {
            return "Hello from Value Controller GetAllAuthors()";
        }

        //[Route("books/{id}")]
        //[Route("[controller]/[action]")]
        [Route("{id}")]
        public string GetById(int id)
        {
            return "ID: " + id;
        }

        //[Route("books/{id}/author/{authorId}")]
        public string GetAuthorAddressById(int id,int authorId)
        {
            return "ID: " + id + " author: " + authorId;
        }

        //[Route("search")]
        public string SearchBooks(int id, int authorId, string name, int rating, int price)
        {
            return "ID: " + id + " author: " + authorId + " name: "+ name;
        }

    }
}
