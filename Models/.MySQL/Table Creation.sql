DROP TABLE User;
CREATE TABLE User(
    `username`		VARCHAR(20),
    `email`		VARCHAR(50),
    `first name`  VARCHAR(20),
    `last name`  VARCHAR(20),
    `password`		VARCHAR(20),
    `role`		VARCHAR(256),
    `skills`		VARCHAR(6000),
    `theme`		VARCHAR(1000),
    `picturepath`	VARCHAR(5000),
    PRIMARY KEY(`username`, `email`)
);

select * from user;

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
    `project id`	VARCHAR(50),
    `task id`		VARCHAR(50),
    `task deadline`	DATETIME,
    `task description`	VARCHAR(65335),
    PRIMARY KEY(`project id`)
);

DROP TABLE Task;
CREATE TABLE Task(
    `task id`		VARCHAR(50),
    `task deadline`	DATETIME,
    `task description`  VARCHAR(65335),
    PRIMARY KEY(`task id`)
);

DROP TABLE Parents;
CREATE TABLE Parents(
    `parent id`		VARCHAR(50),
    `child id`		VARCHAR(50),
     PRIMARY KEY(`parent id`)
);

DROP TABLE OrganizationAbilities;
CREATE TABLE OrganizationAbilities(
    `username`		VARCHAR(20),
    `email`		VARCHAR(50),
    `name`		VARCHAR(20),
    `remove user`	INT,
    `invite user`	INT,
    `permissions editing` INT,
    PRIMARY KEY(`username`, `email`, `name`)
);
 
DROP TABLE ProjectAbilities;
CREATE TABLE ProjectAbilities(
    `username`		VARCHAR(20),
    `email`		VARCHAR(50),
    `project id`	VARCHAR(50),
    `assignment editing` INT,
    `project editing`	INT,
    `create project`	INT,
    PRIMARY KEY(`username`, `email`, `project id`)
);

DROP TABLE TaskAbilities;
CREATE TABLE TaskAbilities(
    `username`		VARCHAR(20),
    `email`		VARCHAR(50),
    `task id`		VARCHAR(50),
    `assignment editing` INT, 
    PRIMARY KEY(`username`, `email`, `task id`)   
);