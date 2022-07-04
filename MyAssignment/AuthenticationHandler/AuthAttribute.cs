using Microsoft.AspNetCore.Mvc;

namespace MyAssignment.AuthenticationHandler
{
    public class AuthAttribute : TypeFilterAttribute
    {
        public AuthAttribute(string actionName,string roleType) : base(typeof(AuthorizeAction))
        {
            Arguments = new object[]
            {
                actionName,
                roleType
            };
        }
    }
    
}
