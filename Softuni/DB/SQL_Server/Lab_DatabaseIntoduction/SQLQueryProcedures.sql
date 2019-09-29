--CREATE PROC p_AddAccount @ClientId INT, @AccountTypeId INT AS
--INSERT INTO Accounts (ClientId, AccountTypeId)
--VALUES (@ClientId, @AccountTypeId)

--p_AddAccount 2, 2
--SELECT * FROM Accounts

CREATE PROC p_AddAccount @ClientId INT, @AccountTypeId INT AS
INSERT INTO Accounts (ClientId, AccountTypeId)
Values(@ClientId, @AccountTypeId)

p_AddAccount 2,2
SELECT * FROM Accounts

--CREATE PROC p_Deposit @AccountId INT, @Amount DECIMAL(15, 2) AS
--UPDATE Accounts
--SET Balance += @Amount
--WHERE Id = @AccountId

CREATE PROC p_Deposit @AccountId INT, @Amount DECIMAL(15,2) AS
UPDATE Accounts
SET Balance += @Amount
WHERE Id = @AccountId

p_Deposit 8, 130.45
SELECT * FROM Accounts

--CREATE PROC p_Withdraw @AccountId INT, @Amount DECIMAL(15, 2) AS
--BEGIN
--DECLARE @OldBalance DECIMAL(15, 2)
--SELECT @OldBalance = Balance FROM Accounts WHERE Id = @AccountId
--IF (@OldBalance - @Amount &gt;= 0)
--BEGIN
--UPDATE Accounts
--SET Balance -= @Amount
--WHERE Id = @AccountId
--END
--ELSE
--BEGIN
--RAISERROR(&#39;Insufficient funds&#39;, 10, 1)
--END
--END

CREATE PROC p_Withdraw @AccountId INT, @Amount DECIMAL(15, 2) AS
BEGIN
	DECLARE @OldBalance DECIMAL(15, 2)
	SELECT @OldBalance = Balance FROM Accounts WHERE Id = @AccountId
	IF(@OldBalance - @Amount >= 0)
	BEGIN
		UPDATE Accounts
		SET Balance -= @Amount
		WHERE Id = @AccountId
	END
	ELSE
	BEGIN
		RAISERROR('Insufficient funds', 10, 1)
	END
END

p_Withdraw 1, 50.3
SELECT * FROM Accounts
