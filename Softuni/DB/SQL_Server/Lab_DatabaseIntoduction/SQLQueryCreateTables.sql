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

--Transactions
--Id – unique number for every transaction. (auto-incremented, primary key)
-- AccountId – references the Accounts table (foreign key)

--© Software University Foundation. This work is licensed under the CC-BY-NC-SA license.
--Follow us: Page 4 of 5

-- OldBalance – the balance before the transaction
-- NewBalance – the balance after the transaction
-- Amount – the amount transferred (calculated column)
-- DateTime – the date and time of the transaction (as datetime2 data type)

CREATE TABLE Transactions(
	Id INT PRIMARY KEY IDENTITY,
	AccountId INT FOREIGN KEY REFERENCES AccountTypes(Id),
	OldBalance DECIMAL(15,2) NOT NULL,
	NewBalance DECIMAL(15,2) NOT NULL,
	Amount AS NewBalance - OldBalance,
	[DateTime] DATETIME2
)

