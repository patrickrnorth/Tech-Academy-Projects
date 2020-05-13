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
SELECT * FROM LIBRARY_BRANCH;

--CREATE PUBLISHER Table
CREATE TABLE PUBLISHER(
	PublisherName VARCHAR(50) PRIMARY KEY NOT NULL,
	[Address] VARCHAR(100) NOT NULL,
	Phone VARCHAR(16) NOT NULL,
);

--INSERT into PUBLISHER table 10 values.
INSERT INTO PUBLISHER
	(PublisherName, [Address], Phone)
	VALUES
	('Zondervan Publishing House', '46 Cooper St. Miami, FL 33183', '953-800-6161'),
	('The Media Pro', '8328 Homestead St. Altamonte Springs, FL 32714', '(200) 671-2260'),
	('DiMar Publishing Company', '227 S. Anderson Street Fort Lauderdale, FL 33311', '(389) 593-2732'),
	('Orchard Books Inc', '8683 West St Paul Street Orlando, FL 32839', '(370) 845-4803'),
	('Sport Folion Publications', '8 Bohemia Ave. Deltona, FL 32725', '(754) 569-7822'),
	('Temple Publishers', '920 Glendale Road Palm Harbor, FL 34683', '(792) 541-3905'),
	('Penton Media Inc', '7868 Fremont Street Pensacola, FL 32503', '(874) 787-1434'),
	('Island Press', '7119 Marvon Street Jacksonville, FL 32211', '(456) 220-7115'),
	('Bellaire Buzz', '58 Brickyard Lane Opa Locka, FL 3305', '(296) 259-8262'),
	('Alps Publishing', '79 Windfall Dr. Jacksonville, FL 32246', '(352) 850-0830')
;
SELECT * FROM PUBLISHER;

--CREATE BORROWER Table
CREATE TABLE BORROWER(
	CardNo INT PRIMARY KEY NOT NULL,
	[Name] VARCHAR(50) NOT NULL,
	[Address] VARCHAR(75) NOT NULL,
	Phone VARCHAR(20) NOT NULL
);

--INSERT into the BORROWER table 8 values 
INSERT INTO BORROWER
	(CardNo, [Name], [Address], Phone)
	VALUES
	(10001, 'Robert Brown', '7342 Leatherwood Drive Venice, FL 34293', '202-555-0191'),
	(10002, 'James Dean', '204 Pin Oak Ave. Hollywood, FL 33021', '202-555-0120'),
	(10003, 'Billie Madison', '7696 Henry St. Hollywood, FL 33023', '411-447-4994'),
	(10004, 'Alfred Daniels', '2 Newport Dr. Middleburg, FL 32068', '536-954-6361'),
	(10005, 'Douglas White', '204 Pin Oak Ave. Hollywood, FL 33021', '755-647-4668'),
	(10006, 'John Smith', '7696 Henry St. Hollywood, FL 33023', '779-514-8939'),
	(10007, 'Jacob Black', '2 Galvin Road Miami, FL 33156', '609-897-9837'),
	(10008, 'Jeffery North', '392 Randall Mill Dr. Hialeah, FL 33012', '(871) 744-9043')
;
SELECT * FROM BORROWER;

--CREATE BOOKS Table
CREATE TABLE BOOKS(
	BookID INT PRIMARY KEY NOT NULL IDENTITY(10,1),
	Title VARCHAR(50) NOT NULL,
	PublisherName VARCHAR(50) CONSTRAINT fk_PublisherName REFERENCES PUBLISHER(PublisherName)
);

--INSERT INTO BOOKS 20 rows of different books. Assign one book title with the value The Lost Tribe
INSERT INTO BOOKS
	(Title, PublisherName)
	VALUES
	('In Search of Lost Time ','DiMar Publishing Company'),
	('Ulysses','Orchard Books Inc'),
	('Don Quixote','The Media Pro'),
	('The Great Gatsby','Zondervan Publishing House'),
	('One Hundred Years of Solitude','DiMar Publishing Company'),
	('Moby Dick','Temple Publishers'),
	('War and Peace','Sport Folion Publications'),
	('Lolita ','Temple Publishers'),
	('Hamlet','Penton Media Inc'),
	('The Catcher in the Rye ','Island Press'),
	('The Odyssey ','Bellaire Buzz'),
	('The Brothers Karamazov','Alps Publishing'),
	('Crime and Punishment','Island Press'),
	('Madame Bovary','Temple Publishers'),
	('The Divine Comedy','Zondervan Publishing House'),
	('The Adventures of Huckleberry Finn','Bellaire Buzz'),
	('[Alices Adventures in Wonderland]','DiMar Publishing Company'),
	('Pride and Prejudice','Island Press'),
	('Wuthering Heights','DiMar Publishing Company'),
	('The Lost Tribe','Temple Publishers')
;
SELECT * FROM BOOKS;

--CREATE BOOK_COPIES Table
CREATE TABLE BOOK_COPIES(
	BookID INT CONSTRAINT fk_BookID FOREIGN KEY REFERENCES BOOKS(BookID),
	BranchID INT CONSTRAINT fk_BranchID FOREIGN KEY REFERENCES LIBRARY_BRANCH(BranchID),
	Number_Of_Copies INT NOT NULL
);

--INSERT INTO BOOK_COPIES table
INSERT INTO BOOK_COPIES
	(BookID, BranchID, Number_Of_Copies)
	VALUES
	(10,2,3),
	(11,3,2),
	(12,5,4),
	(13,6,3),
	(14,1,3),
	(15,1,2),
	(16,2,5),
	(17,2,2),
	(18,5,3),
	(19,6,3),
	(20,5,4),
	(21,4,4),
	(22,4,2),
	(23,3,3),
	(24,2,2),
	(25,3,5),
	(26,5,4),
	(27,4,2),
	(28,6,4),
	(29,6,3)
;
SELECT * FROM BOOK_COPIES;

--CREATE BOOK_AUTHORS Table
CREATE TABLE BOOK_AUTHORS(
	BookID INT, 
	AuthorName VARCHAR(50) NOT NULL,
);

--INSERT INTO BOOK_AUTHORS table 10 different author names
INSERT INTO BOOK_AUTHORS
	(BookID, AuthorName)
	VALUES
	(10,'Justine Iles'),
	(18, 'Brody Taylor'),
	(20,'Mahima Paine'),
	(11,'Terence Jacobson'),
	(14,'Lizzie Sykes'),
	(17,'Regina Abbott'),
	(23,'Jennifer Atkinson'),
	(25,'Kacey Deacon'),
	(22,'Dominique Norman'),
	(26,'Aaisha Warner')
;
SELECT * FROM BOOK_AUTHORS;

--CREATE BOOK_LOANS Table
CREATE TABLE BOOK_LOANS(
	BookID INT CONSTRAINT fk_BookIDLoan REFERENCES BOOKS(BookID),
	BranchID INT CONSTRAINT fk_BranchIDLoan REFERENCES LIBRARY_BRANCH(BranchID),
	CardNo INT CONSTRAINT fk_CardNoLoan REFERENCES BORROWER(CardNo),
	DateOut VARCHAR(20) NOT NULL,
	DateDue varchar(20) NOT NULL
);

/* ERROR MSG: The INSERT statement conflicted with the FOREIGN KEY constraint "fk_CardNo". <<<<<<<<<<<<<<<<<<<<
 * The conflict occurred in database "libraryDB", table "dbo.BORROWER", column 'CardNo'. <<<<<<<<<<<<<<<<<<<<
 */
 
--INSERT INTO BOOK_LOANS table 10 rows 
INSERT INTO BOOK_LOANS
	(BookID, BranchID, CardNo, DateOut, DateDue)
	VALUES
	(10, 6, 10001, 20200312, 20200512),
	(11, 3, 10002, 20200115, 20200315),
	(14, 2, 10003, 20200109, 20200309),
	(12, 2, 10004, 20200402, 20200602),
	(13, 2, 10005, 20200122, 20200322),
	(19, 1, 10006, 20200228, 20200428),
	(22, 5, 10007, 20191101, 20200101),
	(24, 4, 10008, 20191214, 20200214),
	(26, 6, 10001, 20200311, 20200511),
	(29, 1, 10002, 20200321, 20200321)
;
SELECT * FROM BOOK_LOANS;

