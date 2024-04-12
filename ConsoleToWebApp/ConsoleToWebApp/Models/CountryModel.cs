using System;
using ConsoleToWebApp.Binder;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleToWebApp.Models
{
    [ModelBinder(typeof(CustomBinderCountryDetails))]
	public class CountryModel
	{
        public int Id { get; set; }

        public string? Name { get; set; }

        public int Population { get; set; }

        public int Area { get; set; }
    }
}

