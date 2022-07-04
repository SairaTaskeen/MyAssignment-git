using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Threading.Tasks;

namespace MyAssignment.Log
{
    public class AsyncFilters: Attribute, IAsyncActionFilter
    {
        protected string name;
        public AsyncFilters(string name)
        {
            this.name = name;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            Console.WriteLine("Before Execution");
            await next();
            Console.WriteLine("After Execution");
        }
    }
}

