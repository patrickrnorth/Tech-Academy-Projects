USE AdventureWorks2017
GO

--Use DISTINCT to return only different values
SELECT DISTINCT HumanResources.Employee.JobTitle FROM HumanResources.Employee;

--Use SELECT TOP to pick the top # or % of a field or table
SELECT TOP 10 PERCENT * FROM HumanResources.Employee;

--SQL MIN/MAX 
SELECT MIN(Rate) FROM HumanResources.EmployeePayHistory;
SELECT MAX(Rate) FROM HumanResources.EmployeePayHistory;

--SQL LIKE Operator
SELECT * FROM HumanResources.Employee WHERE NationalIDNumber LIKE '__1%';

--SQL [charlist] Wildcard
SELECT * FROM Person.Person WHERE Person.FirstName LIKE '[rbn]%';

--SQL BETWEEN Operator
SELECT HumanResources.EmployeePayHistory.Rate FROM HumanResources.EmployeePayHistory WHERE HumanResources.EmployeePayHistory.Rate BETWEEN 35 AND 55;

