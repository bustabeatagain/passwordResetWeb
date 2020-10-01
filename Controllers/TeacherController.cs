using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace passwordResetWeb.Controllers
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