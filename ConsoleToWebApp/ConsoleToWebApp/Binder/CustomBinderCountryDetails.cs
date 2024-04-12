using System;
using ConsoleToWebApp.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ConsoleToWebApp.Binder
{
    public class CustomBinderCountryDetails : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            //throw new NotImplementedException();
            var modelName = bindingContext.ModelName;

            var value = bindingContext.ValueProvider.GetValue(modelName);

            var result = value.FirstValue;

            if(!int.TryParse(result, out var id))
            {
                return Task.CompletedTask;
            }

            // get data from DB but right now it is hard coded
            var model = new CountryModel()
            {
                Id = id,
                Name = "India",
                Area = 400,
                Population = 9801
            };

            bindingContext.Result = ModelBindingResult.Success(model);

            return Task.CompletedTask;
        }
    }
}

