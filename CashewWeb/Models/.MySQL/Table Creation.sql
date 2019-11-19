DROP TABLE Accounts;
CREATE TABLE Accounts(
    `Username`		VARCHAR(50),
    `Email`		VARCHAR(150),
    `FirstName`  VARCHAR(50),
    `LastName`  VARCHAR(150),
    `Password`		VARCHAR(150),
    `Role`		VARCHAR(250),
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

DROP TABLE Projects;
CREATE TABLE Projects(
    `ProjectId`	VARCHAR(50),
    `TaskId`		VARCHAR(50),
    `TaskDeadline`	DATETIME,
    `TaskDescription`	VARCHAR(65335),
    PRIMARY KEY(`ProjectId`)
);

DROP TABLE Tasks;
CREATE TABLE Tasks(
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