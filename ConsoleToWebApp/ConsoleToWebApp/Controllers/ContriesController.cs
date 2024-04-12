using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleToWebApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleToWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [BindProperties(SupportsGet =true)]
    public class ContriesController : ControllerBase
    {
        //[BindProperty]
        //public string? Name { get; set; }

        //[BindProperty]
        //public int Population { get; set; }

        //[BindProperty]
        //public int Area { get; set; }

        //[BindProperty(SupportsGet =true)]
        public CountryModel Country { get; set; }

        [HttpPost("")]
        //[HttpGet("")]
        public IActionResult AddCountry()
        {

            //return Ok($"Name={this.Name}, Population={this.Population}, Area={this.Area}");
            return Ok($"Name={this.Country.Name}, Population={this.Country.Population}, Area={this.Country.Area}");
        }


    }
}
