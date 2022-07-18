--2
--CREATE TABLE Coffee(
--  ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
--  Name NVARCHAR(255),
--  Price FLOAT,
--  Flavored BIT
--);

--3
--INSERT INTO Coffee (Name, Price, Flavored)
--VALUES ('Cup of Joe', 1, 0),
--('Peppermint Mocha', 4, 1),
--('Caffe Mocha', 4.65, 1),
--('Iced Regulah', 3.50, 1),
--('Custom Cold Brew', 4.25, 1);

--4
--SELECT * FROM Coffee;

--5
--SELECT * FROM Coffee
--WHERE Flavored = 1;

----6
--SELECT * FROM Coffee
--WHERE Price > 3;

--7
--SELECT MAX(Price) AS 'Max Price' FROM Coffee;

--8
--SELECT AVG(Price) AS 'Average Price' FROM Coffee;

--9
--SELECT SUM(Price) AS 'SUM Price' FROM Coffee;

--10
--SELECT MAX(Price) AS 'Max Price', AVG(Price) AS 'AVG Price', SUM(Price) AS 'SUM Price' FROM Coffee;

-------------------------------------
--1
--CREATE TABLE Customer(
--	ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
--	Name NVARCHAR(255),
--	FavDrink INT FOREIGN KEY REFERENCES Coffee(ID)
--);

--2 
--INSERT INTO Customer(Name, FavDrink)
--VALUES ('Billy',1),--('Vinh', 2),--('Krista', 4),--('Travis', 3),--('Justin', 5),--('Josh', 1),--('Robot', 2),--('Mara', 4),--('Brandon', 5),--('Ali', 3);

--3 
--SELECT * FROM Customer;

--4
--SELECT * FROM Customer
--ORDER BY Name;

--5
--SELECT * FROM Customer
--INNER JOIN Coffee ON Customer.FavDrink = Coffee.ID;

--6
--SELECT * FROM Customer
--INNER JOIN Coffee ON Customer.FavDrink = Coffee.ID
--WHERE FavDrink = 1;

--7
--UPDATE Customer
--SET FavDrink = 5
--WHERE ID = 10;

--8
--SELECT * FROM Customer
--INNER JOIN Coffee ON Customer.FavDrink = Coffee.ID
--WHERE FavDrink > 2;

--9
--DELETE FROM Customer
--WHERE ID = 10;