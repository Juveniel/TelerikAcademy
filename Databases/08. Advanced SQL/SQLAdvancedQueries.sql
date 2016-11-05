USE TelerikAcademy

-- 1. Write a SQL query to find the names and salaries of the employees that take the minimal salary in the company. 
SELECT CONCAT(FirstName, ' ', LastName) AS [Full Name]
FROM Employees AS [e]
WHERE Salary = (
	SELECT MIN(Salary)
	FROM Employees
)

-- 2. Write a SQL query to find the names and salaries of the employees that have a salary that is up to 10% higher than the minimal salary for the company.
SELECT CONCAT(FirstName, ' ', LastName) AS [Full Name], Salary
FROM Employees AS [e]
WHERE Salary < (
	SELECT MIN(Salary) * 1.1
	FROM Employees
)
ORDER BY Salary ASC

-- 3. Write a SQL query to find the full name, salary and department of the employees that take the minimal salary in their department. 
SELECT CONCAT(e.FirstName, ' ', e.LastName) AS [Full Name], e.Salary, d.Name AS[Department]
FROM Employees AS [e], Departments AS[d]
WHERE e.Salary = (
	SELECT MIN(es.Salary)
	FROM Employees AS[es]
	WHERE es.DepartmentID = d.DepartmentID
)
ORDER BY Salary ASC

-- 4. Write a SQL query to find the average salary in the department #1.
SELECT AVG(e.Salary) AS[Average Department Salary]
FROM Employees AS[e]
WHERE e.DepartmentID = 1

-- 5. Write a SQL query to find the average salary in the "Sales" department.
SELECT d.Name AS[Department Name], AVG(e.Salary) AS[Average Department Salary]
FROM Employees AS[e], Departments AS[d]
WHERE e.DepartmentID = d.DepartmentID
GROUP BY d.Name

-- 6. Write a SQL query to find the number of employees in the "Sales" department.
SELECT d.Name AS[Department Name], COUNT(*) AS[Employees Count]
FROM Employees AS[e], Departments AS[d]
WHERE e.DepartmentID = d.DepartmentID 
AND d.Name = 'Sales'
GROUP BY d.Name

-- 7. Write a SQL query to find the number of all employees that have manager.
SELECT COUNT(*) AS[Employees With Manager]
FROM Employees AS[e]
WHERE e.ManagerID IS NOT NULL

-- 8. Write a SQL query to find the number of all employees that have no manager.
SELECT COUNT(*) AS[Employees Without Manager]
FROM Employees AS[e]
WHERE e.ManagerID IS NULL

-- 9. Write a SQL query to find all departments and the average salary for each of them.
SELECT d.Name, AVG(Salary) AS[Average Department Salary]
FROM Employees AS[e] 
INNER JOIN Departments AS[d]
	ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name;

-- 10. Write a SQL query to find the count of all employees in each department and for each town.
SELECT d.Name AS[Department Name],t.Name AS[Town], COUNT(*) AS[Employees Count]
FROM Employees AS[e], Departments AS[d], Towns AS[t], Addresses AS[a]
WHERE e.DepartmentID = d.DepartmentID
AND e.AddressID = a.AddressID 
AND a.TownID = t.TownID
GROUP BY d.Name, t.Name
ORDER BY d.Name ASC

-- 11. Write a SQL query to find all managers that have exactly 5 employees. Display their first name and last name.
SELECT CONCAT(m.FirstName, ' ', m.LastName) AS [Manager Full Name]
FROM Employees AS [m]
WHERE m.EmployeeID IN (
	SELECT e.ManagerID
	FROM Employees AS[e]
	GROUP BY e.ManagerID
	HAVING COUNT(*) = 5
)

-- 12. Write a SQL query to find all employees along with their managers. For employees that do not have manager display the value "(no manager)".
SELECT CONCAT(e.FirstName, ' ', e.LastName) AS[Employee],
	   COALESCE(m.FirstName + ' ' + m.LastName, '(no manager)') AS[Manager]
FROM Employees AS[e] 
LEFT OUTER JOIN Employees AS[m]
	ON e.ManagerID = m.EmployeeID

-- 13. Write a SQL query to find the names of all employees whose last name is exactly 5 characters long. Use the built-in LEN(str) function.
SELECT CONCAT(e.FirstName, ' ', e.LastName) AS[Employee]
FROM Employees AS[e]
WHERE LEN(e.LastName) = 5

-- 14. Write a SQL query to display the current date and time in the following format "day.month.year hour:minutes:seconds:milliseconds". 
SELECT CONVERT(datetime, GETDATE(), 121);

-- 15. Write a SQL statement to create a table Users. Users should have username, password, full name and last login time. 
CREATE TABLE Users (
  Id int IDENTITY PRIMARY KEY,
  Username nvarchar(100) NOT NULL UNIQUE,
  PasswordHash nvarchar(30) NOT NULL,
  FullName nvarchar(150),
  LastLogin date,
  CONSTRAINT Password_C CHECK (LEN(PasswordHash) >= 5)
)

-- 16. Write a SQL statement to create a view that displays the users from the Users table that have been in the system today. 
GO
CREATE VIEW AllUsersToday AS
SELECT * FROM TelerikAcademy.dbo.Users
GO

SELECT * FROM AllUsersToday

-- 17. Write a SQL statement to create a table Groups. Groups should have unique name (use unique constraint). 
CREATE TABLE Groups (
  Id int IDENTITY PRIMARY KEY,
  Name nvarchar(50) NOT NULL UNIQUE
)

-- 18. Write a SQL statement to add a column GroupID to the table Users. 
ALTER TABLE Users
ADD GroupId int

ALTER TABLE Users
ADD CONSTRAINT FK_Users_Groups
FOREIGN KEY (GroupId)
REFERENCES Groups(Id);

-- 19. Write SQL statements to insert several records in the Users and Groups tables.
INSERT INTO Users(Username, PasswordHash, FullName, LastLogin)
VALUES
	('Test1', 'asd23ads2d3ease23e4g23', 'Ivan Ivanov', GETDATE()),
	('Test2', 'asd23a1323e4g23', 'Ivan Petrov', GETDATE()),
	('Test3', 'aseqweqe23', 'Ivan Gochev', GETDATE()),
	('Test4', 'asjghjghj3', 'Ivan Georgiev', GETDATE());

INSERT INTO Groups
VALUES 
	('First grp'), 
	('Second grp'),
	('Third grp');

-- 20. Write SQL statements to update some of the records in the Users and Groups tables.
UPDATE Users
SET PasswordHash = 'AD123ASDs'
WHERE Username = 'Test2'

UPDATE Groups
SET Name = 'Test grp'
WHERE Id = 2

-- 21. Write SQL statements to delete some of the records from the Users and Groups tables.
DELETE FROM Users 
WHERE Id = 1

DELETE FROM Groups 
WHERE Id = 3

-- 22. Write SQL statements to insert in the Users table the names of all employees from the Employees table. 
INSERT INTO Users (Username, PasswordHash, FullName, GroupId)
SELECT 
	 LOWER(FirstName) + CONVERT(nvarchar, EmployeeID),
	 (LEFT(FirstName, 1) + LOWER(LastName) + 'a9sd088qs'),
	 (FirstName + ' ' + LastName),
	 1	
FROM Employees

-- 23. Write a SQL statement that changes the password to NULL for all users that have not been in the system since 10.03.2010.
UPDATE Users
SET PasswordHash = NULL
WHERE LastLogin < '10/03/2010';

-- 24. Write a SQL statement that deletes all users without passwords (NULL password).
DELETE FROM Users
WHERE PasswordHash IS NULL

-- 25. Write a SQL query to display the average employee salary by department and job title.
SELECT d.Name AS[Department], e.JobTitle, AVG(e.Salary) AS[Average Salary]
FROM Employees AS[e]
INNER JOIN Departments AS[d]
	ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name, e.JobTitle
ORDER BY [Average Salary]

-- 26. Write a SQL query to display the minimal employee salary by department and job title along with the name of some of the employees that take it.
SELECT MIN(e.Salary) AS[Minimal Salary], d.Name AS[Department], e.JobTitle, MIN(FirstName) AS[Employee]
FROM Employees AS[e]
INNER JOIN Departments AS[d]
	ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name, e.JobTitle
ORDER BY [Minimal Salary]

-- 27. Write a SQL query to display the town where maximal number of employees work.
SELECT TOP 1 t.Name, COUNT(e.EmployeeID) AS[EmployeesCount]
FROM Employees AS[e] 
JOIN Addresses AS[a]
     ON e.AddressID = a.AddressID
JOIN Towns AS[t]
     ON t.TownID = a.TownID
GROUP BY t.Name
ORDER BY EmployeesCount DESC

-- 28. Write a SQL query to display the number of managers from each town.
SELECT t.Name, COUNT(e.EmployeeID) AS[ManagersCount]
FROM Employees AS[e] 
JOIN Addresses AS[a]
     ON e.AddressID = a.AddressID
JOIN Towns AS[t]
     ON t.TownID = a.TownID
GROUP BY t.Name
ORDER BY ManagersCount DESC

-- 29. Write a SQL to create table WorkHours to store work reports for each employee (employee id, date, task, hours, 
CREATE TABLE WorkHours (
	id int IDENTITY PRIMARY KEY,
	EmployeeId int,
	ScheduleDate datetime,
	Task nvarchar(100),
	WorkHours int,
	Comments nvarchar(300),
	CONSTRAINT FK_Employees_WorkHours 
        FOREIGN KEY (EmployeeId)
		REFERENCES Employees(EmployeeId))

INSERT INTO WorkHours(ScheduleDate, Task, WorkHours)
VALUES
	(GETDATE(), 'Sample Task1', 19),
	(GETDATE(), 'Sample Task2', 12)

DELETE FROM WorkHours
WHERE Task LIKE '%Task1'

UPDATE WorkHours
SET WorkHours = 10
WHERE Task = 'Sample Task2'

CREATE TABLE WorkHoursLogs (
    WorkLogId int,
    EmployeeId Int NOT NULL,
    OnDate DATETIME NOT NULL,
    Task nvarchar(256) NOT NULL,
    Hours Int NOT NULL,
    Comments nvarchar(256),
    [Action] nvarchar(50) NOT NULL,
    CONSTRAINT FK_Employees_WorkHoursLogs
        FOREIGN KEY (EmployeeId)
        REFERENCES Employees(EmployeeId),    
) 
GO

--- TRIGGER FOR INSERT
CREATE TRIGGER tr_InsertWorkReports ON WorkHours FOR INSERT
AS
INSERT INTO WorkHoursLogs(WorkLogId, EmployeeId, OnDate, Task, [Hours], Comments, [Action])
    SELECT Id, EmployeeID, ScheduleDate, Task, [WorkHours], Comments, 'Insert'
    FROM inserted
GO

--- TRIGGER FOR DELETE
CREATE TRIGGER tr_DeleteWorkReports ON WorkHours FOR DELETE
AS
INSERT INTO WorkHoursLogs(WorkLogId, EmployeeId, OnDate, Task, [Hours], Comments, [Action])
    SELECT Id, EmployeeID, ScheduleDate, Task, [WorkHours], Comments, 'Delete'
    FROM deleted
GO

--- TRIGGER FOR UPDATE
CREATE TRIGGER tr_UpdateWorkReports ON WorkHours FOR UPDATE
AS
INSERT INTO WorkHoursLogs(WorkLogId, EmployeeId, OnDate, Task, [Hours], Comments, [Action])
    SELECT Id, EmployeeID, ScheduleDate, Task, [WorkHours], Comments, 'InsertUpdate'
    FROM inserted

INSERT INTO WorkHoursLogs(WorkLogId, EmployeeId, OnDate, Task, [Hours], Comments, [Action])
    SELECT Id, EmployeeID, ScheduleDate, Task, [WorkHours], Comments, 'DeleteUpdate'
    FROM deleted
GO

--- TEST TRIGGERS
DELETE FROM WorkHoursLogs

INSERT INTO WorkHours(EmployeeId, ScheduleDate, Task, [WorkHours])
VALUES (25, GETDATE(), 'TASK: 25', 25)

DELETE FROM WorkHours
WHERE EmployeeId = 25

UPDATE WorkHours
SET Comments = 'Updated'
WHERE EmployeeId = 2

-- 30. Start a database transaction, delete all employees from the 'Sales' department along with all dependent records from the pother tables. 
BEGIN TRAN

DELETE FROM Employees
FROM Departments
WHERE Name = 'Sales'

DELETE FROM Employees
FROM Employees e 
  JOIN Departments d
    ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'

ROLLBACK TRAN

-- 31. Start a database transaction and drop the table EmployeesProjects. 
BEGIN TRAN
DROP TABLE EmployeesProjects
ROLLBACK TRAN