using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyAssignment.Models;
using MyAssignment.Repositories;
using MyAssignment.Services;

namespace MyAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : BaseController<Patient>
    {
        public PatientController(IService<Patient> repo, ILogger logger, IMapper mapper) : base(repo, logger, mapper)
        {
        }
    }
}
