using Microsoft.AspNetCore.Mvc;
using MyAssignment.Models;
using MyAssignment.Repositories;
using MyAssignment.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClinicController : BaseController<Clinic>
    {
        public ClinicController(IService<Clinic> services) : base(services)
        {
        }
    }
}
