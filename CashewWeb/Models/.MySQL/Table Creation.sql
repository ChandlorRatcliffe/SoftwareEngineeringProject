DROP TABLE accounts;

DROP TABLE Account;
CREATE TABLE Account(
    `Username`		VARCHAR(50),
    `Email`		VARCHAR(150),
    `FirstName`  VARCHAR(50),
    `LastName`  VARCHAR(150),
    `Password`		VARCHAR(150),
    `Skills`		VARCHAR(6000),
    `Theme`		VARCHAR(1000),
    `Picturepath`	VARCHAR(5000),
    PRIMARY KEY(`Username`, `Email`)
);

DROP TABLE Creates;
CREATE TABLE Creates(
	`Username`		VARCHAR(50),
    `Email`			VARCHAR(150),
	`Name`			VARCHAR(200),
    `ProjectId`		VARCHAR(50),
    PRIMARY KEY(`Username`,`Email`,`Name`,`ProjectId`)
);

DROP TABLE TaskAssigned;
CREATE TABLE TaskAssigned(
	`Username`		VARCHAR(50),
    `Email`			VARCHAR(150),
    `TaskId`		VARCHAR(50),
    PRIMARY KEY(`Username`,`Email`,`TaskId`)
);

DROP TABLE ProjectAssigned;
CREATE TABLE ProjectAssigned(
	`Username`		VARCHAR(50),
    `Email`			VARCHAR(150),
    `ProjectId`		VARCHAR(50),
    PRIMARY KEY(`Username`,`Email`,`ProjectId`)
);


DROP TABLE Organization;
CREATE TABLE Organization(
    `Name`		VARCHAR(200),
    `License`		VARCHAR(20),
    `Activation`		DATETIME,
    `Expiration`		DATETIME,
    PRIMARY KEY(Name)
);

DROP TABLE Project;
CREATE TABLE Project(
    `ProjectId`	VARCHAR(50),
    `ProjectDeadline`	DATETIME,
    `ProjectDescription`	VARCHAR(65335),
    PRIMARY KEY(`ProjectId`)
);

DROP TABLE BuiltOn;
CREATE TABLE BuiltOn(
    `ProjectId`	 VARCHAR(50),
    `TaskId`	 VARCHAR(50),
    PRIMARY KEY(`ProjectId`,`TaskId`)
);

DROP TABLE Manages;
CREATE TABLE Manages(
	`ProjectId`	    VARCHAR(50),
    `TaskId`		VARCHAR(50),
    PRIMARY KEY(`ProjectId`, `TaskId`)
);

DROP TABLE Task;
CREATE TABLE Task(
    `TaskId`		VARCHAR(50),
    `TaskDeadline`	DATETIME,
    `TaskCompleted` DATETIME,
    `TaskDescription`  VARCHAR(65335),
    PRIMARY KEY(`TaskId`)
);

DROP TABLE Parent;
CREATE TABLE Parent(
    `ParentTaskId`		VARCHAR(50),
    `ChildTaskId`		VARCHAR(50),
     PRIMARY KEY(`ParentTaskId`,`ChildTaskId`)
);

DROP TABLE NotesPosted;
CREATE TABLE NotesPosted(
    `Text`       VarChar(500),
    `TimeStamp`  DATETIME,
	`Username`	 VARCHAR(50),
    `Email`		 VARCHAR(150),
    `TaskId`	 VARCHAR(50),
    PRIMARY KEY(`Username`, `Email`, `TaskId`,`TimeStamp`)
);

DROP TABLE OrganizationAbilities;
CREATE TABLE OrganizationAbilities(
    `Username`		VARCHAR(50),
    `Email`		VARCHAR(50),
    `Name`		VARCHAR(50),
    `RemoveUser`	INT,
    `InviteUser`	INT,
    `PermissionsEditing` INT,
    PRIMARY KEY(`Username`, `Email`, `Name`)
);
 
DROP TABLE ProjectAbilities;
CREATE TABLE ProjectAbilities(
    `Username`		VARCHAR(20),
    `Email`		VARCHAR(50),
    `ProjectId`	VARCHAR(50),
    `AssignmentEditing` INT,
    `EditProject`		INT,
    `CreateProject`	    INT,
	`DeleteProject`		INT,
    PRIMARY KEY(`Username`, `Email`, `ProjectId`)
);

DROP TABLE TaskAbilities;
CREATE TABLE TaskAbilities(
    `Username`			VARCHAR(20),
    `Email`				VARCHAR(50),
    `TaskId`			VARCHAR(50),
    `AssignmentEditing` INT, 
    `EditTask`	 		INT,
    `CreateTask` 		INT,
    `DeleteTask`		Int,
    PRIMARY KEY(`Username`, `Email`, `TaskId`)   
);