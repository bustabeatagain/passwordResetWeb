using System.Collections.Generic;
using PasswordResetWeb.Entities;

namespace PasswordResetWeb.Services
{
    public abstract class PersistenceBase
    {
        public abstract IEnumerable<School> GetSchoolsByPartialName(string partialName);
    }
}
