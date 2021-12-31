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
        public static List<Credential> GetAll()
        {           
            using (MySqlConnection connection = new MySqlConnection(sb.ConnectionString))
            {
                connection.Open();
                using (MySqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM DemoTable";
                    //command.Parameters.AddWithValue("guid", Internal.GetUserGuid());
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        List<Credential> list = new List<Credential>();
                        while (reader.Read())
                        {
                            list.Add(new Credential
                            {
                                Id = reader.GetInt32("Id"),
                                Website = reader.GetString("Website"),
                                Username = reader.GetString("Password"),
                                Notes = reader.GetString("Notes")
                            });
                        }
                        return list;
                    }
                }
            }        
        }
    }
}
