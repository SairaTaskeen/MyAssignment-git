using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyAssignment.Models;
using MyAssignment.Repositories;
using MyAssignment.Services;

namespace MyAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : BaseController<Patient>
    {
        public PatientController(IService<Patient> services) : base(services)
        {
        }
    }
}
