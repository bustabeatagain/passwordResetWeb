using System.Data.SqlClient;
using PasswordResetWeb.Entities;

namespace PasswordResetWeb.Services.SqlServer
{
    public class SchoolSqlAdapter : SqlAdapter<School>
    {
        public override School CreateFromReader(SqlDataReader reader)
        {
            return new School
            {
                Id = (long)GetByName(reader, "Id"),
                Name = (string)GetByName(reader, "Name")
            };
        }
    }
}