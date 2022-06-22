using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyAssignment.Models;
using MyAssignment.Services;

namespace MyAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : BaseController<Person>
    {
        public PersonController(IService<Person> repo) : base(repo)
        {
        }
    }
}
