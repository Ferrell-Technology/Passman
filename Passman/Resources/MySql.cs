using MySql.Data.MySqlClient;
using Passman.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passman.Resources
{
    internal class MySql
    {
        private static readonly MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder
        {
            Server = "ferrelltechnology.com",
            UserID = "ferrellt_psmnusr",
            Password = "923b*&65b92-B&7PB pqnq aw48^$v 2;b 9a23h^%(qcN3028521VLhgfr^jq92^$#(w2b2-B%",
            Port = 3306,
            Database = "ferrellt_passman"
        };
        public static List<ICredential> GetAll()
        {           
            using (MySqlConnection connection = new MySqlConnection(sb.ConnectionString))
            {
                connection.Open();
                using (MySqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM DemoTable";
                    //command.Parameters.AddWithValue("@guid", Internal.GetUserGuid());
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        List<ICredential> list = new List<ICredential>();
                        while (reader.Read())
                        {
                            list.Add(new WebsiteCredential
                            {
                                Id = reader.GetInt32("Id"),
                                Website = reader.GetString("Website"),
                                Username = reader.GetString("Username"),
                                Password = reader.GetString("Password"),
                                Notes = reader.GetString("Notes")
                            });
                        }
                        return list;
                    }
                }
            }        
        }
        public static void Add(ICredential credential)
        {
            using (MySqlConnection connection = new MySqlConnection(sb.ConnectionString))
            {
                connection.Open();
                using (MySqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO DemoTable(Website, Username, Password, Notes, Type) VALUES (@website, @username, @password, @notes, @type)";
                    //command.Parameters.AddWithValue("@guid", Internal.GetUserGuid());
                    command.Parameters.AddWithValue("@website", credential.Website);
                    command.Parameters.AddWithValue("@username", credential.Username);
                    command.Parameters.AddWithValue("@password", credential.Password);
                    command.Parameters.AddWithValue("@notes", credential.Notes);
                    command.Parameters.AddWithValue("@type", credential.Type.ToString());
                    command.ExecuteNonQuery();
                }
            }
        }
        public static void Update(ICredential newCredential)
        {
            using (MySqlConnection connection = new MySqlConnection(sb.ConnectionString))
            {
                connection.Open();
                using (MySqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "UPDATE DemoTable SET Website = @website, Username = @username, Password = @password, Notes = @notes, Type = @type WHERE Id = @id";
                    //command.Parameters.AddWithValue("@guid", Internal.GetUserGuid());
                    command.Parameters.AddWithValue("@id", newCredential.Id);
                    command.Parameters.AddWithValue("@website", newCredential.Website);
                    command.Parameters.AddWithValue("@username", newCredential.Username);
                    command.Parameters.AddWithValue("@password", newCredential.Password);
                    command.Parameters.AddWithValue("@notes", newCredential.Notes);
                    command.Parameters.AddWithValue("@type", newCredential.Type.ToString());
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
