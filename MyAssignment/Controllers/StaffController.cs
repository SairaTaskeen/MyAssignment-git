using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyAssignment.Models;
using MyAssignment.Repositories;
using MyAssignment.Services;

namespace MyAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : BaseController<Staff>
    {
        public StaffController(IService<Staff> services) : base(services)
        {
        }
    }
}
