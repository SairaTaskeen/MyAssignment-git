using System;
using System.Net;
using System.Net.Http;
using System.Web.Http.Filters;

namespace MyAssignment.AuthenticationHandler
{
    public class ExceptionFilter:ExceptionFilterAttribute   
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            HttpStatusCode httpStatusCode = HttpStatusCode.InternalServerError;
            string message = string.Empty;
            var erroType = actionExecutedContext.GetType();
            if (erroType == typeof(NullReferenceException))
            {
                message = "Id can not be null.";
                httpStatusCode = HttpStatusCode.BadRequest;
            }
            if (erroType == typeof(TimeZoneNotFoundException))
            {
                message = "TimeZone Not Found.";
                httpStatusCode = HttpStatusCode.NotFound;
            }
            if (erroType == typeof(MissingFieldException))
            {
                message = "Field is missing.";
                httpStatusCode = HttpStatusCode.NotAcceptable;
            }
            else
            {
                message = "Internal server Error";
                httpStatusCode = HttpStatusCode.InternalServerError;
            }
            var response = new HttpResponseMessage(httpStatusCode)
            {
                Content = new StringContent(message),
                ReasonPhrase = "From Exception Filters"

            };
            actionExecutedContext.Response = response;
        }

    }
}
