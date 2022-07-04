using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyAssignment.AuthenticationHandler;
using MyAssignment.Models;
using MyAssignment.Repositories;
using MyAssignment.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyAssignment.Controllers
{
    [Route("api/[controller]")]
  
    [ApiController]
   // [Authorize]
  
    [ExceptionFilter]

    public class ClinicController : BaseController<Clinic>
    {
        public ClinicController(IService<Clinic> repo, ILogger logger, IMapper mapper) : base(repo, logger, mapper)
        {
        }
     
    }
}
