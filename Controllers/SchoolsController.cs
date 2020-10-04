using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace passwordResetWeb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SchoolsController : ControllerBase
    {
        public IConfiguration Configuration { get; }
        public SchoolsController(IConfiguration configuration)
        {
            Configuration = configuration;
            var connectionString = Configuration.GetConnectionString("PasswordWeb");
        }

        [HttpGet]
        public string Get()
        {
            return @"[
        {""id"": 1, ""name"": ""Neal""},
        {""id"": 2, ""name"": ""Southern High""},
        {""id"": 3, ""name"": ""Githens""}
    ]";
        }
    }
}