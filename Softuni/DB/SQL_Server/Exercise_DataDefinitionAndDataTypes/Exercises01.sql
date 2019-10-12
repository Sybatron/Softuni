--P02
CREATE TABLE Minions(
	Id INT PRIMARY KEY,
	[Name] NVARCHAR(32) NOT NULL,
	Age TINYINT NOT NULL
)

CREATE TABLE Towns(
	Id INT PRIMARY KEY,
	[Name] NVARCHAR(32) NOT NULL
)

--P03
ALTER TABLE Minions
ADD TownId INT

ALTER TABLE Minions
ADD FOREIGN KEY (TownId) REFERENCES Towns(Id)

-----------------------
ALTER TABLE Minions
ALTER COLUMN Age INT NULL
-----------------------

--P04
INSERT INTO Towns(Id, [Name])
VALUES
	(1, 'Sofia'),
	(2, 'Plovdiv'),
	(3, 'Varna');

INSERT INTO Minions(Id, [Name], Age, TownId)
VALUES
	(1, 'Kevin', 22, 1),
	(2, 'Bob', 15, 3),
	(3, 'Steward', NULL, 2);

-----------------------
SELECT * FROM dbo.Towns
SELECT * FROM dbo.Minions
-----------------------

--P05
DELETE FROM dbo.Minions

--P06
DROP TABLE dbo.Minions
DROP TABLE dbo.Towns

--P07
CREATE TABLE People(
	Id INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(200) NOT NULL,
	Picture VARBINARY(MAX) CHECK (Picture<=2097152),
	Height DECIMAL(3, 2),
	[Weight] DECIMAL(5,2),
	Gender CHAR NOT NULL CHECK(Gender='m' OR Gender='f'),
	Birthdate DATE NOT NULL,
	Biography NVARCHAR(MAX)
)

INSERT INTO People([Name], Height, [Weight], Gender, Birthdate, Biography)
Values
('Georgi Petrov', 1.67, 83.21,'m', CAST('13 Jan 1978' AS DATE), 'This is my biography'),
('Penka Georgieva', 1.90, 110.53, 'f', CAST('25 Dec 1973' AS DATE), NULL),
('Минчо Минчев', NULL, NULL, 'm', CAST('13 Mar 1990' AS DATE), 'I don''have life'),
('Касим Ах Халхабиб', NULL, 64.32, 'm', CAST('23 Feb 1970' AS DATE), NULL),
('Daniel Green', 1.8, NULL, 'm', CAST('28 Sep 2000' AS DATE), NULL);

-----------------------
SELECT * FROM dbo.People
-----------------------

--P08
CREATE TABLE Users(
	Id BIGINT PRIMARY KEY IDENTITY,
	Username VARCHAR(30) NOT NULL,
	[Password] VARCHAR(26) NOT NULL,
	ProfilePicture VARBINARY(MAX) CHECK(ProfilePicture <= 921600),
	LastLoginTime DATETIME,
	IsDeleted VARCHAR(5) CHECK(IsDeleted='true' OR IsDeleted='false')
)

INSERT INTO Users(Username,[Password],IsDeleted)
VALUES
	('Vankata', 'FLDL23423FFD_','true'),
	('FlexZ', 'H9DH0JDB0MD0', 'false'),
	('Gramadata', 'GSLJS9VXCU-0VXJ0', 'false'),
	('Biranchou', 'GDF09GDFB0JD', 'true'),
	('DevCo', 'F9SUD0VJXC0NVclkx;', 'false');

-----------------------
SELECT * FROM dbo.Users
-----------------------

--P09
ALTER TABLE Users
DROP CONSTRAINT PK__USERS

ALTER TABLE Users
ADD PRIMARY KEY(Id, Username);

--P10
ALTER TABLE Users
ADD CONSTRAINT CHK_Password CHECK(LEN([Password])>=5);

-----------------------
INSERT INTO Users(Username, [Password])
VALUES ('GENCHO', '1234');
-----------------------

--P11
ALTER TABLE Users
ADD CONSTRAINT DF_LastLoginTime DEFAULT CAST(GETDATE() AS DATETIME) FOR LastLoginTime;


-----------------------
INSERT INTO Users(Username,[Password])
VALUES ('Somebody2','dfgdfgfdg23423')

SELECT * FROM Users

ALTER TABLE Users
DROP CONSTRAINT DF_LastLoginTime 
-----------------------

--P12
ALTER TABLE Users
DROP CONSTRAINT PK__USERS

ALTER TABLE Users
ADD PRIMARY KEY(Id)

ALTER TABLE Users
ADD CONSTRAINT CHK_Username CHECK(LEN(Username)>=3)