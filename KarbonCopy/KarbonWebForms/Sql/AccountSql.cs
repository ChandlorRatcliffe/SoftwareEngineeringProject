using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace KarbonWebForms.Sql
{
    public class AccountSql
    {
        private readonly MySqlFunctions functions = new MySqlFunctions();
        private readonly string Table = "account";

        /// <summary>
        /// Inserts Account into Sql Database
        /// </summary>
        /// <param name="account">Account Object</param>
        public void Insert(Account account)
        {
            if (!Exists(account.Username))
            {
                string query =
                    $"INSERT INTO {Table} (Username, Email, FirstName, LastName, Password, Skills, Theme, Picturepath)" +
                    $" VALUES(@username, @email, @firstname, @lastname, @password, @skills, @theme, @picturepath);";

                List<MySqlParameter> parameters = new List<MySqlParameter>
                {
                    new MySqlParameter("username", MySqlDbType.VarChar) { Value = account.Username },
                    new MySqlParameter("email", MySqlDbType.VarChar) { Value = account.Email },
                    new MySqlParameter("firstname", MySqlDbType.VarChar) { Value = account.FirstName },
                    new MySqlParameter("lastname", MySqlDbType.VarChar) { Value = account.LastName },
                    new MySqlParameter("password", MySqlDbType.VarChar) { Value = account.Password },
                    new MySqlParameter("skills", MySqlDbType.VarChar) { Value = account.Skills },
                    new MySqlParameter("theme", MySqlDbType.VarChar) { Value = account.Theme },
                    new MySqlParameter("picturepath", MySqlDbType.VarChar) { Value = account.Picturepath }
                };

                if (functions.ExecuteNonQuery(query, parameters))
                {
                    Debug.WriteLine("InsertAccount: The account was added successfully.");
                }
                else
                {
                    Debug.WriteLine("InsertAccount: An error has occured.");
                }
            }
        }

        /// <summary>
        /// Updates a field of Account Sql Table
        /// </summary>
        /// <param name="username">PrimaryKey</param>
        /// <param name="field">Column</param>
        /// <param name="fieldValue">Column new Value</param>
        public void Update(string username, string field, string fieldValue)
        {
            if (Exists(username))
            {
                string query = $"UPDATE {Table} SET {field} = @value WHERE (Username = @username);";

                List<MySqlParameter> parameters = new List<MySqlParameter>
                {
                    new MySqlParameter("value", MySqlDbType.VarChar) { Value = fieldValue },
                    new MySqlParameter("username", MySqlDbType.VarChar) { Value =  username}
                };

                if (functions.ExecuteNonQuery(query, parameters))
                {
                    Debug.WriteLine("UpdateAccount: The account was updated successfully.");
                }
                else
                {
                    Debug.WriteLine("UpdateAccount: An error has occured.");
                }
            }
        }

        /// <summary>
        /// Delete Account using Username
        /// </summary>
        /// <param name="username"></param>
        public void Delete(string username)
        {
            DeleteAccount(new Account(username));
        }

        /// <summary>
        /// Delete Account using Account Object
        /// </summary>
        /// <param name="account"></param>
        public void DeleteAccount(Account account)
        {
            if (Exists(account.Username))
            {
                string query = $"DELETE FROM {Table} WHERE Username = @username;";

                List<MySqlParameter> parameters = new List<MySqlParameter>
                {
                    new MySqlParameter("username", MySqlDbType.VarChar) { Value = account.Username }
                };

                if (functions.ExecuteNonQuery(query, parameters))
                {
                    Debug.WriteLine("DeleteAccount: The account was deleted successfully.");
                }
                else
                {
                    Debug.WriteLine("DeleteAccount: An error has occured.");
                }
            }
            else
            {
                Debug.WriteLine("DeleteAccount: Cannot delete account");
            }
        }

        /// <summary>
        /// Get Account Object From Sql Database
        /// </summary>
        /// <param name="username">Primary Key</param>
        /// <returns>Account Object</returns>
        public Account Get(string username)
        {
            if (Exists(username))
            {
                string query =
                    $"SELECT Username, Email, FirstName, LastName, Password, Skills, Theme, Picturepath " +
                    $"FROM {Table} WHERE(Username = @username)";

                List<MySqlParameter> parameters = new List<MySqlParameter>
                {
                    new MySqlParameter("username", MySqlDbType.VarChar) { Value = username }
                };

                if (functions.ExecuteReader(query, parameters, out DataTable dataTable))
                {
                    DataRow row = dataTable.Rows[0];
                    Account account = new Account
                    {
                        Username = row["username"].ToString(),
                        Email = row["email"].ToString(),
                        FirstName = row["firstname"].ToString(),
                        LastName = row["lastname"].ToString(),
                        Password = row["password"].ToString(),
                        Skills = row["skills"].ToString(),
                        Theme = row["theme"].ToString(),
                        Picturepath = row["picturepath"].ToString()
                    };
                    return account;
                }
                else
                {
                    Debug.WriteLine("GetAccount: An error has occured while trying to get account.");
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Get All Entries of Account Table
        /// </summary>
        /// <returns>List of Account Objects</returns>
        public List<Account> GetAll()
        {
            string query =
                $"SELECT Username, Email, FirstName, LastName, Password, Skills, Theme, Picturepath FROM {Table};";
            if (functions.ExecuteReader(query, null, out DataTable dataTable))
            {
                List<Account> accounts = new List<Account>();
                foreach (DataRow row in dataTable.Rows)
                {
                    accounts.Add(new Account
                    {
                        Username = row["username"].ToString(),
                        Email = row["email"].ToString(),
                        FirstName = row["firstname"].ToString(),
                        LastName = row["lastname"].ToString(),
                        Password = row["password"].ToString(),
                        Skills = row["skills"].ToString(),
                        Theme = row["theme"].ToString(),
                        Picturepath = row["picturepath"].ToString()
                    });
                }
                return accounts;
            }
            else
            {
                Debug.WriteLine("GetAllAccounts: An error has occured while trying to get all accounts.");
                return null;
            }
        }

        /// <summary>
        /// Checks if an Account Exists using Username 
        /// </summary>
        /// <param name="keyValue">Primary Key</param>
        /// <returns></returns>
        public bool Exists(string keyValue)
        {
            if (functions.CheckExists(Table, "username", keyValue))
            {
                Debug.WriteLine($"Exists: The account exists with username: {keyValue}.");
                return true;
            }
            else
            {
                Debug.WriteLine($"Exists: The account doesn't exists with username: {keyValue}.");
                return false;
            }
        }

        /// <summary>
        /// Authenticates a User against the Sql Database
        /// </summary>
        /// <param name="username">Primary Key</param>
        /// <param name="password">Passphrase</param>
        /// <returns></returns>
        public bool Authenticate(string username, string password)
        {
            if (Exists(username))
            {
                Debug.WriteLine($"Exists: The account exists with username: {username}.");
                List<CheckValuePair> checkList = new List<CheckValuePair>()
                {
                    new CheckValuePair("Username", username),
                    new CheckValuePair("Password", password)
                };

                if (functions.CheckExists("account", checkList))
                {
                    Debug.WriteLine($"Authenicate: The account has been authenticated.");
                    return true;
                }
                else
                {
                    Debug.WriteLine($"Authenicate: The account could NOT be authenticated.");
                    return false;
                }
            }
            else
            {
                Debug.WriteLine($"Authenicate: The account doesn't exists with username: {username}.");
                return false;
            }
        }
    }
}
