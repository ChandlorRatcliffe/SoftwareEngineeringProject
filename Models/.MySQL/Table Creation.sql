DROP TABLE Account;
CREATE TABLE Account(
    `Username`		VARCHAR(20),
    `Email`		VARCHAR(50),
    `FirstName`  VARCHAR(20),
    `LastName`  VARCHAR(20),
    `Password`		VARCHAR(20),
    `Role`		VARCHAR(256),
    `Skills`		VARCHAR(6000),
    `Theme`		VARCHAR(1000),
    `Picturepath`	VARCHAR(5000),
    PRIMARY KEY(`Username`, `Email`)
);


DROP TABLE Organizations;
CREATE TABLE Organizations(
    `Name`		VARCHAR(20),
    `Licesnses`		VARCHAR(20),
    `Activation`		INT,
    `Expiration`		DATETIME,
    PRIMARY KEY(Name)
);

DROP TABLE Project;
CREATE TABLE Project(
    `ProjectId`	VARCHAR(50),
    `TaskId`		VARCHAR(50),
    `TaskDeadline`	DATETIME,
    `TaskDescription`	VARCHAR(65335),
    PRIMARY KEY(`ProjectId`)
);

DROP TABLE Task;
CREATE TABLE Task(
    `TaskId`		VARCHAR(50),
    `TaskDeadline`	DATETIME,
    `TaskDescription`  VARCHAR(65335),
    PRIMARY KEY(`TaskId`)
);

DROP TABLE Parents;
CREATE TABLE Parents(
    `ParentId`		VARCHAR(50),
    `ChildId`		VARCHAR(50),
     PRIMARY KEY(`ParentId`)
);

DROP TABLE OrganizationAbilities;
CREATE TABLE OrganizationAbilities(
    `Username`		VARCHAR(20),
    `Email`		VARCHAR(50),
    `Name`		VARCHAR(20),
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
    `ProjectEditing`	INT,
    `CreateProject`	INT,
    PRIMARY KEY(`Username`, `Email`, `ProjectId`)
);

DROP TABLE TaskAbilities;
CREATE TABLE TaskAbilities(
    `Username`		VARCHAR(20),
    `Email`		VARCHAR(50),
    `TaskId`		VARCHAR(50),
    `AssignmentEditing` INT, 
    PRIMARY KEY(`Username`, `Email`, `TaskId`)   
);