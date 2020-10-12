using Microsoft.Extensions.Configuration;
using System.DirectoryServices.AccountManagement;
namespace PasswordResetWeb.Services.ActiveDirectory
{
    public class PasswordManager : PasswordManagerBase
    {
        public IConfiguration Configuration { get; }
        public PasswordManager(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public override void Reset(string userName, string newPassword)
        {
            using(var context = new PrincipalContext(ContextType.Domain, Configuration["ActiveDirectory:HostName"], Configuration["ActiveDirectory:Administrator"], Configuration["ActiveDirectory:Password"]))
            {
                var user = UserPrincipal.FindByIdentity(context, userName);
                user.SetPassword(newPassword);
                user.Save();
            }
        }
    }
}