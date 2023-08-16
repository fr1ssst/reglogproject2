using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginRegisterFormsApp
{
    class GetHashedPassword
    {
        public string GetHashedPasswordFromDatabase(string loginUser)
        {
            DataBase dataBase = new DataBase();

            dataBase.openConnection();

            MySqlCommand command = new MySqlCommand("SELECT password FROM users WHERE login = @Username", dataBase.getConnection());
            command.Parameters.AddWithValue("@Username", loginUser);

            object result = command.ExecuteScalar();
            if (result != null)
            {
                return result.ToString();
            }
            else
            {
                return null;
            }
        }
    }
}
