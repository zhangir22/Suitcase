CREATE DATABASE dbTest
GO
USE dbTest
GO
CREATE TABLE Customers
(
id INT PRIMARY KEY IDENTITY NOT NULL,
Name NVARCHAR(MAX) NOT NULL,
)
GO 
CREATE TABLE Orders
(
id INT PRIMARY KEY IDENTITY NOT NULL,
CustomersId INT NOT NULL,
FOREIGN KEY(CustomersId)
	REFERENCES Customers(id)
)

INSERT INTO Customers(name)VALUES('Max'),('Pavel'),('Ivan'),('Leonid'),('Invalid')
INSERT INTO Orders(CustomersId)VALUES(2),(4)

SELECT*FROM Customers
SELECT*FROM Orders

SELECT c.Name as Customers FROM Customers c
WHERE c.id NOT IN ((SELECT CustomersId FROM Orders))

