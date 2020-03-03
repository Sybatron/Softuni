--P01
CREATE DATABASE Airport

GO

USE Airport

GO

CREATE TABLE Planes(
	[Id] INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(30) NOT NULL,
	[Seats] INT NOT NULL,
	[Range] INT NOT NULL
)

CREATE TABLE Flights(
	[Id] INT PRIMARY KEY IDENTITY,
	[DepartureTime] DATETIME2,
	[ArrivalTime] DATETIME2,
	[Origin] VARCHAR(50) NOT NULL,
	[Destination] VARCHAR(50) NOT NULL,
	[PlaneId] INT FOREIGN KEY REFERENCES Planes(Id) NOT NULL
)

CREATE TABLE Passengers(
	[Id] INT PRIMARY KEY IDENTITY,
	[FirstName] VARCHAR(30) NOT NULL,
	[LastName] VARCHAR(30) NOT NULL,
	[Age] INT NOT NULL,
	[Address] VARCHAR(30) NOT NULL,
	[PassportId] CHAR(11) NOT NULL
)

CREATE TABLE LuggageTypes(
	 [Id] INT PRIMARY KEY IDENTITY,
	 [Type] VARCHAR(30) NOT NULL
)

CREATE TABLE Luggages(
	[Id] INT PRIMARY KEY IDENTITY,
	[LuggageTypeId] INT FOREIGN KEY REFERENCES LuggageTypes(Id) NOT NULL,
	PassengerId INT FOREIGN KEY REFERENCES Passengers(Id) NOT NULL
)

CREATE TABLE Tickets(
	[Id] INT PRIMARY KEY IDENTITY,
	[PassengerId] INT FOREIGN KEY REFERENCES Passengers(Id) NOT NULL,
	[FlightId] INT FOREIGN KEY REFERENCES Flights(Id) NOT NULL,
	[LuggageId] INT FOREIGN KEY REFERENCES Luggages(Id) NOT NULL,
	[Price] DECIMAL(18,2) NOT NULL
)

--P02
INSERT INTO Planes([Name], Seats, [Range])
VALUES
('Airbus 336', 112, 5132),
('Airbus 330', 432, 5325),
('Boeing 369', 231, 2355),
('Stelt 297', 254, 2143),
('Boeing 338', 165, 5111),
('Airbus 558', 387, 1342),
('Boeing 128', 345, 5541)

INSERT INTO LuggageTypes([Type])
VALUES
('Crossbody Bag'),
('School Backpack'),
('Shoulder Bag')

--P03
UPDATE Tickets
SET Price *= 1.13
WHERE FlightId IN (
					SELECT Id FROM Flights
					WHERE Destination = 'Carlsbad'
)

--P04
DELETE FROM Tickets
WHERE FlightId IN (
			 SELECT Id FROM Flights
			 WHERE Destination = 'Ayn Halagim'
)

DELETE FROM Flights
WHERE Destination = 'Ayn Halagim'

--P05
--Wildcards
SELECT Id, [Name], Seats, [Range] FROM Planes
WHERE [Name] LIKE '%tr%'
ORDER BY Id, [Name], Seats, [Range] ASC

--Built-In Func
SELECT Id, [Name], Seats, [Range] FROM Planes
WHERE CHARINDEX('tr', [Name]) > 0
ORDER BY Id, [Name], Seats, [Range] ASC

--P06
SELECT FlightId, SUM(Price) AS Price FROM Tickets
GROUP BY FlightId
ORDER BY Price DESC, FlightId ASC

--Author Solution
--InnerJoin
SELECT f.Id AS [FlightId], SUM(t.Price) AS [Price]
FROM Flights AS f
JOIN Tickets AS t
ON t.FlightId=f.Id
GROUP BY f.Id
ORDER BY Price DESC, FlightId ASC

--P07
SELECT CONCAT(p.FirstName, ' ', p.LastName) AS [Full Name], Origin, Destination
FROM Passengers as p
JOIN Tickets AS t
ON t.PassengerId=p.Id
JOIN Flights AS f
ON t.FlightId=f.Id
ORDER BY [Full Name], Origin, Destination ASC

--P08
 SELECT p.FirstName AS [First Name], p.LastName AS [Last Name], p.Age
 FROM Passengers AS p
 LEFT OUTER JOIN Tickets AS t
 ON t.PassengerId = p.Id
 WHERE t.Id IS NULL
 ORDER BY p.Age DESC, [First Name], [Last Name] ASC

 --P09
 SELECT CONCAT(p.FirstName, ' ',p.LastName) AS [Full Name], pl.[Name] AS [Plane Name], CONCAT(f.Origin, ' - ', f.Destination) AS [Trip], lt.[Type] AS [Luggage Type]
 FROM Passengers AS p
 JOIN Tickets AS t
 ON t.PassengerId = p.Id
 JOIN Flights AS f
 ON t.FlightId = f.Id
 JOIN Planes AS pl
 ON f.PlaneId = pl.Id
 JOIN Luggages AS l
 ON t.LuggageId=l.Id
 JOIN LuggageTypes AS lt
 ON l.LuggageTypeId =lt.Id
 ORDER BY [Full Name], [Plane Name], f.Origin, f.Destination, [Luggage Type]

 --P10
 SELECT pl.[Name], pl.Seats, COUNT(t.Id) AS [Passengers Count]
 FROM Planes AS pl
 LEFT OUTER JOIN Flights AS f
 ON f.PlaneId = pl.Id
 LEFT OUTER JOIN Tickets AS t
 ON t.FlightId = f.Id
 --JOIN Passengers AS p
 --ON t.PassengerId=p.Id
 GROUP BY pl.[Name], pl.Seats
 ORDER BY [Passengers Count] DESC, pl.[Name], pl.Seats

 --P11
 CREATE FUNCTION udf_CalculateTickets(
 @origin VARCHAR(50),
 @destination VARCHAR(50),
 @peopleCount INT
 ) 
 RETURNS VARCHAR(32)
 AS
 BEGIN
	IF(@peopleCount <= 0)
	BEGIN
		RETURN 'Invalid people count!'
	END

	DECLARE @flightId INT= (SELECT TOP(1)Id FROM Flights WHERE Origin = @origin AND Destination = @destination) 

	IF(@flightId IS NULL)
	BEGIN
		RETURN 'Invalid flight!'
	END

	DECLARE @pricePerPerson DECIMAL(18,2) = (SELECT TOP(1)Price FROM Tickets WHERE FlightId = @flightId)

	DECLARE @totalPrice DECIMAL(24,2) = @pricePerPerson * @peopleCount

	RETURN CONCAT('Total price ', @totalPrice)
 END;

 --P12
 CREATE PROC usp_CancelFlights
 AS
 BEGIN
	UPDATE Flights
	SET DepartureTime = NULL, ArrivalTime = NULL
	WHERE DATEDIFF(SECOND, DepartureTime, ArrivalTime) > 0
 END

EXEC usp_CancelFlights
 DROP PROCEDURE usp_CancelFlights