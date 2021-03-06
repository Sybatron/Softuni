--P13
CREATE DATABASE Movies

CREATE TABLE Directors(
	 Id INT PRIMARY KEY IDENTITY,
	 DirectorName NVARCHAR(32) NOT NULL,
	 Notes NVARCHAR(MAX)
)

CREATE TABLE Genres(
	Id INT PRIMARY KEY IDENTITY,
	GenreName NVARCHAR(32) NOT NULL,
	Notes NVARCHAR(MAX)
)

CREATE TABLE Categories(
	Id INT PRIMARY KEY IDENTITY,
	CategoryName NVARCHAR(32) NOT NULL,
	Notes NVARCHAR(MAX)
)

CREATE TABLE Movies(
	 Id INT PRIMARY KEY IDENTITY,
	 Title NVARCHAR(128),
	 DirectorId INT REFERENCES Directors(Id),
	 CopyrightYear YEAR(DATE)
)