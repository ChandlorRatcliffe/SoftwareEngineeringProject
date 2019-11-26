using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using BackEndDev.Sql;
using static BackEndDev.Sql.MySqlFunctions;

namespace BackEndDev
{
    /// <summary>
    /// Fully Test: AccountSql, BuiltOnSql, NotesPostedSql
    /// Note Tested: OrganizationAbilitiesSql, OrganizationSql, ParentSql, ProjectAbilitiesSql, ProjectSql, TaskAbilitiesSql, TaskSql
    /// </summary>
    class Program
    {



        private static readonly string timeStamp = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");

        private static readonly MySqlFunctions functions = new MySqlFunctions();

        private static readonly AccountSql accountSql = new AccountSql();
        private static readonly BuiltOnSql builtOnSql = new BuiltOnSql();
        private static readonly CreatesSql createsSql = new CreatesSql();
        private static readonly NotesPostedSql notesPostedSql = new NotesPostedSql();
        private static readonly OrganizationAbilitiesSql orgAbilitiesSql = new OrganizationAbilitiesSql();
        private static readonly OrganizationSql orgSql = new OrganizationSql();
        private static readonly ParentSql parentSql = new ParentSql();
        private static readonly ProjectAbilitiesSql projectAbilitiesSql = new ProjectAbilitiesSql();
        private static readonly ProjectSql projectSql = new ProjectSql();
        private static readonly TaskAbilitiesSql taskAbilitiesSql = new TaskAbilitiesSql();
        private static readonly TaskSql taskSql = new TaskSql();

        private static readonly Account account = new Account("TestUser666", "email@mail.com", "fName", "lName", "password", "skills", "theme", "picturepath");
        private static readonly BuiltOn builtOn = new BuiltOn("projId666", "taskId666");
        private static readonly Creates creates = new Creates("TestUser666", "email@mail.com", "CreatesName", "projId666");
        private static readonly NotesPosted notesPosted = new NotesPosted("notesText", timeStamp, "TestUser666", "email@mail.com", "taskId666");
        private static readonly OrganizationAbilities orgAbilities = new OrganizationAbilities("TestUser666", "email@mail.com", "OrgName", "rmUser", "invUser", "permEdit");
        private static readonly Organization org = new Organization("orgName666", "License666", "activation666", "expiration666");
        private static readonly Parent parent = new Parent("parent666", "childTask666");
        private static readonly ProjectAbilities parentAbilities = new ProjectAbilities("TestUser666", "email@mail.com", "projId666", "assignmentEdit", "projEdit", "createProj");
        private static readonly Project project = new Project("projId666", "projDeadline666", "projDesc666");
        private static readonly TaskAbilities taskAbilities = new TaskAbilities("TestUser666", "email@mail.com", "taskId666", "assignmentEdit");
        private static readonly Task task = new Task("taskId666", "taskDeadline", "taskDescription");

        public static void Main(string[] args)
        {
            //TestAccount();
            //TestBuiltOn();
            //TestCreates();
            //TestNotesPosted();
            TestOrganizationAbilities();

            //TestOrganization();
            //TestParent();
            //TestProjectAbilities();
            //TestProject();
            //TestTaskAbilities();
            //TestTask();
        }

        public static void TestAccount()
        {
            Insert(account);
            Console.Read();

            Get(account);
            Console.Read();

            Update(account);
            Console.Read();

            GetAllAccount();
            Console.Read();

            Delete(account);
            Console.Read();
        }

        public static void TestBuiltOn()
        {
            Insert(builtOn);
            Console.Read();

            Get(builtOn);
            Console.Read();

            Update(builtOn);
            Console.Read();

            GetAllBuiltOn();
            Console.Read();

            Delete(builtOn);
            Console.Read();
        }

        public static void TestCreates()
        {
            Insert(creates);
            Console.Read();

            Get(creates);
            Console.Read();

            Update(creates);
            Console.Read();

            GetAllCreates();
            Console.Read();

            Delete(creates);
            Console.Read();
        }

        public static void TestNotesPosted()
        {
            Insert(notesPosted);
            Console.Read();

            Get(notesPosted);
            Console.Read();

            Update(notesPosted);
            Console.Read();

            GetAllNotesPosted();
            Console.Read();

            Delete(notesPosted);
            Console.Read();
        }

        public static void TestOrganizationAbilities()
        {
            Insert(orgAbilities);
            Console.Read();

            Get(orgAbilities);
            Console.Read();

            Update(orgAbilities);
            Console.Read();

            GetAllOrgAbilities();
            Console.Read();

            Delete(orgAbilities);
            Console.Read();
        }

        public static void TestOrganization()
        {
            Insert(org);
            Console.Read();

            Get(org);
            Console.Read();

            Update(org);
            Console.Read();

            GetAllOrg();
            Console.Read();

            Delete(org);
            Console.Read();
        }

        public static void TestParent()
        {
            Insert(parent);
            Console.Read();

            Get(parent);
            Console.Read();

            Update(parent);
            Console.Read();

            GetAllParent();
            Console.Read();

            Delete(parent);
            Console.Read();
        }

        public static void TestProjectAbilities()
        {
            Insert(parentAbilities);
            Console.Read();

            Get(parentAbilities);
            Console.Read();

            Update(parentAbilities);
            Console.Read();

            GetAllProjectAbilities();
            Console.Read();

            Delete(parentAbilities);
            Console.Read();
        }

        public static void TestProject()
        {
            Insert(project);
            Console.Read();

            Get(project);
            Console.Read();

            Update(project);
            Console.Read();

            GetAllProject();
            Console.Read();

            Delete(project);
            Console.Read();
        }

        public static void TestTaskAbilities()
        {
            Insert(taskAbilities);
            Console.Read();

            Get(taskAbilities);
            Console.Read();

            Update(taskAbilities);
            Console.Read();

            GetAllTaskAbilities();
            Console.Read();

            Delete(taskAbilities);
            Console.Read();
        }

        public static void TestTask()
        {
            Insert(task);
            Console.Read();

            Get(task);
            Console.Read();

            Update(task);
            Console.Read();

            GetAllTask();
            Console.Read();

            Delete(task);
            Console.Read();
        }


        //BuiltOn Testing
        public static void Insert(Account account)
        {
            accountSql.Insert(account);
        }

        public static void Update(Account builtOn)
        {
            accountSql.Update(builtOn.Username, "email", "update1234");
        }

        public static void Delete(Account builtOn)
        {
            accountSql.Delete(builtOn);
        }

        public static void Get(Account builtOn)
        {
            Print(accountSql.Get(builtOn.Username));
        }

        public static void GetAllAccount()
        {
            foreach (Account obj in accountSql.GetAll())
            {
                Print(obj);
                Console.WriteLine();
            }
        }

        //BuiltOn Testing
        public static void Insert(BuiltOn builtOn)
        {
            builtOnSql.Insert(builtOn);
        }

        public static void Update(BuiltOn builtOn)
        {
            builtOnSql.Update(builtOn.ProjectId, "taskid", "update1234");
        }

        public static void Delete(BuiltOn builtOn)
        {
            builtOnSql.Delete(builtOn);
        }

        public static void Get(BuiltOn builtOn)
        {
            Print(builtOnSql.Get(builtOn.ProjectId));
        }

        public static void GetAllBuiltOn()
        {
            foreach (BuiltOn obj in builtOnSql.GetAll())
            {
                Print(obj);
                Console.WriteLine();
            }
        }

        //Creates Testing
        public static void Insert(Creates obj)
        {
            createsSql.Insert(obj);
        }

        public static void Update(Creates obj)
        {
            createsSql.Update(obj.Username, "name", "update1234");
        }

        public static void Delete(Creates obj)
        {
            createsSql.Delete(obj);
        }

        public static void Get(Creates obj)
        {
            Print(createsSql.Get(obj.Username));
        }

        public static void GetAllCreates()
        {
            foreach (Creates obj in createsSql.GetAll())
            {
                Print(obj);
                Console.WriteLine();
            }
            Console.Read();
        }

        //NotesPosted Testing
        public static void Insert(NotesPosted obj)
        {
            notesPostedSql.Insert(obj);
        }

        public static void Update(NotesPosted obj)
        {
            notesPostedSql.Update(obj.Username, "text", "update1234");
        }

        public static void Delete(NotesPosted obj)
        {
            notesPostedSql.Delete(obj);
        }

        public static void Get(NotesPosted obj)
        {
            Print(notesPostedSql.Get(obj.Username));
        }

        public static void GetAllNotesPosted()
        {
            foreach (NotesPosted obj in notesPostedSql.GetAll())
            {
                Print(obj);
                Console.WriteLine();
            }
            Console.Read();
        }

        //Organization Testing
        public static void Insert(Organization obj)
        {
            orgSql.Insert(obj);
        }

        public static void Update(Organization obj)
        {
            orgSql.Update(obj.Name, "license", "update1234");
        }

        public static void Delete(Organization obj)
        {
            orgSql.Delete(obj);
        }

        public static void Get(Organization obj)
        {
            Print(orgSql.Get(obj.Name));
        }

        public static void GetAllOrg()
        {
            foreach (Organization obj in orgSql.GetAll())
            {
                Print(obj);
                Console.WriteLine();
            }
            Console.Read();
        }

        //OrganizationAbilities Testing
        public static void Insert(OrganizationAbilities obj)
        {
            orgAbilitiesSql.Insert(obj);
        }

        public static void Update(OrganizationAbilities obj)
        {
            orgAbilitiesSql.Update(obj.Username, "name", "update1234");
        }

        public static void Delete(OrganizationAbilities obj)
        {
            orgAbilitiesSql.Delete(obj);
        }

        public static void Get(OrganizationAbilities obj)
        {
            Print(orgAbilitiesSql.Get(obj.Username));
        }

        public static void GetAllOrgAbilities()
        {
            foreach (OrganizationAbilities obj in orgAbilitiesSql.GetAll())
            {
                Print(obj);
                Console.WriteLine();
            }
            Console.Read();
        }

        //Parent Testing
        public static void Insert(Parent obj)
        {
            parentSql.Insert(obj);
        }

        public static void Update(Parent obj)
        {
            parentSql.Update(obj.ParentTaskId, "taskid", "update1234");
        }

        public static void Delete(Parent obj)
        {
            parentSql.Delete(obj);
        }

        public static void Get(Parent obj)
        {
            Print(parentSql.Get(obj.ParentTaskId));
        }

        public static void GetAllParent()
        {
            foreach (Parent obj in parentSql.GetAll())
            {
                Print(obj);
                Console.WriteLine();
            }
            Console.Read();
        }

        //Project Testing
        public static void Insert(Project obj)
        {
            projectSql.Insert(obj);
        }

        public static void Update(Project obj)
        {
            projectSql.Update(obj.ProjectId, "projectdeadline", "update1234");
        }

        public static void Delete(Project obj)
        {
            projectSql.Delete(obj);
        }

        public static void Get(Project obj)
        {
            Print(projectSql.Get(obj.ProjectId));
        }

        public static void GetAllProject()
        {
            foreach (Project obj in projectSql.GetAll())
            {
                Print(obj);
                Console.WriteLine();
            }
            Console.Read();
        }

        //ProjectAbilities Testing
        public static void Insert(ProjectAbilities obj)
        {
            projectAbilitiesSql.Insert(obj);
        }

        public static void Update(ProjectAbilities obj)
        {
            projectAbilitiesSql.Update(obj.Username, "email", "update1234");
        }

        public static void Delete(ProjectAbilities obj)
        {
            projectAbilitiesSql.Delete(obj);
        }

        public static void Get(ProjectAbilities obj)
        {
            Print(projectAbilitiesSql.Get(obj.ProjectId));
        }

        public static void GetAllProjectAbilities()
        {
            foreach (ProjectAbilities obj in projectAbilitiesSql.GetAll())
            {
                Print(obj);
                Console.WriteLine();
            }
            Console.Read();
        }

        //Task Testing
        public static void Insert(Task obj)
        {
            taskSql.Insert(obj);
        }

        public static void Update(Task obj)
        {
            taskSql.Update(obj.TaskId, "taskdeadline", "update1234");
        }

        public static void Delete(Task obj)
        {
            taskSql.Delete(obj);
        }

        public static void Get(Task obj)
        {
            Print(taskSql.Get(obj.TaskId));
        }

        public static void GetAllTask()
        {
            foreach (Task obj in taskSql.GetAll())
            {
                Print(obj);
                Console.WriteLine();
            }
            Console.Read();
        }

        //TaskAbilities Testing
        public static void Insert(TaskAbilities obj)
        {
            taskAbilitiesSql.Insert(obj);
        }

        public static void Update(TaskAbilities obj)
        {
            taskAbilitiesSql.Update(obj.Username, "email", "update1234");
        }

        public static void Delete(TaskAbilities obj)
        {
            taskAbilitiesSql.Delete(obj);
        }

        public static void Get(TaskAbilities obj)
        {
            Print(taskAbilitiesSql.Get(obj.Username));
        }

        public static void GetAllTaskAbilities()
        {
            foreach (TaskAbilities obj in taskAbilitiesSql.GetAll())
            {
                Print(obj);
                Console.WriteLine();
            }
            Console.Read();
        }

        public static void Print(Account account)
        {
            Console.WriteLine($"Username = {account.Username}");
            Console.WriteLine($"Email = {account.Email}");
            Console.WriteLine($"FirstName = {account.FirstName}");
            Console.WriteLine($"LastName = {account.LastName}");
            Console.WriteLine($"Password = {account.Password}");
            Console.WriteLine($"Skills = {account.Skills}");
            Console.WriteLine($"Theme = {account.Theme}");
            Console.WriteLine($"Picturepath = {account.Picturepath}");
        }

        public static void Print(BuiltOn builtOn)
        {
            Console.WriteLine($"ProjectId = {builtOn.ProjectId}");
            Console.WriteLine($"TaskId = {builtOn.TaskId}");
        }

        public static void Print(Creates creates)
        {
            Console.WriteLine($"Username = {creates.Username}");
            Console.WriteLine($"Email = {creates.Email}");
            Console.WriteLine($"Name = {creates.Name}");
            Console.WriteLine($"ProjectId = {creates.ProjectId}");
        }

        public static void Print(NotesPosted notes)
        {
            Console.WriteLine($"Text = {notes.Text}");
            Console.WriteLine($"TimeStamp = {notes.TimeStamp}");
            Console.WriteLine($"Username = {notes.Username}");
            Console.WriteLine($"Email = {notes.Email}");
            Console.WriteLine($"TaskId = {notes.TaskId}");
        }

        public static void Print(Organization org)
        {
            Console.WriteLine($"Name = {org.Name}");
            Console.WriteLine($"License = {org.License}");
            Console.WriteLine($"Activation = {org.Activation}");
            Console.WriteLine($"Expiration = {org.Expiration}");
        }

        public static void Print(OrganizationAbilities orgAb)
        {
            Console.WriteLine($"Username = {orgAb.Username}");
            Console.WriteLine($"Email = {orgAb.Email}");
            Console.WriteLine($"Name = {orgAb.Name}");
            Console.WriteLine($"RemoveUser = {orgAb.RemoveUser}");
            Console.WriteLine($"InviteUser = {orgAb.InviteUser}");
            Console.WriteLine($"PermissionsEditing = {orgAb.PermissionsEditing}");
        }

        public static void Print(Parent parent)
        {
            Console.WriteLine($"ParentTaskId = {parent.ParentTaskId}");
            Console.WriteLine($"ChildTaskId = {parent.ChildTaskId}");
        }

        public static void Print(Project proj)
        {
            Console.WriteLine($"ProjectId = {proj.ProjectId}");
            Console.WriteLine($"ProjectDeadline = {proj.ProjectDeadline}");
            Console.WriteLine($"ProjectDescription = {proj.ProjectDescription}");
        }

        public static void Print(ProjectAbilities projAb)
        {
            Console.WriteLine($"Username = {projAb.Username}");
            Console.WriteLine($"Email = {projAb.Email}");
            Console.WriteLine($"ProjectId = {projAb.ProjectId}");
            Console.WriteLine($"AssignmentEditing = {projAb.AssignmentEditing}");
            Console.WriteLine($"ProjectEditing = {projAb.ProjectEditing}");
            Console.WriteLine($"CreateProject = {projAb.CreateProject}");
        }

        public static void Print(Task task)
        {
            Console.WriteLine($"TaskId = {task.TaskId}");
            Console.WriteLine($"TaskDeadline = {task.TaskDeadline}");
            Console.WriteLine($"TaskDescription = {task.TaskDescription}");
        }

        public static void Print(TaskAbilities taskAb)
        {
            Console.WriteLine($"Username = {taskAb.Username}");
            Console.WriteLine($"Email = {taskAb.Email}");
            Console.WriteLine($"TaskId = {taskAb.TaskId}");
            Console.WriteLine($"AssignmentEditing = {taskAb.AssignmentEditing}");
        }

    }
}
