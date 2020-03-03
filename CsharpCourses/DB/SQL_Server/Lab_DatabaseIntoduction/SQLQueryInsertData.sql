--INSERT INTO Clients (FirstName, LastName) VALUES
--(&#39;Gosho&#39;, &#39;Ivanov&#39;),
--(&#39;Pesho&#39;, &#39;Petrov&#39;),
--(&#39;Ivan&#39;, &#39;Iliev&#39;),
--(&#39;Merry&#39;, &#39;Ivanova&#39;)
--INSERT INTO AccountTypes (Name) VALUES
--(&#39;Checking&#39;),
--(&#39;Savings&#39;)
--INSERT INTO Accounts (ClientId, AccountTypeId, Balance)
--VALUES
--(1, 1, 175),
--(2, 1, 275.56),
--(3, 1, 138.01),
--(4, 1, 40.30),
--(4, 2, 375.50)

INSERT INTO Clients (FirstName, LastName) 
VALUES
	('Gosho', 'Ivanov'),
	('Pesho', 'Petrov'),
	('Ivan', 'Iliev'),
	('Merry', 'Ivanova');

INSERT INTO AccountTypes (Name) 
VALUES
	('Checking'),
	('Savings');

INSERT INTO Accounts (ClientId, AccountTypeId, Balance) 
VALUES
	(1, 1, 175),
	(2, 1, 275.56),
	(3, 1, 138.01),
	(4, 1, 40.30),
	(4, 2, 375.50);