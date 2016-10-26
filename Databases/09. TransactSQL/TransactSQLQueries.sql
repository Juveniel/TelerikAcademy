-- 1. Create a database with two tables: Persons(Id(PK), FirstName, LastName, SSN) and Accounts(Id(PK), PersonId(FK), Balance).  

USE PersonalAccounts

CREATE TABLE Persons(
	Id int IDENTITY PRIMARY KEY ,
	FirstName nvarchar(50),
	LastName nvarchar(50),
	SSN nvarchar(50)
)
GO

CREATE TABLE Accounts(
	Id int IDENTITY PRIMARY KEY,
	PersonId int,
	Balance money,
	CONSTRAINT FK_Accounts_People
        FOREIGN KEY (PersonId)
		REFERENCES Persons(Id)
)


INSERT INTO Persons 
	VALUES 
	('Ivan', 'Petrov', '123'),
	('Goshka', 'Georgieva', '64564'),
	('Petar', 'Petrov', '24334456'),
	('Gencho', 'Genchev', '6778634')
GO

INSERT INTO Accounts
	VALUES
	(1, 25505),
	(2, 12356),
	(3, 150000),
	(4, 10000000)
GO

CREATE PROC usp_SelectAllPersonsFullName
AS
  SELECT (FirstName + ' ' + LastName) AS[FullName]
  FROM Persons
GO

EXEC usp_SelectAllPersonsFullName

-- 2. Create a stored procedure that accepts a number as a parameter and returns all persons who have more money in their accounts than the supplied number.
GO

CREATE PROC usp_SelectAllAcountsWithGivenBalance(@minBalance int = 0) AS

  SELECT FirstName + ' ' + LastName as FullName, Balance 
  FROM Persons AS[p]
  JOIN Accounts AS[a]
	ON p.id = a.PersonId	
   WHERE a.Balance > @minBalance
   ORDER BY Balance

   GO

EXEC usp_SelectAllAcountsWithGivenBalance 1000

-- 3. Create a function that accepts as parameters – sum, yearly interest rate and number of months. 
GO

CREATE FUNCTION ufn_CalcSum(@sum money, @yearlyInterestRate int, @numberOfMonths int)
  RETURNS money
AS
BEGIN
  SET @sum = @sum + @numberOfMonths / @yearlyInterestRate

  RETURN @sum
END

GO

SELECT dbo.ufn_CalcSum(1231, 10, 24)

GO

-- 4. Create a stored procedure that uses the function from the previous example to give an interest to a person's account for one month. 
CREATE PROC usp_UpdateBalanceWithInterestForOneMonth(@accountId int = 0, @intrestRate money) AS
	UPDATE Accounts
	SET Balance = Balance + dbo.ufn_CalcSum(Balance, @intrestRate, 1)
	WHERE id = @accountId
 GO

EXEC usp_UpdateBalanceWithInterestForOneMonth 1, 20

-- 5. Add two more stored procedures WithdrawMoney(AccountId, money) and DepositMoney(AccountId, money) that operate in transactions.
GO

CREATE PROC usp_WithdrawMoney(@accountId int, @sumAmount money) AS
	BEGIN TRAN
	DECLARE @currentAmaount money
	UPDATE Accounts
	SET Balance = Balance - @sumAmount,
	@currentAmaount = Balance - @sumAmount
	WHERE id = @accountId

	IF(@currentAmaount < 0)
		ROLLBACK TRAN
 GO
 
 CREATE PROC usp_DepositMoney(@accountId int, @sumAmount money) AS
	BEGIN TRAN
	DECLARE @currentAmaount money
	UPDATE Accounts
	SET Balance = Balance + @sumAmount,
	@accountId = Balance + @sumAmount
	WHERE id = @AccountId

	IF(@currentAmaount < 0)
		ROLLBACK TRAN
	ElSE
		COMMIT TRAN
GO

EXEC usp_DepositMoney 1, 100

-- 6. Create another table – Logs(LogID, AccountID, OldSum, NewSum).
   --## Add a trigger to the Accounts table that enters a new entry into the Logs table every time the sum on an account changes.

CREATE TABLE Logs (
	LogId int IDENTITY PRIMARY KEY,
	AccountId int,
	OldSum money,
	NewSum money
)

GO


CREATE TRIGGER tr_UpdateAccountBalance ON Accounts FOR UPDATE
AS
	BEGIN
		DECLARE @oldSum money;
		SELECT @oldSum = Balance FROM deleted;

		INSERT INTO Logs(AccountId, OldSum, NewSum)
			SELECT Id, @oldSum, Balance
			FROM inserted
	END
GO

EXEC usp_WithdrawMoney 1, 1000

-- 7. Define a function in the database TelerikAcademy that returns all Employee's names (first or middle or last name) and all town's names that are comprised of given set of letters. 
GO	

USE TelerikAcademy

GO

CREATE FUNCTION CheckIfHasLetters (@word nvarchar(20), @letters nvarchar(20))
RETURNS BIT
AS
BEGIN

DECLARE @lettersLen int = LEN(@letters),
@matches int = 0,
@currentChar nvarchar(1)

WHILE(@lettersLen > 0)
BEGIN
SET @currentChar = SUBSTRING(@letters, @lettersLen, 1)
IF(CHARINDEX(@currentChar, @word, 0) > 0)
BEGIN
SET @matches += 1
SET @lettersLen -= 1
END
ELSE
SET @lettersLen -= 1
END

IF(@matches >= LEN(@word) OR @matches >= LEN(@letters))
RETURN 1

RETURN 0
END

GO

CREATE FUNCTION NamesAndTowns(@letters nvarchar(20))
RETURNS @ResultTable TABLE
(
Name varchar(50) NOT NULL
)
AS
BEGIN

INSERT INTO @ResultTable
SELECT LastName FROM Employees

INSERT INTO @ResultTable
SELECT FirstName FROM Employees

INSERT INTO @ResultTable
SELECT towns.Name FROM Towns towns

DELETE FROM @ResultTable
WHERE dbo.CheckIfHasLetters(Name, @letters) = 0

RETURN
END

GO

SELECT * FROM dbo.NamesAndTowns('')

-- 8. Using database cursor write a T-SQL script that scans all employees and their addresses and prints all pairs of employees that live in the same town.
GO

CREATE PROCEDURE usp_EmployeesInTown @results CURSOR VARYING OUTPUT
AS
BEGIN

SET @results = CURSOR FOR

SELECT emp.LastName, towns.Name FROM Employees emp
JOIN Addresses addr
	ON emp.AddressID = addr.AddressID
JOIN Towns towns
	ON addr.TownID = towns.TownID
GROUP BY towns.TownID, towns.Name, emp.LastName

OPEN @results
END

GO

DECLARE @employeesInTowns CURSOR
DECLARE @LastName varchar(20), @TownName varchar(20)

EXEC usp_EmployeesInTown @results = @employeesInTowns OUTPUT