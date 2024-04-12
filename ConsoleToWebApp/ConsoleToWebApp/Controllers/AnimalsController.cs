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
    public class AnimalsController : ControllerBase
    {
        private List<AnimalModel> animals = null;

        public AnimalsController()
        {
            animals = new List<AnimalModel>()
            {
                new AnimalModel(){Id=1,Name="Lion"},
                new AnimalModel(){Id = 2, Name="Giraffe"}
            };
        }


        [Route("", Name = "All")]
        public IActionResult GetAnimals()
        {
            //return Ok("All animals");
            return Ok(animals);
        }

        [Route("test")]
        public IActionResult GetAnimalTest()
        {
            //return Accepted(animals);
            //return Accepted("~/api/animals");
            //return AcceptedAtAction("GetAnimals"); // send Action Method Name
            //return AcceptedAtRoute("All");// we pass the name of our Route
            return LocalRedirect("~/api/animals");
        }

        [Route("{name}")]
        public IActionResult GetAnimalsByName(string name)
        {
            if (!name.Contains("ABC"))
            {
                return BadRequest();
            }
            return Ok(animals);
        }

        [Route("{id:int}")]
        public IActionResult GetAnimalsById(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var animal = animals.FirstOrDefault(x => x.Id == id);

            if(animal == null)
            {
                return NotFound();
            }

            return Ok(animal);
        }

        [HttpPost("")] // http://localhost:25512/api/animals
        public IActionResult GetAnimal(AnimalModel animal)
        {
            animals.Add(animal);
            //return Created("~/api/animals/" + animal.Id, animal);
            return CreatedAtAction("GetAnimalsById",new {id = animal.Id},animal);
        }
    }
}
