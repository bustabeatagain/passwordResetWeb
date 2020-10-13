using System.Collections.Generic;
using System.Data.SqlClient;

namespace PasswordResetWeb.Services.SqlServer
{
    public abstract class SqlAdapter<T>
    {
        public abstract T CreateFromReader(SqlDataReader reader);
        protected object GetByName(SqlDataReader reader, string name)
        {
            return reader.GetValue(reader.GetOrdinal(name));
        }
        public IEnumerable<T> CreateAllFromReader(SqlDataReader reader)
        {
            while(reader.Read())
            {
                yield return CreateFromReader(reader);
            }
        }
    }
}