using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyAssignment.Models;
using MyAssignment.Repositories;
using MyAssignment.Services;

namespace MyAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeskStaffController : BaseController<DeskStaff>
    {
        public DeskStaffController(IService<DeskStaff> services) : base(services)
        {
        }
    }
}
