CREATE TABLE Clients(
	Id INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(50) NOT NULL,
	LastName NVARCHAR(50) NOT NULL
)

CREATE TABLE AccountTypes(
	Id INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(50) NOT NULL
)

--Accounts
--Id - unique number for every user. (Auto incremented, primary key)
-- AccountTypeId – references the AccountTypes table (foreign key)
-- Balance – decimal data type with up to 15 digits including 
--2 after the decimal point and a default value
--of 0 (Not null)
-- ClientId – references the Clients table (foreign key)

CREATE TABLE Accounts(
	Id INT PRIMARY KEY IDENTITY,
	AccountTypeId INT FOREIGN KEY REFERENCES AccountTypes(Id),
	Balance DECIMAL(15, 2) NOT NULL DEFAULT(0),
	ClientId INT FOREIGN KEY REFERENCES Clients(Id)
)