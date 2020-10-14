using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using PasswordResetWeb.Entities;
using PasswordResetWeb.Services;

namespace PasswordResetWeb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SchoolsController : ControllerBase
    {
        public IConfiguration Configuration { get; }
        public PersistenceBase Persistence { get; }
        
        public SchoolsController(IConfiguration configuration, PersistenceBase persistence)
        {
            Configuration = configuration;
            Persistence = persistence;
            var connectionString = Configuration.GetConnectionString("PasswordWeb");
        }

        [HttpGet]
        public IEnumerable<School> Get(string q)
        {
            return Persistence.GetSchoolsByPartialName(q);
        }

        [HttpGet]
        public School GetSchool(int id)
        {
            return null;
        }


    }
}