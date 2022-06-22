using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyAssignment.Models;
using MyAssignment.Repositories;
using MyAssignment.Services;

namespace MyAssignment.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : BaseController<Doctor>
    {
        public DoctorController(IService<Doctor> services) : base(services)
        {
        }
    }
}
