CREATE DATABASE School

GO

USE School

GO

--P01
CREATE TABLE Students(
	Id INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(30) NOT NULL,
	MiddleName NVARCHAR(25),
	LastName NVARCHAR(30) NOT NULL,
	Age INT CHECK(Age > 0),
	[Address] NVARCHAR(50),
	Phone NCHAR(10)
)

CREATE TABLE Subjects(
	Id INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(20) NOT NULL,
	Lessons INT NOT NULL CHECK(Lessons > 0)
)

CREATE TABLE StudentsSubjects(
	Id INT PRIMARY KEY IDENTITY,
	StudentId INT NOT NULL FOREIGN KEY REFERENCES Students(Id),
	SubjectId INT NOT NULL FOREIGN KEY REFERENCES Subjects(Id),
	Grade DECIMAL(3,2) NOT NULL CHECK(Grade >= 2 AND Grade <= 6) 
)

CREATE TABLE Exams(
	Id INT PRIMARY KEY IDENTITY,
	[Date] DATETIME2,
	SubjectId INT NOT NULL FOREIGN KEY REFERENCES Subjects(Id)
)

CREATE TABLE StudentsExams(
	StudentId INT NOT NULL FOREIGN KEY REFERENCES Students(Id),
	ExamId INT NOT NULL FOREIGN KEY REFERENCES Exams(Id),
	Grade DECIMAL(3,2) NOT NULL CHECK(Grade >= 2 AND Grade <= 6) 
)

CREATE TABLE Teachers(
	Id INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(20) NOT NULL,
	LastName NVARCHAR(20) NOT NULL,
	[Address] NVARCHAR(20) NOT NULL,
	Phone NCHAR(10),
	SubjectId INT NOT NULL FOREIGN KEY REFERENCES Subjects(Id)
)

CREATE TABLE StudentsTeachers(
	StudentId INT NOT NULL,
	TeacherId INT NOT NULL,

CONSTRAINT PK_StudentsTeachers PRIMARY KEY (StudentId, TeacherId),
CONSTRAINT FK_StudentsTeachers_Students FOREIGN KEY (StudentId) REFERENCES Students (Id),
CONSTRAINT FK_StudentsTeachers_Teachers FOREIGN KEY (TeacherId) REFERENCES Teachers (Id),
)

--P02
INSERT INTO Subjects([Name], Lessons)
VALUES
('Geometry', 12),
('Health', 10),
('Drama', 7),
('Sports', 9)

INSERT INTO Teachers(FirstName, LastName, [Address], Phone, SubjectId)
VALUES
('Ruthanne', 'Bamb', '84948 Mesta Junction', '3105500146', 6),
('Gerrard', 'Lowin', '370 Talisman Plaza', '3324874824', 2),
('Merrile', 'Lambdin', '81 Dahle Plaza', '4373065154', 5),
('Bert', 'Ivie', '2 Gateway Circle', '4409584510', 4)

--P03
UPDATE StudentsSubjects
SET Grade = 6.00
WHERE (SubjectId = 1 OR SubjectId = 2) AND Grade >= 5.50

--P04
--studentsteachers and teachers
DELETE StudentsTeachers
WHERE TeacherId IN (SELECT Id FROM Teachers
					WHERE Phone LIKE '%72%'
)

DELETE Teachers
WHERE Phone LIKE '%72%'

--P05
SELECT FirstName, LastName, Age FROM Students
WHERE Age >= 12
ORDER BY FirstName, LastName

--P06
SELECT s.FirstName, s.LastName, COUNT(t.Id) AS [TeachersCount] FROM Students AS s
JOIN StudentsTeachers AS st
ON st.StudentId = s.Id
JOIN Teachers AS t
ON st.TeacherId = t.Id
GROUP BY s.FirstName, s.LastName

--P07
SELECT CONCAT(s.FirstName, ' ', s.LastName) AS [Full Name] FROM Students AS s
LEFT OUTER JOIN StudentsExams AS se
ON se.StudentId = s.Id
WHERE se.StudentId IS NULL
ORDER BY [Full Name]

--P08
SELECT TOP(10)s.FirstName AS [First Name]
		, s.LastName AS [Last Name]
		, CAST(AVG(se.Grade) AS DECIMAL(3,2)) AS [Grade] 
FROM Students AS s
JOIN StudentsExams AS se
ON se.StudentId = s.Id
GROUP BY s.FirstName, s.LastName
ORDER BY Grade DESC, [First Name], [Last Name]

--P09
SELECT (CONCAT(s.FirstName,' ',ISNULL(s.MiddleName + ' ',''),s.LastName)) AS [Full Name]
FROM Students AS s
LEFT OUTER JOIN StudentsSubjects AS ss
ON ss.StudentId = s.Id
WHERE ss.SubjectId IS NULL
GROUP BY s.FirstName, s.MiddleName, s.LastName

--P10
SELECT sb.[Name], AVG(ss.Grade) AS [AverageGrade] FROM StudentsSubjects AS ss
JOIN Subjects AS sb
ON ss.SubjectId = sb.Id
GROUP BY sb.[Name], sb.Id
ORDER BY sb.Id

--P11
CREATE FUNCTION udf_ExamGradesToUpdate(
@studentId INT, @grade DECIMAL(15,2))
RETURNS VARCHAR(MAX) AS
BEGIN
	DECLARE @studentExist INT = (
	SELECT TOP(1)StudentId FROM StudentsExams
	WHERE StudentId = @studentId
	)

	IF (@studentExist IS NULL)
	BEGIN
		RETURN 'The student with provided id does not exist in the school!'
	END

	IF @grade > 6
	BEGIN
		RETURN 'Grade cannot be above 6.00!'
	END

	DECLARE @count INT = (
		SELECT COUNT(Grade) FROM StudentsExams
		WHERE  StudentId = @studentId
				AND Grade >= @grade 
				AND Grade <= @grade + 0.5
	)

	DECLARE @firstName  NVARCHAR(30)= (
		SELECT FirstName FROM Students
		WHERE Id = @studentId				
	)

	RETURN CONCAT('You have to update ', CAST(@count AS VARCHAR(10)), ' grades for the student ', @firstName)
END
SELECT dbo.udf_ExamGradesToUpdate(121, 5.50)
