CREATE LOGIN Ani with password='123'
CREATE USER ani FOR LOGIN student 
CREATE DATABASE UNIVERSITY_INFORMATION

CREATE TABLE UNIVERSITY( UID int primary key,Name varchar(20),Chancellor varchar (20))
insert into UNIVERSITY VALUES (1,'Amrita University','Haneesha RH')
insert into UNIVERSITY VALUES (2,'Manipal University','Hashir RH')
insert into UNIVERSITY VALUES (3,'Jain University','Jamal PH')
select * from UNIVERSITY

CREATE TABLE COLLEGE (CID int primary key,UNIVERSITY int FOREIGN KEY REFERENCES UNIVERSITY (UID),DEAN int FOREIGN KEY REFERENCES DEAN (DeanID),Name varchar(20))
insert into COLLEGE values (10,1,1001,'Ansar Women college')
insert into COLLEGE values (11,2,1002,'St Marys college')
insert into COLLEGE values (12,3,1003,'Royal college')
select * from COLLEGE

CREATE TABLE DEAN ( DeanID int primary key,Name varchar(20),DateOfBirth DateTime)
insert into DEAN values (1001,'Abraham',2-4-2002)
insert into DEAN values (1002,'AbdulKalam',12-8-2000)
insert into DEAN values (1003,'Jiji',19-5-2005)
select * from DEAN

CREATE TABLE DEPARTMENT ( DID int primary key,Collage int FOREIGN KEY REFERENCES COLLEGE (CID),Name varchar(20))
insert into DEPARTMENT values (001,10,'Computer sceinec')
insert into DEPARTMENT values (002,11,'Biology sceince')
insert into DEPARTMENT values (003,12,'Social sceinec')
select * from DEPARTMENT

CREATE TABLE PROFESSOR ( PID int primary key ,Department int FOREIGN KEY REFERENCES DEPARTMENT (DID),Name varchar(20))
insert into PROFESSOR values (2001,001,'John')
insert into PROFESSOR values (2002,002,'Jameela')
insert into PROFESSOR values (2003,003,'Hamza')
select * from PROFESSOR

CREATE TABLE COURSE ( CourseID int primary key,Department int FOREIGN KEY REFERENCES DEPARTMENT (DID) ,Name varchar(20))
insert into COURSE values (3001,001,'BCA')
insert into COURSE values (3002,002,'BBA')
insert into COURSE values (3003,003,'BCOM')
select * from COURSE

CREATE TABLE SUBJECTS ( SubjectID int primary key ,Course int FOREIGN KEY REFERENCES COURSE (CourseID),Professor int FOREIGN KEY REFERENCES PROFESSOR (PID),Name varchar(20))
insert into SUBJECTS values( 1231,3001,2001,'Data Structure')
insert into SUBJECTS values( 1232,3002,2002,'Computer fd')
insert into SUBJECTS values( 1233,3003,2003,'Networks')
select * from SUBJECTS

CREATE TABLE STUDENT ( StudentID int primary key,Department int FOREIGN KEY REFERENCES DEPARTMENT (DID),Name varchar(20),DateOfEnrollment smalldatetime,TelephoneNumber varchar(20))
insert into STUDENT values ( 1211,001,'Hanna','8-8-2024 2:32:5','3224567543')
insert into STUDENT values ( 1212,002,'Mehfin','1-7-2024 3:56:5','3224567111')
insert into STUDENT values ( 1213,003,'Raha','1-7-2024 3:56:5','3224567111')
insert into STUDENT values ( 1214,001,'Mary','8-8-2024 2:32:5','3224567543')
select * from STUDENT

CREATE TABLE STUDENT_REGISTRATION ( Student int FOREIGN KEY REFERENCES STUDENT (StudentID),Subject int FOREIGN KEY REFERENCES SUBJECTS (SubjectID))
insert into  STUDENT_REGISTRATION values ( 1211,1231)
insert into  STUDENT_REGISTRATION values ( 1212,1232)
insert into  STUDENT_REGISTRATION values ( 1213,1233)
select * from STUDENT_REGISTRATION

select STUDENT.Name , COURSE.Name
FROM STUDENT
RIGHT JOIN COURSE ON STUDENT.Department=COURSE.Department

UPDATE DEAN SET Name = 'Renuka' where Name = 'Jiji'

UPDATE STUDENT SET TelephoneNumber = '759191' where Name = 'Hanna'

SELECT 
s.Name AS StudentName,
c.Name AS CourseName,
cl.Name AS CollegeName,
p.Name As ProfessorName

FROM STUDENT s
join DEPARTMENT d ON s.Department = d.DID
join COLLEGE cl ON d.Collage = cl.CID
join COURSE c ON d.DID = c.Department
join SUBJECTS su ON c.CourseID = su.Course
join PROFESSOR p ON su.Professor = p.PID
join STUDENT_REGISTRATION sr ON s.StudentID = sr.Student

ORDER BY 
s.Name , c.Name, cl.Name , p.Name

SELECT
d.Name AS departmentName,
p.Name AS professorName

FROM DEPARTMENT d
join PROFESSOR p ON p.Department = d.DID

where d.Name = 'Biology sceince' 

SELECT
p.Name AS professorName,
c.Name AS courseName

FROM PROFESSOR P
join COURSE c ON c.Department = p.Department

where p.Name = 'John'


SELECT 
d.Name AS deptName,
s.Name AS studName
FROM STUDENT s
JOIN DEPARTMENT d ON s.Department = d.DID
ORDER BY d.Name

select c.Name from COLLEGE c ORDER BY C.Name DESC

SELECT Name from SUBJECTS 
WHERE COURSE = (SELECT CourseID from COURSE where Name = 'BCA')

SELECT COUNT(*) FROM COURSE 
WHERE Name = 'BCA'

SELECT 
p.Name AS profName,
su.Name AS subName
from SUBJECTS su
join PROFESSOR p ON su.Professor = p.PID
GROUP BY p.Name ,su.Name

--////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
--insert

CREATE PROC UNIVERSITY_INSERT(@Name as varchar(50),@Chancellor as varchar(20))
as
declare @UID as int
begin 
select @UID = (select isnull(max(UID),0)+1 from UNIVERSITY)
INSERT INTO UNIVERSITY(Name,Chancellor)values(@Name,@Chancellor)
end
Go
exec UNIVERSITY_INSERT  'Calicut University','Aisha Nahan'
select * from UNIVERSITY

--Update

CREATE PROC UNIVERSITY_UPDATE
(
@UID as int,
@Name as varchar(20) ,
@Chancellor as varchar(20)
)
as 
begin
UPDATE UNIVERSITY SET NAME = @Name, Chancellor = @Chancellor  WHERE UID = @UID
END
GO
EXEC UNIVERSITY_UPDATE 1,'Kannur University','Saritha'
select * from UNIVERSITY

--Delete

ALTER PROC UNIVERSITY_DELETE (@UID as int)
AS
BEGIN
DELETE FROM UNIVERSITY WHERE UID = @UID
END
GO
EXEC UNIVERSITY_DELETE @UID = 1

--select

CREATE PROC selectDetails
As
Begin
select s.Name , s.StudentID, p.Name 
from STUDENT s
inner join  DEPARTMENT d ON s.Department = d.DID
inner join PROFESSOR p ON p.Department = d.DID
where d.Name = 'Computer sceinec'
end
exec selectDetails ;

--Auto id

CREATE FUNCTION Auto_Id()
RETURNS bigint
as
Begin
    declare @UID as bigint
    select @UID = (select isnull (max(UID),0)+1 from UNIVERSITY)
    Return (@UID)
END
Go
Exec Auto_Id
select * from UNIVERSITY
---------------------------------------------------------------------------

CREATE FUNCTION List_College(@Name as varchar(50))
Returns @COLLEGE TABLE (collegeName varchar (100),UniversityName varchar (100),DeanName varchar (100))
AS
begin
insert into @COLLEGE
select c.Name as collegeName,u.Name as UniversityName,d.Name as DeanName
from COLLEGE c
inner join UNIVERSITY u ON u.UID = c.UNIVERSITY
inner join DEAN d ON d.DeanID = c.DEAN
where c.Name = @Name
Return
end
Go
select * from List_College('Royal college')

---------------------------------------------------------------------------------------------
CREATE FUNCTION List_Collgs(@Name as varchar(50))
Returns @COLLEGE TABLE (collegeName varchar (100))
AS
begin
insert into @COLLEGE (collegeName)
select c.Name as collageName
from COLLEGE c
inner join UNIVERSITY u ON u.UID = c.UNIVERSITY
where u.Name = @Name
Return
end
Go
select * from List_Collgs('Jain University')
--------------------------------------------------------------------------------------------------
CREATE FUNCTION get_college_code()
RETURNS VARCHAR (100)
AS
BEGIN
DECLARE @CID AS VARCHAR(100)
SELECT @CID
= (SELECT 'COL' + LEFT ('0000',8-LEN(LTRIM(STR(RIGHT(MAX(CID),8)+1))))+LTRIM(STR(RIGHT(MAX(CID),8)+1)) FROM COLLEGE)
RETURN ISNULL (@CID,'COL'+'00001')
END
GO

SELECT [dbo].[get_college_code] ()


--///////////////////////////////////////////////////////////////////
--Trigger

CREATE TABLE temp_student (
    StudentID int PRIMARY KEY,
    Department int FOREIGN KEY REFERENCES DEPARTMENT (DID),
    Name varchar(20),
    DateOfEnrollment smalldatetime,
    TelephoneNumber varchar(20)
);

CREATE TRIGGER Student_Insert 
ON STUDENT
After Insert 
As
Begin
insert into temp_student(StudentID,Department,Name,DateOfEnrollment,TelephoneNumber)
select StudentID,Department,Name,DateOfEnrollment,TelephoneNumber
FROM INSERTED
END
GO
select * from temp_student
insert into STUDENT values ( 1222,001,'Hanee','8-8-2024 2:32:5','3224567543')

CREATE TRIGGER  Student_Update
ON STUDENT
AFTER UPDATE 
AS
BEGIN
INSERT INTO temp_student(StudentID,Department,Name,DateOfEnrollment,TelephoneNumber)
select StudentID,Department,Name,DateOfEnrollment,TelephoneNumber
from Inserted;

UPDATE STUDENT 
SET Name = 'Afratha'
where StudentID = 001;
End
go

CREATE TRIGGER  Student_DELETE
ON STUDENT
AFTER DELETE
AS
BEGIN
INSERT INTO temp_student(StudentID,Department,Name,DateOfEnrollment,TelephoneNumber)
select StudentID,Department,Name,DateOfEnrollment,TelephoneNumber
from DELETED;
DELETE FROM STUDENT WHERE StudentID = 003
End
go
select * from STUDENT
select * from temp_student