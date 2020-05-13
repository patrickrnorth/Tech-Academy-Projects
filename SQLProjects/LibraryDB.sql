CREATE DATABASE libraryDB
GO

USE libraryDB
GO

--CREATE Library Branch Table
CREATE TABLE LIBRARY_BRANCH(
	BranchID INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	BranchName VARCHAR(50) NOT NULL,
	[Address] VARCHAR(75) NOT NULL
);


--INSERT into the LIBRARY_BRANCH table 6 values one must be Sharpstown
INSERT INTO LIBRARY_BRANCH
	(BranchName, [Address])
	VALUES
	('Jacksonville', '2291 Dumfries Circle East, FL 32246'),
	('Sharpstown', '27389 Wherever Ct., XF 38485'),
	('Orlando', '374 Thisplace Street, FL 38490'),
	('Tampa', '11122 Otherstreet FL 32133'),
	('Miami', '123 Ocean Way, FL 36664'),
	('Key West', '9990 Celebration Way, FL 33344')
;

--CREATE BOOK_COPIES Table
CREATE TABLE BOOK_COPIES(
	BookID INT CONSTRAINT fk_BookID FOREIGN KEY REFERENCES BOOKS(BookID),
	BranchID INT CONSTRAINT fk_BranchID FOREIGN KEY REFERENCES LIBRARY_BRANCH(BranchID),
	Number_Of_Copies INT NOT NULL
);

--CREATE BOOKS Table
CREATE TABLE BOOKS(
	BookID INT PRIMARY KEY NOT NULL IDENTITY(1,1),
	Title VARCHAR(50) NOT NULL,
	PublisherName VARCHAR(50) CONSTRAINT fk_PublisherName REFERENCES PUBLISHER(PublisherName)
);

--CREATE BOOK_AUTHORS Table
CREATE TABLE BOOK_AUTHORS(
	BookID INT CONSTRAINT fk_BookID REFERENCES BOOKS(BookID),
	AuthorName VARCHAR(50) NOT NULL,
);

--CREATE BORROWER Table
CREATE TABLE BORROWER(
	CardNo INT PRIMARY KEY NOT NULL IDENTITY(10000,1),
	[Name] VARCHAR(50) NOT NULL,
	[Address] VARCHAR(75) NOT NULL,
	Phone VARCHAR(20) NOT NULL
);

--INSERT into the LIBRARY_BRANCH table 6 values one must be Sharpstown
INSERT INTO BORROWER
	([Name], [Address], Phone)
	VALUES
	('Robert Brown', '7342 Leatherwood Drive Venice, FL 34293', '202-555-0191'),
	('James Dean', '204 Pin Oak Ave. Hollywood, FL 33021', '202-555-0120'),
	('Billie Madison', '7696 Henry St. Hollywood, FL 33023', '411-447-4994'),
	('Alfred Daniels', '2 Newport Dr. Middleburg, FL 32068', '536-954-6361'),
	('Douglas White', '204 Pin Oak Ave. Hollywood, FL 33021', '755-647-4668'),
	('John Smith', '7696 Henry St. Hollywood, FL 33023', '779-514-8939'),
	('Jacob Black', '2 Galvin Road Miami, FL 33156', '609-897-9837'),
	('Jeffery North', '392 Randall Mill Dr. Hialeah, FL 33012', '(871) 744-9043')
;

--CREATE BOOK_LOANS Table
CREATE TABLE BOOK_LOANS(
	BookID INT CONSTRAINT fk_BookID REFERENCES BOOKS(BookID),
	BranchID INT CONSTRAINT fk_BranchID REFERENCES LIBRARY_BRANCH(BranchID),
	CardNo INT CONSTRAINT fk_CardNo REFERENCES BORROWER(CardNo),
	DateOut DATE NOT NULL,
	DateDue DATE NOT NULL
);

--CREATE PUBLISHER Table
CREATE TABLE PUBLISHER(
	PublisherName VARCHAR PRIMARY KEY NOT NULL,
	[Address] VARCHAR(75) NOT NULL,
	Phone INT NOT NULL,
);

