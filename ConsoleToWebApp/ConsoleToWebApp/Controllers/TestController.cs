using System;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleToWebApp.Controllers
{
	[ApiController]
	[Route("test")]
	public class TestController : ControllerBase
	{

		public string Get()
		{
			return "Hello from GET";
		}

        public string Get1()
        {
            return "Hello from GET1";
        }

    }
}

