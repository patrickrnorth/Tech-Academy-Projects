CREATE DATABASE schoolDB
GO

USE schoolDB
GO

/* CREATE Students Table */
CREATE TABLE Students(
	Student_ID INT PRIMARY KEY NOT NULL IDENTITY(1000,1),
	Student_Name VARCHAR(50) NOT NULL
	);

--INSERT names into table
INSERT INTO Students
	(Student_Name)
	VALUES
	('Ryan Renolds');
;

--CREATE Instructors table
CREATE TABLE Instructors(
	Instructor_ID INT PRIMARY KEY NOT NULL IDENTITY(10000,1),
	Instructor_Name VARCHAR(50) NOT NULL,
	);

--INSERT Names into Instructors table
INSERT INTO Instructors
	(Instructor_Name)
	VALUES
	('Dirk Digler'),
	('Gloria Ware')
;

--CREATE Classes Table
CREATE TABLE Classes(
	Class_ID INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	Class_Name VARCHAR(50) NOT NULL,
	);

--INSERT Class names into table
INSERT INTO Classes
	(Class_Name)
	VALUES
	('Software Developer Boot Camp'),
	('C# Boot Camp')
;

--THIS IS THE ERROR IM HAVING, I can not set the Instructor
UPDATE Classes
SET Instructor_ID = 10000
WHERE Class_ID = 1
;


--ALTER table data to add Foreign Key Constraints
ALTER TABLE Students
ADD Class_ID INT CONSTRAINT fk_class_ID FOREIGN KEY REFERENCES Classes(Class_ID);

ALTER TABLE Classes
ADD Instructor_ID INT CONSTRAINT fk_Instructor_ID FOREIGN KEY REFERENCES Instructors(Instructor_ID);

--Display all data from any table
SELECT * FROM Students;
SELECT * FROM Instructors;
SELECT * FROM Classes;