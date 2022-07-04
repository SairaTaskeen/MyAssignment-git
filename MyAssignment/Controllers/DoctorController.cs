using AutoMapper;
using Microsoft.AspNetCore.Authorization;
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
    public class DoctorController : BaseController<Doctor>
    {
        public DoctorController(IService<Doctor> repo, ILogger logger, IMapper mapper) : base(repo, logger, mapper)
        {
        }
    }
}
