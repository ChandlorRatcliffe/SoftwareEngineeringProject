using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KarbonWebForms.Sql
{
    /// <summary>
    /// These class structure representations of SQL Tables
    /// </summary>

    public class Account
    {
        public Account(string username = null, string email = null, string firstname = null, string lastname = null,
            string password = null, string skills = null, string theme = null, string picturepath = null)
        {
            Username = username;
            Email = email;
            FirstName = firstname;
            LastName = lastname;
            Password = password;
            Skills = skills;
            Theme = theme;
            Picturepath = picturepath;
        }


        public string Username { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Skills { get; set; }
        public string Theme { get; set; }
        public string Picturepath { get; set; }
    }

    public class BuiltOn
    {
        public BuiltOn(string projectId = null, string taskId = null)
        {
            ProjectId = projectId;
            TaskId = taskId;
        }

        public string ProjectId { get; set; }
        public string TaskId { get; set; }
    }

    public class Creates
    {
        public Creates(string username = null, string email = null, string name = null, string projectId = null)
        {
            Username = username;
            Email = email;
            Name = name;
            ProjectId = projectId;
        }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string ProjectId { get; set; }
    }

    public class NotesPosted
    {
        public NotesPosted(string text = null, string timeStamp = null, string username = null, string email = null, string taskId = null)
        {
            Text = text;
            TimeStamp = timeStamp;
            Username = username;
            Email = email;
            TaskId = taskId;
        }
        public string Text { get; set; }
        public string TimeStamp { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string TaskId { get; set; }
    }

    public class Organization
    {
        public Organization(string name, string license, string activation, string expiration)
        {
            Name = name;
            License = license;
            Activation = activation;
            Expiration = expiration;
        }
        public string Name { get; set; }
        public string License { get; set; }
        public string Activation { get; set; }
        public string Expiration { get; set; }
    }

    public class OrganizationAbilities
    {
        public OrganizationAbilities(string username = null, string email = null, string name = null, string removeUser = null,
            string inviteUser = null, string permissionsEditing = null)
        {
            Username = username;
            Email = email;
            Name = name;
            RemoveUser = removeUser;
            InviteUser = inviteUser;
            PermissionsEditing = permissionsEditing;
        }

        public string Username { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string RemoveUser { get; set; }
        public string InviteUser { get; set; }
        public string PermissionsEditing { get; set; }
    }

    public class Parent
    {
        public Parent(string parentTaskId = null, string childTaskId = null)
        {
            ParentTaskId = parentTaskId;
            ChildTaskId = childTaskId;
        }

        public string ParentTaskId { get; set; }
        public string ChildTaskId { get; set; }
    }

    public class Project
    {
        public Project(string projectId = null, string projectDeadline = null, string projectDescription = null)
        {
            ProjectId = projectId;
            ProjectDeadline = projectDeadline;
            ProjectDescription = projectDescription;
        }

        public string ProjectId { get; set; }
        public string ProjectDeadline { get; set; }
        public string ProjectDescription { get; set; }
    }

    public class ProjectAbilities
    {
        public ProjectAbilities(string username = null, string email = null, string projectId = null,
            string assignmentEditing = null, string projectEditing = null, string createProject = null)
        {
            Username = username;
            Email = email;
            ProjectId = projectId;
            AssignmentEditing = assignmentEditing;
            ProjectEditing = projectEditing;
            CreateProject = createProject;
        }
        public string Username { get; set; }
        public string Email { get; set; }
        public string ProjectId { get; set; }
        public string AssignmentEditing { get; set; }
        public string ProjectEditing { get; set; }
        public string CreateProject { get; set; }
    }

    public class Task
    {
        public Task(string taskId, string taskDeadline, string taskDescription)
        {
            TaskId = taskId;
            TaskDeadline = taskDeadline;
            TaskDescription = taskDescription;
        }
        public string TaskId { get; set; }
        public string TaskDeadline { get; set; }
        public string TaskDescription { get; set; }
    }

    public class TaskAbilities
    {
        public TaskAbilities(string username = null, string email = null, string taskId = null, string assignmentEditing = null)
        {
            Username = username;
            Email = email;
            TaskId = taskId;
            AssignmentEditing = assignmentEditing;
        }
        public string Username { get; set; }
        public string Email { get; set; }
        public string TaskId { get; set; }
        public string AssignmentEditing { get; set; }
    }


    /// <summary>
    /// Key Value Pair For Checking Existance in a Table
    /// </summary>
    public class CheckValuePair
    {
        public CheckValuePair(string key, string value)
        {
            Key = key;
            Value = value;
        }

        public string Key { get; set; }
        public string Value { get; set; }
    }
}