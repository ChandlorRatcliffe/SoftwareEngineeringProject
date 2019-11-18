using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Data;


namespace DatabasePopulation
{

    public class SQLInterface
    {
        // You may need to change "port" in the string below to reflect the port you used in the initial setup.
        string connStr = "server=shsuse.mysql.database.azure.com;user=cashewclub@shsuse;database=shsuse;port=3306;password=D1ipDan*gDelux5e";
        MySqlConnection conn;
        WordListManager words;

        public SQLInterface()
        {
            //Establish connection path to the database. 
            conn = new MySqlConnection(connStr);
            this.words = new WordListManager();
        }

        //Send a query wholesale to the server, and get back the raw data from its use. 
        private List<List<string>> query(string q)
        {
            //Create storage container for query result:
            List<List<string>> result = new List<List<string>>();
            //Create storage container for each row of the query:
            List<string> row = new List<string>();

            //The connection attempt could fail, so try catch is used. 
            try
            {
                //Attempt to connect to the database. 
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();

                //Once connected, package and send the query to the database. 
                MySqlCommand cmd = new MySqlCommand(q, conn);
                //Unpack the result from the database. 
                MySqlDataReader rdr = cmd.ExecuteReader();

                //For each row in the unpacked result, do the following:
                while (rdr.Read())
                {
                    //Create a new row to be added to the result list. 
                    row = new List<string>();
                    // for each element in the row of the result:
                    for (int i = 0; i < rdr.FieldCount; i++)
                    {
                        // Add it to the row as a string.
                        row.Add(rdr[i].ToString());
                    }
                    //Add each complete row to the overall container.
                    result.Add(row);
                }
                //IMPORTANT: Close the resulting temporary output from the database.
                rdr.Close();
            }
            //If for some reason the connection failed, display the exception in the console and continue the program. 
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            //IMPORTANT: Close the connection to the server! If we failed to connect, it
            // will do nothing. If we connected, we must close the connection. We're done for now.
            conn.Close();

            //Give the result to whatevr requested it.
            return result;
        }
        //Print a query directly to console. 
        private void print_query(string s)
        {
            //Submit the query to the server.
            List<List<string>> result = query(s);
            Console.WriteLine(s);

            //Break the query into columns and rows for output, and output on the fly.
            for (int i = 0; i < result.Count; i++)
            {
                for (int j = 0; j < result.ElementAt(i).Count; j++)
                {
                    Console.Write(result.ElementAt(i).ElementAt(j) + "\t, ");
                }
                Console.WriteLine();
            }
        }
        //This generates a string identical to that which would be produced in the console by print_query. 
        private string query_to_string(string s)
        {
            string output = "";
            //Submit the query to the server. 
            List<List<string>> result = query(s);

            //Generate a string in the same manner as would be used for printing the query results to the console. 
            for (int i = 0; i < result.Count; i++)
            {
                for (int j = 0; j < result.ElementAt(i).Count; j++)
                {
                    output += result.ElementAt(i).ElementAt(j) + "\t, ";
                }
                output += "\n";
            }

            //Give the string to whatever asked for it.
            return output;
        }
        public void generateAccounts(int number)
        {
            //Create an account generator
            AccountGenerator ag = new AccountGenerator(this.words);
            //generate as  many accounts as possible
            List<Account> accounts = ag.generateAccounts(number);
            //Begin query string generation
            string queryString = "insert into account(Username, Email, FirstName, LastName, Password, Skills, Theme, PicturePath) values ";
            //populate the values of the querystring
            foreach (Account account in  accounts){
                queryString += account.getAddTupleQuerryString() + ",";
            }
            //replace the last comma with a semi colon. 
            queryString = queryString.Substring(0,queryString.Length-1)+";";
            //submit the query.
            query(queryString);
        }
        public void generateOrganizations(int number)
        {
            //Create an organization generator
            OrganizationGenerator org = new OrganizationGenerator(this.words);
            //generate as  many organizations as possible
            List<Organization> organizations = org.generateOrganizations(number);
            //Begin query string generation
            string queryString = "insert into organization(Name, License, Activation, Expiration) values ";
            //populate the values of the querystring
            foreach (Organization organization in organizations)
            {
                queryString += organization.getAddTupleQuerryString() + ",";
            }
            //replace the last comma with a semi colon. 
            queryString = queryString.Substring(0, queryString.Length - 1) + ";";
            //submit the query.
            query(queryString);
        }
        public void reset()
        {
            query("delete from organization where name != '';delete from account where username != '';            insert into account(Username, Email, FirstName, LastName, Password, Skills, Theme, PicturePath) values            ('un', 'someEmail@bullshit.com', 'Travis', 'Idlay', 'nope', '', '', ''); ");
        }
    }
    
}