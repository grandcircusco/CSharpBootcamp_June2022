--CREATE TABLE Tutorials_tbl(
--	tutorial_id INT NOT NULL IDENTITY(1,1),
--	tutorial_title NVARCHAR(100) NOT NULL,
--	tutorial_author NVARCHAR(40) NOT NULL,
--	submission_date DATE,
--	PRIMARY KEY (tutorial_id)
--);

-----------------------------------------------------
--Deleting tables
--DROP TABLE IF EXISTS Tutorials_tbl;

-----------------------------------------------------
--CREATING A TABLE
--CREATE TABLE SuperHeros(
--	ID INT NOT NULL IDENTITY(1,1),
--	Name NVARCHAR(255),
--	SuperHeroName NVARCHAR(255),
--	Power NVARCHAR(255),
--	Popularity INT
--);

-----------------------------------------------------
--Adding values into table
--INSERT INTO SuperHeros (Name, SuperHeroName, Power, Popularity)
--VALUES ('Tony Stark', 'Iron Man', 'Money', 9),
--('Peter Parker', 'Spiderman', 'Spider Senses', 10);

--INSERT INTO SuperHeros (Name, SuperHeroName, Power, Popularity)
--VALUES ('Bruce Banner', 'Hulk', 'Strength', 8),
--('Stephen Strange', 'Dr Strange', 'Strange Shit', 6),
--('Scott Summers','Cyclops','Laser Vision',6),
--('Peter Parker', 'Spiderman', 'Web Slinging', 10),
--('Peter Parker', 'Spiderman', 'Loud mouthing', 10);

--INSERT INTO SuperHeros (Name, SuperHeroName, Power, Popularity)
--VALUES ('Thor', 'Thor', 'God', 8);

-----------------------------------------------------
--Retrieve values
--SELECT SuperHeroName FROM SuperHeros;
--SELECT SuperHeroName, Power FROM SuperHeros;
--SELECT Name, Popularity FROM SuperHeros;
--SELECT * FROM SuperHeros;

-----------------------------------------------------
--Filter Select Statements
--SELECT * FROM SuperHeros
--WHERE Name = 'Peter Parker';

--SELECT * FROM SuperHeros
--WHERE Name = 'Peter Parker' AND Power = 'Spider Senses';

--SELECT * FROM SuperHeros
--WHERE Popularity >= 9;

-----------------------------------------------------
--Order results based on column
--SELECT * FROM SuperHeros
--ORDER BY Popularity DESC;

-----------------------------------------------------
--Update values
--UPDATE SuperHeros
--SET Power = 'Supreme Sorcerer'
--WHERE ID = 4;

-----------------------------------------------------
--Delete rows from table
--DELETE FROM SuperHeros
--WHERE SuperHeroName = 'Spiderman' AND Power <> 'Spider Senses';

-----------------------------------------------------
--Tickets Table
--CREATE TABLE Tickets(
--	id INT NOT NULL IDENTITY(1,1),
--	Seat NVARCHAR(255),
--	Price INT,
--	num_sold INT,

--	PRIMARY KEY (id)
--);

--INSERT INTO Tickets (Seat, Price, num_sold)
--VALUES ('Box Level', 105, 4),
--('Dress Circle', 75, 2),
--('Main Floor', 58, 10),
--('Mid Balcony', 38, 0),
--('Upper Balcony', 19, 3);
--SELECT * FROM Tickets;

-----------------------------------------------------
--COLUMN OPERATORS
--SELECT COUNT(*) AS 'Count' FROM Tickets;
--SELECT COUNT(*) AS 'Seat types that sold' FROM Tickets
--WHERE num_sold <> 0;

--SELECT SUM(num_sold) AS 'Tickets Sold' FROM Tickets;

--SELECT AVG(Price) AS 'Average Price' From Tickets;

--SELECT MAX(num_sold) AS 'Max sold' FROM Tickets;

--SELECT MIN(Price) AS 'Cheapest Price' FROM Tickets;

--SELECT SUM(num_sold) AS 'Total Sold', SUM(price * num_sold) AS 'Total Revenue' FROM Tickets;


-----------------------------------------------------
--TABLE RELATIONSHIPS
--CREATE TABLE Class (
--	id int NOT NULL IDENTITY(1,1) PRIMARY KEY,
--	title NVARCHAR(255)
--);

--CREATE TABLE Student(
--	id int NOT NULL IDENTITY(1,1) PRIMARY KEY,
--	name NVARCHAR(255),
--	class_id INT FOREIGN KEY REFERENCES Class(id)
--)

--INSERT INTO Class (title)
--VALUES ('.NET'),
--('Java'),
--('Front-End');
--SELECT * FROM Class;

--INSERT INTO Student (name, class_id)
--VALUES ('G. Washington',1),
--('M. Gandhi', 1),
--('N. Mandela', NULL),
--('Q. Victoria', 2);
--SELECT * FROM Student;

-----------------------------------------------------
--JOINS
--SELECT * FROM Student
--JOIN Class ON Student.class_id = Class.id;

--INNER JOIN
--ONLY RETURN MATCHES
--SELECT * FROM Student
--INNER JOIN Class ON Student.class_id = Class.id;

--LEFT JOIN
--RETURN ALL FROM MAIN TABLE EVEN WITH NO MATCH
--SELECT * FROM Student
--LEFT JOIN Class ON Student.class_id = Class.id;

--RIGHT JOIN
--RETURN ALL FROM SECONDARY TABLE EVEN WITH NO MATCH
--SELECT * FROM Student
--RIGHT JOIN Class ON Student.class_id = Class.id;

--FULL JOIN
--RETURN ALL FROM ALL TABLES EVEN WITHOUT MATCHES
--SELECT * FROM Student
--FULL JOIN Class ON Student.class_id = Class.id;

--Cartesian Join
--Chaos
--Joins everything
--SELECT * FROM Student
--CROSS JOIN Class;

--Join can be combined with other queries
SELECT Student.id, Student.name FROM Student
JOIN Class ON Student.class_id = Class.id
WHERE Class.title = '.NET' ORDER BY Student.name;
