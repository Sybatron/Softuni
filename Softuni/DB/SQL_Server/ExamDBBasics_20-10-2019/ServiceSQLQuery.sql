CREATE DATABASE [Service]

GO

USE [Service]

GO

--P01 
CREATE TABLE Users(
	Id INT PRIMARY KEY IDENTITY,
	Username VARCHAR(30) UNIQUE NOT NULL,
	[Password] VARCHAR(50) NOT NULL,
	[Name] VARCHAR(50),
	Birthdate DATETIME2,
	Age INT CHECK(Age >= 14 AND Age <= 110),
	Email VARCHAR(50) NOT NULL
)

CREATE TABLE Departments(
	Id INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(50) NOT NULL
)

CREATE TABLE [Status](
	Id INT PRIMARY KEY IDENTITY,
	Label VARCHAR(30) NOT NULL
)

CREATE TABLE Employees(
	Id INT PRIMARY KEY IDENTITY,
	FirstName VARCHAR(25),
	LastName VARCHAR(25),
	Birthdate DATETIME2,
	Age INT CHECK(Age >= 18 AND Age <= 110),
	DepartmentId INT FOREIGN KEY REFERENCES Departments(Id)
)

CREATE TABLE Categories(
	Id INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(50) NOT NULL,
	DepartmentId INT NOT NULL FOREIGN KEY REFERENCES Departments(Id)
)

CREATE TABLE Reports(
	Id INT PRIMARY KEY IDENTITY,
	CategoryId INT NOT NULL FOREIGN KEY REFERENCES Categories(Id),
	StatusId INT NOT NULL FOREIGN KEY REFERENCES [Status](Id),
	OpenDate DATETIME2 NOT NULL,
	CloseDate DATETIME2,
	[Description] VARCHAR(200) NOT NULL,
	UserId INT NOT NULL FOREIGN KEY REFERENCES Users(Id),
	EmployeeId INT FOREIGN KEY REFERENCES Employees(Id)
)

--P02
INSERT INTO Employees(FirstName, LastName, Birthdate, DepartmentId)
VALUES
('Marlo', 'O''Malley', CAST('1958-9-21' AS DATETIME2), 1),
('Niki', 'Stanaghan', CAST('1969-11-26' AS DATETIME2), 4),
('Ayrton', 'Senna', CAST('1960-03-21' AS DATETIME2),	9),
('Ronnie', 'Peterson', CAST('1944-02-14' AS DATETIME2), 9),
('Giovanna', 'Amati', CAST('1959-07-20' AS DATETIME2), 5)

INSERT INTO Reports(CategoryId, StatusId, OpenDate, CloseDate, [Description], UserId, EmployeeId)
VALUES
(1, 1, CAST('2017-04-13' AS DATETIME2), NULL, 'Stuck Road on Str.133', 6, 2),
(6, 3, CAST('2015-09-05' AS DATETIME2), CAST('2015-12-06' AS DATETIME2), 'Charity trail running', 3, 5),
(14, 2, CAST('2015-09-07' AS DATETIME2), NULL, 'Falling bricks on Str.58', 5, 2),
(4, 3, CAST('2017-07-03' AS DATETIME2), CAST('2017-07-06' AS DATETIME2), 'Cut off streetlight on Str.11', 1, 1)

--P03
UPDATE Reports
SET CloseDate = CAST(GETDATE() AS DATETIME2)
WHERE CloseDate IS NULL

--P04
DELETE FROM Reports
WHERE StatusId = 4

--P05
SELECT [Description], CONVERT(VARCHAR, OpenDate, 105) AS [OpenDate] FROM Reports
WHERE EmployeeId IS NULL
ORDER BY Reports.OpenDate, [Description]

--P06
SELECT r.[Description], c.[Name] AS [CategoryName] FROM Reports AS r
JOIN Categories AS c
ON r.CategoryId = c.Id
ORDER BY r.[Description], [CategoryName]

--P07
SELECT TOP(5) c.[Name] AS [CategoryName], COUNT(r.CategoryId) AS [ReportsNumber] FROM Categories AS c
JOIN Reports AS r
ON r.CategoryId = c.Id
GROUP BY c.[Name]
ORDER BY [ReportsNumber] DESC, [CategoryName]

--P08
SELECT u.Username, c.[Name] AS [CategoryName] FROM Users AS u
JOIN Reports AS r
ON r.UserId = u.Id
JOIN Categories AS c
ON r.CategoryId = c.Id
WHERE CONVERT(VARCHAR(5), u.Birthdate, 3) = CONVERT(VARCHAR(5), r.OpenDate, 3) 
ORDER BY u.Username, [CategoryName]

--P09
SELECT DISTINCT CONCAT(e.FirstName, ' ', e.LastName) AS [FullName], COUNT(r.UserId) AS [UsersCount]
FROM Employees AS e
LEFT OUTER JOIN Reports AS r
ON r.EmployeeId = e.Id
GROUP BY FirstName, LastName
ORDER BY [UsersCount] DESC ,[FullName]

--P10
SELECT 
CASE WHEN e.FirstName IS NULL OR e.LastName IS NULL THEN 'None' ELSE CONCAT(e.FirstName, ' ', e.LastName) END AS [Employee], 
ISNULL(d.[Name], 'None') AS [Department], 
ISNULL(c.[Name], 'None') AS [Category], 
ISNULL(r.[Description], 'None') AS [Description],
ISNULL(CONCAT( CONVERT(VARCHAR(6), r.OpenDate, 4), CONVERT(VARCHAR(4), r.OpenDate, 23) ), 'None') AS [OpenDate],
ISNULL(s.Label, 'None') AS [Status],
ISNULL(u.[Name], 'None') AS [User]
FROM Employees AS e
FULL OUTER JOIN Reports AS r
ON r.EmployeeId = e.Id
LEFT OUTER JOIN Departments AS d
ON e.DepartmentId = d.Id
LEFT OUTER JOIN Categories AS c
ON r.CategoryId = c.Id
LEFT OUTER JOIN [Status] AS s
ON r.StatusId = s.Id
LEFT OUTER JOIN Users AS u
ON r.UserId = u.Id
WHERE c.[Name] IS NOT NULL AND r.[Description] IS NOT NULL AND s.Label IS NOT NULL AND u.[Name] IS NOT NULL
ORDER BY 
CASE WHEN e.FirstName IS NULL OR
		  e.LastName IS NULL OR
		  d.[Name] IS NULL OR 
		  c.[Name] IS NULL OR 
		  [Description] IS NULL OR
		  [OpenDate] IS NULL OR
		  s.Label IS NULL OR
		  u.[Name] IS NULL 
		  THEN 1 ELSE 0 END ASC, 
e.FirstName DESC,
e.LastName DESC, 
[Department] ASC, 
[Category] ASC, 
[Description] ASC,
[OpenDate] ASC, 
[Status] ASC, 
[User] ASC

--P11
CREATE FUNCTION udf_HoursToComplete(@StartDate DATETIME2, @EndDate DATETIME2)
RETURNS INT
AS
BEGIN
	IF @StartDate IS NULL OR @EndDate IS NULL
	BEGIN
		RETURN 0
	END

	RETURN DATEDIFF(HOUR, @StartDate, @EndDate) 
END

SELECT dbo.udf_HoursToComplete(OpenDate, CloseDate) AS TotalHours
   FROM Reports

--P12
CREATE PROCEDURE usp_AssignEmployeeToReport(@EmployeeId INT, @ReportId INT)
AS
BEGIN
	DECLARE @isChangePossible INT = (
								SELECT TOP(1)r.Id FROM Reports AS r
								JOIN Employees AS e
								ON r.EmployeeId = e.Id
								JOIN Categories AS c
								ON r.CategoryId = c.Id
								WHERE @EmployeeId = e.Id AND r.Id = @ReportId AND e.DepartmentId = c.DepartmentId 
)
	IF @isChangePossible IS  NULL
	BEGIN
		RAISERROR('Employee doesn''t belong to the appropriate department!', 16, 1)
	END

	UPDATE Reports
	SET EmployeeId = @EmployeeId
	WHERE Id = @ReportId
END

EXEC usp_AssignEmployeeToReport 30, 1
EXEC usp_AssignEmployeeToReport 17, 2

DECLARE @err_msg AS NVARCHAR(MAX);
BEGIN TRY
EXEC usp_AssignEmployeeToReport 30,1
END TRY

BEGIN CATCH
SET @err_msg = ERROR_MESSAGE();
SELECT @err_msg
END CATCH