USE Company
GO

SELECT e.FirstName + ' ' + e.LastName AS[FullName], Salary FROM
Employees e
WHERE Salary BETWEEN 100000 AND 150000
ORDER BY Salary ASC


SELECT d.Name, COUNT(e.Id) AS[EmployeesCount]  FROM 
Departments d
JOIN Employees e
	ON d.Id = e.DepartmentId
GROUP BY d.Name

SELECT 
	e.FirstName + ' ' + e.LastName AS[FullName], 
	d.Name AS[DepartmentName], 
	p.Name[ProjectName], 
	ep.StartDate, 
	ep.EndDate,
	(SELECT	COUNT(*)
		FROM Reports r
		WHERE r.Time >= ep.StartDate AND r.Time <= ep.EndDate) AS[TotalReports]
FROM EmployeeProjects ep
JOIN Employees e
	ON ep.EmployeeId = e.Id
JOIN Departments d
	ON d.Id = e.DepartmentId
JOIN Projects p
	ON ep.ProjectId = p.Id
 ORDER BY ep.EmployeeId, ep.ProjectId
