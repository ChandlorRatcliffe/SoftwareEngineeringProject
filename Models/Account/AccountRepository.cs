using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static CashewWeb.Models.Sql;

using MySql.Data.MySqlClient;


namespace CashewWeb.Models
{
    public class AccountRepository : IAccountRepository
    {
        public AccountRepository()
        {
            
        }

        public IEnumerable<Account> GetAll()
        {
            return null;
        }

        public Account Get(string username)
        {

            Account account;

            string sql = $"SELECT * FROM user WHERE username = @username;";

            try
            {
                using (MySqlConnection sqlConnection = new MySqlConnection(SqlDatabase))
                {
                    using MySqlCommand command = new MySqlCommand(sql, sqlConnection);
                    command.Connection.Open();
                    command.Parameters.AddWithValue("@username", username);

                    using MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        account = new Account
                        {
                            Username = reader["username"].ToString(),
                            FirstName = reader["first name"].ToString(),
                            LastName = reader["last name"].ToString(),
                            Password = reader["password"].ToString(),
                            Email = reader["email"].ToString()
                        };
                    }
                    else
                    {
                        account = null;
                    }
                    sqlConnection.Close();
                }
            }
            catch
            {
                return null;
            }

            return account;
        }

        public Account Add(Account account)
        {
            bool success = false;

            string sql = $"INSERT INTO user (username, `first name`, `last name`, password, email) VALUES (@username, @firstname, @lastname, @password, @email);";

            try
            {
                using (MySqlConnection sqlConnection = new MySqlConnection(SqlDatabase))
                {
                    using MySqlCommand command = new MySqlCommand(sql, sqlConnection);
                    command.Connection.Open();
                    command.Parameters.AddWithValue("@username", account.Username);
                    command.Parameters.AddWithValue("@firstname", account.FirstName);
                    command.Parameters.AddWithValue("@lastname", account.LastName);
                    command.Parameters.AddWithValue("@password", account.Password);
                    command.Parameters.AddWithValue("@email", account.Email);

                    if (command.ExecuteNonQuery() != 0)
                    {
                        success = true;
                    }
                    sqlConnection.Close();
                }
            }
            catch
            {
                return null;
            }

            if (!success)
            {
                //Generate Error
            }

            return account;
        }

    }
}
