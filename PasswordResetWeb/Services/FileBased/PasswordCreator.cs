using System.Text.Json;
using PasswordResetWeb.Entities;
using System.Reflection;
using System.IO;
namespace PasswordResetWeb.Services.FileBased
{
    public class PasswordCreator : PasswordCreatorBase
    {
        private PasswordParts PasswordParts {get;}
        private RandomizerBase Randomizer {get;}
        public PasswordCreator(RandomizerBase randomizer)
        {
            Randomizer = randomizer;
            var assembly = Assembly.GetExecutingAssembly();
            using (var reader = new StreamReader(assembly.GetManifestResourceStream("passwordResetWeb.Services.FileBased.Resources.PasswordParts.json")))
            {
                var json = reader.ReadToEnd();
                PasswordParts = JsonSerializer.Deserialize<PasswordParts>(json) ;   
            }
        }

        public override string Create()
        {
            var subjectIndex = Randomizer.GetInt(0, PasswordParts.Subjects.Length);
            var actionIndex = Randomizer.GetInt(0, PasswordParts.Actions.Length);
            var locationIndex = Randomizer.GetInt(0, PasswordParts.Locations.Length);
            return $"{PasswordParts.Subjects[subjectIndex]} {PasswordParts.Actions[actionIndex]} {PasswordParts.Locations[locationIndex]}";
        }
    }
}