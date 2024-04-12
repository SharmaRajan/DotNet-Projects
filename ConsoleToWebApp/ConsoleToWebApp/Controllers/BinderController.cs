using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleToWebApp.Binder;
using ConsoleToWebApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleToWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BinderController : ControllerBase
    {

        [HttpGet("")] // query string
        //[HttpGet("{name}/{area}")] // Route
        public IActionResult AddCountry(string name)
        {
            return Ok($"Name = {name}");
        }

        [HttpPost("")]
        //[HttpGet("{name}/{area}")] // Route
        public IActionResult AddCountryModel(CountryModel country)
        {
            return Ok($"Name = {country.Name}, Population = {country.Population}");
        }

        [HttpPost("query")]
        public IActionResult AddCountryFromQuery([FromQuery]CountryModel country)
        {
            return Ok($"Name = {country.Name}, Population = {country.Population}");
        }

        //[HttpPost("route/{name}")]
        [HttpPost("route/{name}/{Population}/{Area}")]
        //public IActionResult AddCountryFromRoute([FromRoute] string name)
        public IActionResult AddCountryFromRoute([FromRoute] CountryModel country, [FromQuery] int id)
        {
            return Ok($"Id = {id},Name = {country.Name}, Population = {country.Population}");
            //return Ok($"Name = {name}");
        }

        [HttpPost("body/{id}")]
        public IActionResult AddCountryFromBody([FromBody] int id)
        {
            //return Ok($"Id = {id},Name = {country.Name}, Population = {country.Population}");
            return Ok($"Id = {id}");
        }

        [HttpPost("form")]
        public IActionResult AddCountryFromForm([FromForm] int id)
        {
            //return Ok($"Id = {id},Name = {country.Name}, Population = {country.Population}");
            return Ok($"Id = {id}");
        }

        [HttpPost("header")]
        public IActionResult AddCountryFromHeader([FromHeader] string developer)
        {
            //return Ok($"Id = {id},Name = {country.Name}, Population = {country.Population}");
            return Ok($"name = {developer}");
        }

        // Custom Model Binder
        [HttpGet("search")]
        public IActionResult SearchCountries([ModelBinder(typeof(CustomBinder))]string[] countries)
        {
            return Ok(countries);
        }

        [HttpGet("custom/{id}")]
        public IActionResult CountryDetails([ModelBinder(Name = "Id")] CountryModel country)
        {
            return Ok(country);
        }
    }
}
