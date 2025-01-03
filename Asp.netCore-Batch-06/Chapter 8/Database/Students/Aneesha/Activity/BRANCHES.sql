CREATE DATABASE DB_REALESTATE
use DB_REALESTATE
CREATE TABLE BRANCHES(Branch_id int PRIMARY KEY,Address varchar(100),State varchar(30),City varchar(30),Zipcode int)
select * from BRANCHES
insert into BRANCHES values (1,'Glorias house','Kerala','Thrissur',680511)
insert into BRANCHES values (2,'Snow white','Karnadakka','Bangalore',680923)
select * from BRANCHES

Create Table Employee(Employee_id int NOT NULL PRIMARY KEY,EmployeeName varchar(50) NOT NULL,EmployeeAddress varchar(100),EmployeePhone Integer,Designation varchar(100),B_id int FOREIGN KEY REFERENCES BRANCHES(Branch_id))
insert into Employee values(1,'John','Newyork city',2345678654,'Manager',123456)
select * from Employee

CREATE TABLE Property(Property_id  int NOT NULL PRIMARY KEY,PropertyAddress Varchar(50) NOT NULL,State varchar(30),City varchar(30),Zincode int)
insert into Property values(1,'Little pigs home','Himachal pradesh','kashmir',234564)
select * from Property


CREATE TABLE Owner(Owner_id int NOT NULL PRIMARY KEY,OwnerAddress Varchar(50) NOT NULL,OwnerPhone int)
insert into Owner values(1,'Rayamarakkar house','12345678')
select * from Owner

CREATE TABLE PropertyOwner(PropertyOwner_id int NOT NULL,Property_id int NOT NULL FOREIGN KEY REFERENCES Property(Property_id),Owner_id int NOT NULL FOREIGN KEY REFERENCES Owner(Owner_id),Percent_Owned int NOT NULL)
select * from PropertyOwner
ALTER TABLE Property
ADD Rate int


SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE'

EXEC sp_rename 'Employee','Employee_Master'

CREATE VIEW ViewOfEmployee_Master AS
SELECT Employee_id,EmployeeName,EmployeeAddress 
FROM Employee_Master

ALTER VIEW ViewOfEmployee_Master AS
SELECT Employee_id,EmployeeName
FROM Employee_Master
Where Designation='Manager'

DROP VIEW ViewOfEmployee

insert into BRANCHES values(1111,'10 Main St','Canberra','Albury',734001)
insert into BRANCHES values(1123,'15 New St','Gold Creek','Glebe',72656)
insert into BRANCHES values(1245,'10 Old St','Balmain','Yamba',73895)
insert into BRANCHES values(1231,'01 Carg St','Hobart','Mudge',73965)
select * from BRANCHES

GRANT SELECT,UPDATE ON Employee_Master TO Harry;

UPDATE BRANCHES SET Address = '0 New St'
Where State ='Balmain'

DELETE FROM BRANCHES
WHERE State='Hobart'

SELECT * FROM BRANCHES

SELECT * FROM Employee
where B_id=(SELECT Branch_id FROM BRANCHES WHERE State='Balmain')

SELECT DISTINCT EmployeeName From Employee

SELECT*FROM Property WHERE Rate>500000

SELECT Property_id,PropertyAddress from Property where Rate BETWEEN 500000 AND 300000

SELECT OwnerAddress FROM Owner
where OwnerAddress Like 'T%'

SELECT * FROM BRANCHES Where Zipcode IN(734001,72656,73965,73895)
SELECT * FROM Property ORDER BY Rate Desc

SELECT  B_id, Count(*) FROM Employee  GROUP BY B_id

SELECT a.OwnerAddress FROM Owner a, Property_Owner b 
WHERE b.Property_id='8715' AND b.Owner_id=a.Owner_id



CREATE TABLE STUDENT (ID int ,Name varchar(100),Mark varchar(50))
insert into STUDENT values(1,'Haneesha','99')
insert into STUDENT values(2,'Afra','111')
insert into STUDENT values(3,'Abid','456')
insert into STUDENT values(4,'John','4')
select*from STUDENT
Alter Table STUDENT Add Result varchar(50)
UPDATE STUDENT SET Result='Passed' where Mark>50 Result='Failed' where Mark<50