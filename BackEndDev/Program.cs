using System;
using System.Threading;
using BackEndDev.Sql;

namespace BackEndDev
{
    /// <summary>
    /// Fully Test: AccountSql, BuiltOnSql, NotesPostedSql, OrganizationAbilitiesSql, OrganizationSql,
    /// ParentSql, ProjectAbilitiesSql, ProjectSql, TaskAbilitiesSql, TaskSql, ProjectAssigned, TaskAssigned
    /// Not Tested: None (11/26/19) 
    /// </summary>
    class Program
    {
        private static readonly DateTime timeStamp = DateTime.Now;
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
        private static readonly ProjectAssignedSql projectAssignedSql = new ProjectAssignedSql();
        private static readonly TaskAssignedSql taskAssignedSql = new TaskAssignedSql();
        private static readonly Account account = new Account("TestUser666", "email@mail.com", "fName", "lName", "password", "skills", "theme", "picturepath");
        private static readonly BuiltOn builtOn = new BuiltOn("projId666", "taskId666");
        private static readonly Creates creates = new Creates("TestUser666", "email@mail.com", "CreatesName", "projId666");
        private static readonly NotesPosted notesPosted = new NotesPosted("notesText", timeStamp, "TestUser666", "email@mail.com", "taskId666");
        private static readonly OrganizationAbilities orgAbilities = new OrganizationAbilities("TestUser666", "email@mail.com", "OrgName", 1, 2, 3);
        private static readonly Organization org = new Organization("orgName666", "License666", timeStamp, timeStamp);
        private static readonly Parent parent = new Parent("parent666", "childTask666");
        private static readonly ProjectAbilities parentAbilities = new ProjectAbilities("TestUser666", "email@mail.com", "projId666", 1, 2, 3);
        private static readonly Project project = new Project("projId666", timeStamp, "projDesc666");
        private static readonly TaskAbilities taskAbilities = new TaskAbilities("TestUser666", "email@mail.com", "taskId666", 3);
        private static readonly Task task = new Task("taskId666", timeStamp, "taskDescription");
        private static readonly ProjectAssigned projectAssigned = new ProjectAssigned("TestUser666", "email@mail.com", "Name666", "projId666");
        private static readonly TaskAssigned taskAssigned = new TaskAssigned("TestUser666", "email@mail.com", "Name666", "taskId666");

        public static void Main()
        {
            TestAccount();
            TestBuiltOn();
            TestCreates();
            TestNotesPosted();
            TestOrganizationAbilities();
            TestOrganization();
            TestParent();
            TestProjectAbilities();
            TestProject();
            TestTaskAbilities();
            TestTask();
            TestProjectAssigned();
            TestTaskAssigned();
        }

        public static void TestAccount()
        {
            Insert(account);
            Thread.Sleep(1000);

            Get(account);
            Thread.Sleep(1000);

            Update(account);
            Thread.Sleep(1000);

            GetAllAccount();
            Thread.Sleep(1000);

            Delete(account);
            Thread.Sleep(1000);
        }

        public static void TestBuiltOn()
        {
            Insert(builtOn);
            Thread.Sleep(1000);

            Get(builtOn);
            Thread.Sleep(1000);

            Update(builtOn);
            Thread.Sleep(1000);

            GetAllBuiltOn();
            Thread.Sleep(1000);

            Delete(builtOn);
            Thread.Sleep(1000);
        }

        public static void TestCreates()
        {
            Insert(creates);
            Thread.Sleep(1000);

            Get(creates);
            Thread.Sleep(1000);

            Update(creates);
            Thread.Sleep(1000);

            GetAllCreates();
            Thread.Sleep(1000);

            Delete(creates);
            Thread.Sleep(1000);
        }

        public static void TestNotesPosted()
        {
            Insert(notesPosted);
            Thread.Sleep(1000);

            Get(notesPosted);
            Thread.Sleep(1000);

            Update(notesPosted);
            Thread.Sleep(1000);

            GetAllNotesPosted();
            Thread.Sleep(1000);

            Delete(notesPosted);
            Thread.Sleep(1000);
        }

        public static void TestOrganizationAbilities()
        {
            Insert(orgAbilities);
            Thread.Sleep(1000);

            Get(orgAbilities);
            Thread.Sleep(1000);

            Update(orgAbilities);
            Thread.Sleep(1000);

            GetAllOrgAbilities();
            Thread.Sleep(1000);

            Delete(orgAbilities);
            Thread.Sleep(1000);
        }

        public static void TestOrganization()
        {
            Insert(org);
            Thread.Sleep(1000);

            Get(org);
            Thread.Sleep(1000);

            Update(org);
            Thread.Sleep(1000);

            GetAllOrg();
            Thread.Sleep(1000);

            Delete(org);
            Thread.Sleep(1000);
        }

        public static void TestParent()
        {
            Insert(parent);
            Thread.Sleep(1000);

            Get(parent);
            Thread.Sleep(1000);

            Update(parent);
            Thread.Sleep(1000);

            GetAllParent();
            Thread.Sleep(1000);

            Delete(parent);
            Thread.Sleep(1000);
        }

        public static void TestProjectAbilities()
        {
            Insert(parentAbilities);
            Thread.Sleep(1000);

            Get(parentAbilities);
            Thread.Sleep(1000);

            Update(parentAbilities);
            Thread.Sleep(1000);

            GetAllProjectAbilities();
            Thread.Sleep(1000);

            Delete(parentAbilities);
            Thread.Sleep(1000);
        }

        public static void TestProject()
        {
            Insert(project);
            Thread.Sleep(1000);

            Get(project);
            Thread.Sleep(1000);

            Update(project);
            Thread.Sleep(1000);

            GetAllProject();
            Thread.Sleep(1000);

            Delete(project);
            Thread.Sleep(1000);
        }

        public static void TestTaskAbilities()
        {
            Insert(taskAbilities);
            Thread.Sleep(1000);

            Get(taskAbilities);
            Thread.Sleep(1000);

            Update(taskAbilities);
            Thread.Sleep(1000);

            GetAllTaskAbilities();
            Thread.Sleep(1000);

            Delete(taskAbilities);
            Thread.Sleep(1000);
        }

        public static void TestTask()
        {
            Insert(task);
            Thread.Sleep(1000);

            Get(task);
            Thread.Sleep(1000);

            Update(task);
            Thread.Sleep(1000);

            GetAllTask();
            Thread.Sleep(1000);

            Delete(task);
            Thread.Sleep(1000);
        }

        public static void TestProjectAssigned()
        {
            Insert(projectAssigned);
            Thread.Sleep(1000);

            Get(projectAssigned);
            Thread.Sleep(1000);

            Update(projectAssigned);
            Thread.Sleep(1000);

            GetAllProjectAssigned();
            Thread.Sleep(1000);

            Delete(projectAssigned);
            Thread.Sleep(1000);
        }

        public static void TestTaskAssigned()
        {
            Insert(taskAssigned);
            Thread.Sleep(1000);

            Get(taskAssigned);
            Thread.Sleep(1000);

            Update(taskAssigned);
            Thread.Sleep(1000);

            GetAllTaskAssigned();
            Thread.Sleep(1000);

            Delete(taskAssigned);
            Thread.Sleep(1000);
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
            Thread.Sleep(1000);
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
            Thread.Sleep(1000);
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
            Thread.Sleep(1000);
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
            Thread.Sleep(1000);
        }

        //Parent Testing
        public static void Insert(Parent obj)
        {
            parentSql.Insert(obj);
        }

        public static void Update(Parent obj)
        {
            parentSql.Update(obj.ParentTaskId, "childtaskid", "update1234");
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
            Thread.Sleep(1000);
        }

        //Project Testing
        public static void Insert(Project obj)
        {
            projectSql.Insert(obj);
        }

        public static void Update(Project obj)
        {
            projectSql.Update(obj.ProjectId, "projectdescription", obj.ProjectDescription);
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
            Thread.Sleep(1000);
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
            Print(projectAbilitiesSql.Get(obj.Username));
        }

        public static void GetAllProjectAbilities()
        {
            foreach (ProjectAbilities obj in projectAbilitiesSql.GetAll())
            {
                Print(obj);
                Console.WriteLine();
            }
            Thread.Sleep(1000);
        }

        //Task Testing
        public static void Insert(Task obj)
        {
            taskSql.Insert(obj);
        }

        public static void Update(Task obj)
        {
            taskSql.Update(obj.TaskId, "taskdeadline", DateTime.Now);
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
            Thread.Sleep(1000);
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

        public static void GetAllProjectAssigned()
        {
            foreach (TaskAbilities obj in taskAbilitiesSql.GetAll())
            {
                Print(obj);
                Console.WriteLine();
            }
            Thread.Sleep(1000);
        }

        //ProjectAssigned Testing
        public static void Insert(ProjectAssigned obj)
        {
            projectAssignedSql.Insert(obj);
        }

        public static void Update(ProjectAssigned obj)
        {
            projectAssignedSql.Update(obj.Username, "email", "update1234");
        }

        public static void Delete(ProjectAssigned obj)
        {
            projectAssignedSql.Delete(obj);
        }

        public static void Get(ProjectAssigned obj)
        {
            Print(projectAssignedSql.Get(obj.Username));
        }

        public static void GetAllTaskAssigned()
        {
            foreach (ProjectAssigned obj in projectAssignedSql.GetAll())
            {
                Print(obj);
                Console.WriteLine();
            }
            Thread.Sleep(1000);
        }

        //TaskAbilities Testing
        public static void Insert(TaskAssigned obj)
        {
            taskAssignedSql.Insert(obj);
        }

        public static void Update(TaskAssigned obj)
        {
            taskAssignedSql.Update(obj.Username, "email", "update1234");
        }

        public static void Delete(TaskAssigned obj)
        {
            taskAssignedSql.Delete(obj);
        }

        public static void Get(TaskAssigned obj)
        {
            Print(taskAssignedSql.Get(obj.Username));
        }

        public static void GetAllTaskAbilities()
        {
            foreach (TaskAbilities obj in taskAbilitiesSql.GetAll())
            {
                Print(obj);
                Console.WriteLine();
            }
            Thread.Sleep(1000);
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

        public static void Print(ProjectAssigned projectAssigned)
        {
            Console.WriteLine($"Username = {projectAssigned.Username}");
            Console.WriteLine($"Email = {projectAssigned.Email}");
            Console.WriteLine($"TaskId = {projectAssigned.Name}");
            Console.WriteLine($"AssignmentEditing = {projectAssigned.ProjectId}");
        }

        public static void Print(TaskAssigned taskAssigned)
        {
            Console.WriteLine($"Username = {taskAssigned.Username}");
            Console.WriteLine($"Email = {taskAssigned.Email}");
            Console.WriteLine($"TaskId = {taskAssigned.Name}");
            Console.WriteLine($"AssignmentEditing = {taskAssigned.TaskId}");
        }

    }
}
