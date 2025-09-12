create database assignment3

use assignment3 

--Basic Task

CREATE TABLE Students2024 (ID INT, Name VARCHAR(50));
CREATE TABLE Students2025 (ID INT, Name VARCHAR(50));

INSERT INTO Students2024 VALUES
(1,'Ravi'),(2,'Asha'),(3,'John'),(4,'Meera'),(5,'Kiran'),
(6,'Divya'),(7,'Lokesh'),(8,'Anita'),(9,'Rahul'),(10,'Sneha');

INSERT INTO Students2025 VALUES
(2,'Asha'),(4,'Meera'),(5,'Kiran'),(11,'Prakash'),(12,'Vidya'),
(13,'Neha'),(14,'Manoj'),(15,'Ramesh'),(16,'Lata'),(17,'Akash');






CREATE TABLE Employees (EmpID INT, Name VARCHAR(50), Department VARCHAR(20));

INSERT INTO Employees VALUES 
(1,'Ananya','HR'),(2,'Ravi','IT'),(3,'Meera','Finance'),
(4,'John','IT'),(5,'Divya','Marketing'),(6,'Sneha','Finance'),
(7,'Lokesh','HR'),(8,'Asha','IT'),(9,'Kiran','Finance'),(10,'Rahul','Sales');





CREATE TABLE Projects (ProjectID INT, Name VARCHAR(50), StartDate DATE, EndDate DATE);
INSERT INTO Projects VALUES 
(1,'Bank App','2025-01-01','2025-03-15'),
(2,'E-Commerce','2025-02-10','2025-05-20');





CREATE TABLE Contacts (ID INT, Name VARCHAR(50), Email VARCHAR(50), Phone VARCHAR(20));
INSERT INTO Contacts VALUES
(1,'Ravi','ravi@gmail.com',NULL),
(2,'Asha',NULL,'9876543210'),
(3,'John',NULL,NULL);


select * from contacts 

select * from students2024
select * from students2025 

--all unique names 
select Name from students2024
union
select Name from students2025

--all names including duplicates
select * from students2024
union all
select * from students2025 

--upper and lower case 
select upper(name) as upper_name from Employees
select lower(name) as lower_name from Employees

--length of each employee name
select len(name) as len_name from Employees

--first three characters in the name 
select substring(name,1,3) from Employees

--replace finance dept with accounts 
select *,replace(Department,'Finance','Accounts') as replaced from Employees

--newcol with Name-Department concat 
select concat(Name ,'_', Department) as Name_Department from Employees

--show todays date 
select getdate()

--Duration of project using DATEDIFF
select DATEDIFF(day, StartDate,EndDate)  as Duration from Projects

-- add 10 days to each projects enddate 
select DATEADD(DAY,10,enddate)  as new_deadline from Projects

--how long ago was the project done from today 
select DATEDIFF(day, EndDate,GETDATE())  as Done_before from Projects

--Convert today’s date into DD/MM/YYYY format using CONVERT.
select convert(varchar(10),GETDATE(),103) as IN_DDMMYYYY

--Convert a float 123.456 into an integer using CAST.
select cast(123.456 as int) as into_integer

