using System.Text.Json;
using PasswordResetWeb.Entities;
using System.Reflection;
using System.IO;
namespace PasswordResetWeb.Services.FileBased
{
    public class PasswordCreator : PasswordCreatorBase
    {
        private PasswordParts PasswordParts {get;}
        public PasswordCreator()
        {
            var assembly = Assembly.GetExecutingAssembly();
            using (var reader = new StreamReader(assembly.GetManifestResourceStream("PasswordResetWeb.Services.FileBased.Resources.PasswordParts.json")))
            {
                var json = reader.ReadToEnd();
                PasswordParts = JsonSerializer.Deserialize<PasswordParts>(json) ;   
            }
            
        }

        public override string Create()
        {
            throw new System.NotImplementedException();
        }
    }
}