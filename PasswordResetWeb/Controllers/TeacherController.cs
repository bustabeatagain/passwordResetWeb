using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace PasswordResetWeb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeacherController : ControllerBase
    {
        public IConfiguration Configuration { get; }
        public TeacherController(IConfiguration configuration)
        {
            Configuration = configuration;
            var connectionString = Configuration.GetConnectionString("PasswordWeb");
        }

        [HttpGet]
        public string Get()
        {
            return "Teacher";
        }
    }
}