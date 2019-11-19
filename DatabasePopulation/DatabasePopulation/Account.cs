using System;
using System.Collections.Generic;
using System.Text;

namespace DatabasePopulation
{
    public class Account
    {
        string username;
        string email;
        string firstName;
        string lastName;
        string password;
        string skills;
        string theme;
        string picturePath;
        public Account(string firstName, string lastName, string password)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.password = password;
            this.username = firstName.Substring(0,5) + lastName.Substring(0, 5);
            this.email = username + "@notreal.com";
            this.theme = "";
            this.picturePath = "";
        }
        public void setTheme(string theme)
        {
            this.theme = theme;
        }

        public void setSkills(string skills)
        {
            this.skills = skills;
        }
        public void setPicturePath(string picturePath)
        {
            this.picturePath = picturePath;
        }
        public string getAddTupleQuerryString()
        {
            return "(\""+username + "\",\"" + email + "\",\"" + firstName + "\",\"" + lastName + "\",\"" +  password + "\",\""  +  skills + "\",\"" +  theme + "\",\"" + picturePath +"\")";
        }
        public string getPK()
        {
            return "\"" + this.username + "\",\"" + this.email + "\"";
        }
    }
}
