using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Connections;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.IO;

namespace MyAssignment.Log
{
    public class FilterClass : IActionFilter

    {
        protected string Name;
        public FilterClass(string name)
        {
            this.Name = name;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine($"Action executed   {Name}");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine($"Action executing   {Name}");
        }
    }

}
