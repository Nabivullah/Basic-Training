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

--window functions
--ROW_NUMBER,RANK(),DENSE_RANK(), partition by
select *, ROW_NUMBER() over (order by Department) as popularity , rank () over (partition by Department  order by Name) as ranks , dense_rank () over ( order by Department) as dense_ranks from employees 


create database ASSIGN_DB

-- USING THE PREVIOUSLY CREATED DATABASE

USE ASSIGN_DB
 
-- CREATING NEW TABLE USERS FOR LOGGING CLIENT INFORMATION

CREATE TABLE USERS(

	USER_ID INT PRIMARY KEY,

	EMAIL VARCHAR(20),

	NAME VARCHAR(50)

);

-- CHECKING STRUCTURE

SELECT * FROM USERS;
 
-- CREATING NEW TABLE BOOKS FOR LOGGING THE PRODUCT INFO

CREATE TABLE BOOKS(

	PRODUCT_ID INT PRIMARY KEY,

	TITLE VARCHAR(50),

	PRICE FLOAT

);
 
SELECT * FROM BOOKS;
 
-- CREATING THE ORDERS TABLE

CREATE TABLE ORDERS(

	ORDER_NO INT PRIMARY KEY,

	USER_ID INT,

	PRODUCT_ID INT,

	FOREIGN KEY (USER_ID) REFERENCES USERS(USER_ID),

	FOREIGN KEY (PRODUCT_ID) REFERENCES BOOKS(PRODUCT_ID)

);
 
SELECT * FROM ORDERS
 
-- INSERTING VALUES IN USERS TABLE

INSERT INTO USERS 

VALUES(1, 'CALLMEBHAI@GMAIL.COM','GOPAL'),
 
INSERT INTO USERS 

VALUES (2,'TOXICMANJI@GMAIL.COM','MANJIT'),

(3,'KAALAJAADU@GMAIL.COM','SOUMYADEEP')
 
ALTER TABLE USERS ALTER COLUMN EMAIL VARCHAR(50)
 
INSERT INTO USERS 

VALUES(4,'VIMALPANMASALA@GMAIL.COM','JAISAI'),

(5,'GHOSTLAUGH@GMAIL.COM','NAMITHA')
 
SELECT * FROM USERS
 
-- INSERTING VALUES INTO BOOKS TABLE

INSERT INTO BOOKS

VALUES(101,'MSSQL',100),

(102,'HALF-GIRLFRIEND',699),

(103,'BLACK MAGIC', 700),

(104,'HOW TO MARFA', 2000),

(105,'HOW TO LAUGH',2001.99)
 
SELECT * FROM BOOKS
 
-- INSERT INTO THE ORDER
 
INSERT INTO ORDERS

VALUES(401, 1, 101),

(402, 2, 102),

(403, 2, 103),

(404, 3, 103),

(405, 3, 104),

(406, 4, 102),

(407, 5, 102),

(408, 5, 105)
 
SELECT * FROM ORDERS
 
-- FULL OUTER JOIN
 
SELECT * FROM ORDERS AS O

INNER JOIN USERS AS U ON O.USER_ID = U.USER_ID 

INNER JOIN BOOKS AS B ON O.PRODUCT_ID = B.PRODUCT_ID;
 
UPDATE USERS SET NAME = 'SOUMYADIP' WHERE USER_ID = 3
 
-- FIND THE BOOK USING ID

SELECT * FROM ORDERS AS O

INNER JOIN USERS AS U ON O.USER_ID = U.USER_ID 

INNER JOIN BOOKS AS B ON O.PRODUCT_ID = B.PRODUCT_ID WHERE B.PRODUCT_ID = 103
 
-- FIND THE HIGHEST PRICED BOOK

SELECT * FROM ORDERS AS O

INNER JOIN USERS AS U ON O.USER_ID = U.USER_ID 

INNER JOIN BOOKS AS B ON O.PRODUCT_ID = B.PRODUCT_ID WHERE B.PRICE = (SELECT  MAX(PRICE) FROM BOOKS);
 
 --top 2 most expensive books by each user 

select * from (select u.USER_ID,NAME,TITLE,PRICE,row_number() over (partition by U.USER_ID order by PRICE desc) as top2 ,dense_rank() over (partition by U.USER_ID order by PRICE desc) as dense_top2 FROM ORDERS AS O INNER JOIN USERS AS U ON O.USER_ID = U.USER_ID INNER JOIN BOOKS AS B ON O.PRODUCT_ID = B.PRODUCT_ID) as RANKEDBOOKS where top2<=2 

--spent in total and rank them 
SELECT 
    u.user_id,
    u.name,
    SUM(b.price) AS TotalSpent,
    RANK() OVER (ORDER BY SUM(b.price) DESC) AS RankNum,
    DENSE_RANK() OVER (ORDER BY SUM(b.price) DESC) AS DenseRankNum
FROM orders o
JOIN users u ON o.user_id = u.user_id
JOIN books b ON o.product_id = b.product_id
GROUP BY u.user_id, u.name;


