using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static CashewWeb.Models.Sql;

using MySql.Data.MySqlClient;
using System.Diagnostics;

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
            Account account = new Account();

            using (MySqlConnection sqlConnection = new MySqlConnection(SqlDatabase))
            {
                MySqlCommand command = sqlConnection.CreateCommand();
                command.CommandText = $"SELECT * FROM user WHERE username = @username;";
                command.Parameters.AddWithValue("@username", username);
                try
                {
                    command.Connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
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
                        Debug.WriteLine($"Unable To Read Account from Database. No Error Generated.");
                    }
                    reader.Dispose();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"{ex.Message}");
                }
                finally
                {
                    command.Dispose();
                }
            }

            return account;
        }

        public Account Add(Account account)
        {
            using (MySqlConnection sqlConnection = new MySqlConnection(SqlDatabase))
            {
                MySqlCommand command = sqlConnection.CreateCommand();
                command.CommandText = $"INSERT INTO user (username, `first name`, `last name`, password, email) VALUES (@username, @firstname, @lastname, @password, @email);";
                command.Parameters.AddWithValue("@username", account.Username);
                command.Parameters.AddWithValue("@firstname", account.FirstName);
                command.Parameters.AddWithValue("@lastname", account.LastName);
                command.Parameters.AddWithValue("@password", account.Password);
                command.Parameters.AddWithValue("@email", account.Email);
                try
                {
                    command.Connection.Open();
                    if (command.ExecuteNonQuery() == 0)
                    {
                        Debug.WriteLine($"-----Unable To Insert Add Account to Database. No Error Generated.");
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"-----{ex.Message}");
                    return null;
                }
                finally
                {
                    command.Dispose();
                }
            }
            return account;
        }

    }
}
