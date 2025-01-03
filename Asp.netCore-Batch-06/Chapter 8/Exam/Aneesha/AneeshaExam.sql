create database E_commerce
use E_commerce

CREATE TABLE Users (User_Id INT PRIMARY KEY,UserName VARCHAR(50) NOT NULL,Email VARCHAR(100) NOT NULL);
CREATE TABLE Products (Product_Id INT PRIMARY KEY,Product_name VARCHAR(100) NOT NULL,Price DECIMAL(10,2) NOT NULL,Stock INT NOT NULL);
CREATE TABLE Orders (Order_Id INT PRIMARY KEY,User_Id INT,Product_Id INT,Quantity INT,
                     FOREIGN KEY (User_Id) REFERENCES Users(User_Id),
					 FOREIGN KEY (Product_Id) REFERENCES Products(Product_Id));

INSERT INTO Users values (1,'Haneesha','ani@gmail.com');
INSERT INTO Users values (2,'Ajmal','Aju@gmail.com');
INSERT INTO Users values (3,'Shahid','Ck@gmail.com');
select * from Users

INSERT INTO Products values (111,'Laptop',50000.0,23);
INSERT INTO Products values (112,'Mobile',70000.0,55);
INSERT INTO Products values (113,'AirPods',15000.0,33);
select * from Products

INSERT INTO Orders values (001,1,111,2);
INSERT INTO Orders values (002,2,112,4);
select * from Orders

Update Products set Stock = 80 where Product_Id = 111
delete from Orders where Order_Id = 002

select u.UserName ,u.Email,p.Product_name,p.Price,o.Order_Id
from Products p
join Orders o on p.Product_Id = o.Product_Id
join Users u on o.User_Id = u.User_Id 


CREATE TRIGGER trg_Stock
ON Products
AFTER INSERT, UPDATE
AS
BEGIN
    UPDATE p SET p.Stock = i.Stock FROM Products p
    INNER JOIN inserted i ON p.Product_Id = i.Product_Id;
END;

  
--create Procedure New_Order (@Product_Id int,@Quantity int)
--As
--Begin
-- --declare @Product_Id int
-- --declare @Quantity int
-- select @Quantity = count(*) from Orders
-- select @Product_Id from Products where Product_Id = @Product_Id 
-- select @Quantity from Orders where Quantity =@Quantity
--End;
--Exec New_Order 1,60

CREATE PROCEDURE New_Order 
    @Product_Id INT,
    @Quantity INT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @ProductStock INT;
    SELECT @ProductStock = stock FROM Products WHERE product_id = @Product_Id;
    IF @ProductStock >= @Quantity
    BEGIN
        BEGIN TRANSACTION;
        INSERT INTO Orders (product_id, quantity, order_date)
        VALUES (@Product_Id, @Quantity, GETDATE());

        UPDATE Products
        SET stock = stock - @Quantity
        WHERE product_id = @Product_Id;

        COMMIT TRANSACTION;

        SELECT 'Order placed successfully.' AS Result;
    END
    ELSE
    BEGIN
        



