using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Microsoft.Extensions.Configuration;
using PasswordResetWeb.Entities;

namespace PasswordResetWeb.Services.SqlServer
{
    public class Persistence : PersistenceBase
    {
        public IConfiguration Configuration { get; }
        private string ConnectionString { get; }
        public Persistence(IConfiguration configuration)
        {
            Configuration = configuration;
            ConnectionString = Configuration.GetConnectionString("PasswordWeb");
        }

        public override IEnumerable<School> GetSchoolsByPartialName(string partialName)
        {
            using(var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using(var command = new SqlCommand("SELECT * FROM School where Name LIKE @Name", connection))
                {
                    command.Parameters.AddWithValue("@Name", $"%{partialName}%");
                    using(var reader = command.ExecuteReader()) {
                        while(reader.Read())
                        {
                            var id = reader.GetInt32(0);
                            var name = reader.GetString(1);
                            yield return new School {Id = id, Name = name};
                        }
                    }
                }    
            }
            
        }

        public override School GetSchoolById(int id)
        {
            using(var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using(var command = new SqlCommand("SELECT * FROM School where Id = @Id", connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    using(var reader = command.ExecuteReader()) {
                        if(reader.Read())
                        {
                            var name = reader.GetString(1);
                            return new School {Id = id, Name = name};
                        }
                        else
                        {
                            return null;
                        }
                    }
                }    
            }
        }
    }
}
