using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleToWebApp.Models;
using ConsoleToWebApp.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleToWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        //public string GetEmployees() {
        //    return "All employees";
        //}

        //public EmployeeModel GetEmployee() {
        //    return new EmployeeModel() { Id = 1, Name = "Rajan" };
        //}

        //public List<EmployeeModel> GetEmployee()
        //{
        //    return new List<EmployeeModel>() {
        //        new EmployeeModel() {Id = 1, Name = "Rajan" },
        //        new EmployeeModel() {Id = 2, Name = "Abhishek"}
        //    };
        //}

        [Route("")]
        public IEnumerable<EmployeeModel> GetEmployee()
        {
            return new List<EmployeeModel>() {
                new EmployeeModel() {Id = 1, Name = "Rajan" },
                new EmployeeModel() {Id = 2, Name = "Abhishek"}
            };
        }

        // dealing with the async programming
        //public IAsyncEnumerable<EmployeeModel> GetEmployee()
        //{
        //    List<EmployeeModel> employeeModels = new List<EmployeeModel>() {
        //        new EmployeeModel() {Id = 1, Name = "Rajan" },
        //        new EmployeeModel() {Id = 2, Name = "Abhishek"}
        //    };
        //    return (IAsyncEnumerable<EmployeeModel>) employeeModels;
        //}

        [Route("{id}")]
        public IActionResult GetEmployees(int id)
        {
            if(id == 0)
            {
                return NotFound();
            }

            return Ok(new List<EmployeeModel>() {
                new EmployeeModel() {Id = 1, Name = "Rajan" },
                new EmployeeModel() {Id = 2, Name = "Abhishek"}
            });
        }

        [Route("{id}/basic")] // http://localhost:25512/api/employee/2/basic
        public ActionResult<EmployeeModel> GetEmployeesBasicDetails(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            //return Ok(new List<EmployeeModel>() {
            //    new EmployeeModel() {Id = 1, Name = "Rajan" },
            //    new EmployeeModel() {Id = 2, Name = "Abhishek"}
            //});
            return new EmployeeModel() { Id = id, Name = "Rajan" };
        }

        [HttpGet("name")]
        public IActionResult GetName([FromServices] IProductRepo _productRepo)
        {

            var name = _productRepo.GetName();
            return Ok(name);
        }
    }
}
