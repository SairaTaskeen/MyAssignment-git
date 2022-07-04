using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyAssignment.Models;
using MyAssignment.Services;

namespace MyAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : BaseController<Person>
    {
        public PersonController(IService<Person> repo, ILogger logger, IMapper mapper) : base(repo, logger, mapper)
        {
        }
    }
}
