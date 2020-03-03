USE Bitbucket

GO

--contains information about the users.
CREATE TABLE Users(
	Id INT PRIMARY KEY IDENTITY,
	Username VARCHAR(30) NOT NULL,
	[Password] VARCHAR(30) NOT NULL,
	Email VARCHAR(50) NOT NULL
)

--contains information about the repositories.
CREATE TABLE Repositories(
	Id INT PRIMARY KEY IDENTITY,
	Name VARCHAR(50) NOT NULL
)

--a many to many mapping table between the repositories and the users
CREATE TABLE RepositoriesContributors(
	RepositoryId INT FOREIGN KEY REFERENCES Repositories(Id) NOT NULL,
	ContributorId INT FOREIGN KEY REFERENCES Users(Id) NOT NULL
)

--contains information about the issues.
--o	Each issue has a repository.
--o	Each issue has an assignee (user).
CREATE TABLE Issues(
	Id INT PRIMARY KEY IDENTITY,
	Title VARCHAR(255) NOT NULL,
	IssueStatus CHAR(6) NOT NULL,
	RepositoryId INT FOREIGN KEY REFERENCES Repositories(Id) NOT NULL,
	AssigneeId INT FOREIGN KEY REFERENCES Users(Id) NOT NULL
)

--� contains information about the commits.
--o	Each commit MAY have an issue.
--o	Each commit has a repository.
--o	Each commit has a contributor (user).
CREATE TABLE Commits(
	Id INT PRIMARY KEY IDENTITY,
	[Message] VARCHAR(255) NOT NULL,
	IssueId INT FOREIGN KEY REFERENCES Issues(Id),
	RepositoryId INT FOREIGN KEY REFERENCES Repositories(Id) NOT NULL,
	ContributorId INT FOREIGN KEY REFERENCES Users(Id) NOT NULL
)

--contains information about the files.
--o	Each file MAY have a parent (file).
CREATE TABLE Files(
	Id INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(100) NOT NULL,
	Size DECIMAL(15,2) NOT NULL,
	ParentId INT FOREIGN KEY REFERENCES Files(Id),
	CommitId INT FOREIGN KEY REFERENCES Commits(Id) NOT NULL
)

GO

INSERT INTO FILES([Name],Size,ParentId,CommitId)
VALUES
	('Trade.idk', 2598.0, 1, 1),
	('menu.net', 9238.31, 2, 2),
	('Administrate.soshy', 1246.93, 3, 3),
	('Controller.php', 7353.15, 4, 4),
	('Find.java', 9957.86, 5, 5),
	('Controller.json', 14034.87, 3, 6),
	('Operate.xix', 7662.92, 7, 7)

INSERT INTO Issues(Title,IssueStatus,RepositoryId,AssigneeId)
VALUES
	('Critical Problem with HomeController.cs file', 'open', 1, 4),
	('Typo fix in Judge.html', 'open', 4, 3),
	('Implement documentation for UsersService.cs', 'cloes', 8, 2),
	('Unreachable code in Index.cs', 'open', 9, 8)

GO
UPDATE Issues
SET IssueStatus='closed'
WHERE AssigneeId=6

--P04
DELETE FROM RepositoriesContributors
WHERE RepositoryId=(SELECT Id FROM Repositories
WHERE Repositories.[Name] = 'Softuni-Teamwork')

DELETE FROM Issues
WHERE RepositoryId=(SELECT Id FROM Repositories
WHERE Repositories.[Name] = 'Softuni-Teamwork')

--P05
SELECT Id,[Message], RepositoryId, ContributorId FROM Commits 
ORDER BY Id, [Message], RepositoryId, ContributorId

--P06
SELECT Id,[Name],Size FROM Files
WHERE Size > 1000 AND [Name] LIKE '%html%'
ORDER BY Size DESC, Id, [Name] ASC

--P07
SELECT Issues.Id, Username + ' : '+ Title  FROM Issues, Users
WHERE Issues.AssigneeId=Users.Id
ORDER BY Issues.Id DESC, Issues.AssigneeId ASC

--P08
--SELECT Id, [Name], CAST(Size AS VARCHAR)+ 'KB' Size FROM Files
--WHERE ParentId = (COUNT(*) WHERE 
--ORDER BY Id,[Name] ASC, Size DESC

--P09
SELECT TOP(5) Id, [Message], COUNT(*) AS 'Commits' FROM Commits
--INNER JOIN 
GROUP BY [Message],Id
ORDER BY 'Commits' DESC, Id,[Message] ASC

--P10