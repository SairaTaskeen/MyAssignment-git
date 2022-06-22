using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace MyAssignment.AuthenticationHandler

{

    //this class will handle the request that will be coming from the client
    public class BasicAuthHandler : AuthenticationHandler<AuthenticationSchemeOptions>
        // inside the placeholder we are telling the authentication handler that which type of scheme that we are going to use 
    {

        public BasicAuthHandler(IOptionsMonitor<AuthenticationSchemeOptions> options,
            ILoggerFactory logger, 
            UrlEncoder encoder, ISystemClock clock) 
            : base(options, logger, encoder, clock)
        {
        }
        //we are using async here to handle the request asynchronously
        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
            //whenever a request need authentication this method will get called 
        {

            ///// if we have the authorization tag in the header then
            
            return AuthenticateResult.Fail("Need To implement");
        }

    }
}
/*if (!Request.Headers.ContainsKey("Authorization"))
            {
                return AuthenticateResult.Fail("Authorization header was not found");

            }
            //To read the authorization header value from header 
          var authenticationHeaderValue=  AuthenticationHeaderValue.Parse(Request.Headers["Authorization"]);
          var bytes=  Convert.FromBase64String(authenticationHeaderValue.Parameter);
            Encoding.UTF8.GetString(bytes);*/