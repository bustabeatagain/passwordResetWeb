using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using PasswordResetWeb.Entities;

namespace PasswordResetWeb.Services.SqlServer
{
    public class Persistence : PersistenceBase
    {
        public IConfiguration Configuration { get; }

        public Persistence(IConfiguration configuration)
        {
            this.Configuration = configuration;
            var connectionString = Configuration.GetConnectionString("PasswordWeb");
        }

        public override IEnumerable<School> GetSchoolsByPartialName(string partialName)
        {
            throw new System.NotImplementedException();
        }
    }
}
