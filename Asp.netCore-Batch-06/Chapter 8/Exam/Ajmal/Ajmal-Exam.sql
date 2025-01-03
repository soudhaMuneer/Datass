create database E_Commerce
use E_Commerce

create table Users(user_id int primary key,
username varchar(50) not null,
email varchar(50) not null)

create table Products(product_id int primary key,
product_Name varchar(50) not null,
price decimal(10,2) not null,
stock int not null)

create table Orders(order_id int primary key,
user_id int foreign key references users(user_id),
product_id int foreign key references products(product_id),
Quantity int)

insert into Users values(1,'ajmal','aj@gmail.com'),(2,'Abid','abid@gmail.com'),(3,'Shemeem','shemeem@gmail.com'),(4,'shahid','shahid@gmail.com')
insert into Products values(1,'Sofa',100.00,2),(2,'Shirt',900.50,4),(3,'T-Shirt',10.00,1),(4,'Boots',190.00,2),(5,'Football',500.00,6)
insert into Orders values(1,1,2,3),(2,3,1,2),(3,2,5,4),(4,4,3,1)


UPDATE Products
SET stock = stock - Orders.Quantity
FROM Products
INNER JOIN Orders ON Products.product_id = Orders.product_id



select * from Orders
inner join Users a on a.user_id=Orders.user_id
inner join Products b on b.product_id=Orders.product_id

create trigger updatestock on [dbo].[orders]
for insert
as
begin
declare @id int, @qty int

select @id=(select product_id from inserted)
select @qty = (select quantity from inserted)
update Products set stock=Products.stock - @id where product_id=@id
end

insert into Orders values(5,1,5,1)
select*from Products
create proc NewOrder 
(
 @id int ,
 @user int,
 @product int,
 @quantity int
)
as
begin
insert into Orders values(@id,@user,@product,@quantity)
update Products set stock= stock-@quantity where product_id=@product
end
exec NewOrder 7,1,3,1