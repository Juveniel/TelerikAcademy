USE TelerikAcademy

-- 4. Write a SQL query to find all information about all departments
SELECT * 
FROM Departments

-- 5. Write a SQL query to find all department names.
SELECT Name 
FROM Departments

-- 6. Write a SQL query to find the salary of each employee.
SELECT Salary 
FROM Employees

-- 7. Write a SQL to find the full name of each employee.
SELECT CONCAT(FirstName, ' ', LastName) AS [FullName] 
FROM Employees

-- 8. Write a SQL query to find the email addresses of each employee (by his first and last name).
SELECT CONCAT(FirstName, '.', LastName, '@telerik.com') AS [Full Email Addresses] 
FROM Employees

-- 9. Write a SQL query to find all different employee salaries.
SELECT DISTINCT Salary 
FROM Employees

-- 10. Write a SQL query to find all information about the employees whose job title is “Sales Representative“.
SELECT * FROM Employees 
WHERE JobTitle = 'Sales Representative'

-- 11. Write a SQL query to find the names of all employees whose first name starts with "SA".
SELECT FirstName, LastName 
FROM Employees
WHERE FirstName LIKE 'SA%'

-- 12. Write a SQL query to find the names of all employees whose last name contains "ei".
SELECT FirstName, LastName 
FROM Employees
WHERE LastName LIKE '%ei%'

-- 13. Write a SQL query to find the salary of all employees whose salary is in the range [20000…30000].
SELECT Salary 
FROM Employees
WHERE Salary BETWEEN 20000 AND 30000

-- 14. Write a SQL query to find the names of all employees whose salary is 25000, 14000, 12500 or 23600.
SELECT FirstName, LastName, Salary
FROM Employees
WHERE Salary IN(25000, 14000, 12500, 23600)

-- 15. Write a SQL query to find all employees that do not have manager.
SELECT * 
FROM Employees
WHERE ManagerID IS Null

-- 16. Write a SQL query to find all employees that have salary more than 50000. Order them in decreasing order by salary.
SELECT *
FROM Employees
WHERE Salary > 50000
ORDER BY Salary DESC

-- 17. Write a SQL query to find the top 5 best paid employees.
SELECT TOP 5 FirstName, LastName, Salary
FROM Employees
ORDER BY Salary DESC

-- 18. Write a SQL query to find all employees along with their address. Use inner join with ON clause.
SELECT FirstName, LastName, AddressText 
FROM Employees AS [e]
INNER JOIN Addresses AS [a]
ON e.AddressID = a.AddressID

-- 19. Write a SQL query to find all employees and their address. Use equijoins (conditions in the WHERE clause).
SELECT FirstName, LastName, AddressText 
FROM Employees AS [e], Addresses AS[a]
WHERE e.AddressID = a.AddressID

-- 20. Write a SQL query to find all employees along with their manager.
SELECT CONCAT(e.FirstName, ' ', e.LastName) AS[Employee], 
	CONCAT(m.FirstName, ' ', m.LastName) AS [Manager]
FROM Employees AS [e]
INNER JOIN Employees AS[m]
ON e.ManagerID = m.EmployeeID

-- 21. Write a SQL query to find all employees, along with their manager and their address. Join the 3 tables: Employees e, Employees m and Addresses a.
SELECT CONCAT(e.FirstName, ' ', e.LastName) AS[Employee],
	   ea.AddressText AS[Employee Address],	 
	   CONCAT(m.FirstName, ' ', m.LastName) AS [Manager],
	   ma.AddressText AS[Manager Address]
FROM Employees AS[e]
INNER JOIN Employees AS[m]
	ON e.ManagerID = m.EmployeeID
INNER JOIN Addresses AS[ea]
	ON ea.AddressID = e.AddressID 
INNER JOIN Addresses AS[ma]
	ON m.AddressID = ma.AddressID

-- 22. Write a SQL query to find all departments and all town names as a single list. Use UNION.
SELECT d.Name
FROM Departments AS[d] 
UNION
SELECT t.Name
FROM Towns AS[t]

-- 23. Write a SQL query to find all the employees and the manager for each of them along with the employees that do not have manager. Use right outer join. Rewrite the query to use left outer join.
SELECT CONCAT(e.FirstName, ' ', e.LastName) AS[Employee], 
	   CONCAT(m.FirstName, ' ', m.LastName) AS [Manager]
FROM Employees AS [e]
RIGHT OUTER JOIN Employees AS[m]
ON e.ManagerID = m.EmployeeID

-- 23. With LEFT OUTER JOIN
SELECT CONCAT(e.FirstName, ' ', e.LastName) AS[Employee], 
	   CONCAT(m.FirstName, ' ', m.LastName) AS [Manager]
FROM Employees AS [e]
LEFT OUTER JOIN Employees AS[m]
ON e.ManagerID = m.EmployeeID

-- 24. Write a SQL query to find the names of all employees from the departments "Sales" and "Finance" whose hire year is between 1995 and 2005.
SELECT CONCAT(e.FirstName, ' ', e.LastName) AS[Employee Full Name],
	   d.Name,
	   e.HireDate 
FROM Employees AS[e]
INNER JOIN Departments AS[d]
	ON e.DepartmentID = d.DepartmentID
WHERE d.Name IN('Sales', 'Finance')
AND YEAR(e.HireDate) BETWEEN 1995 AND 2005