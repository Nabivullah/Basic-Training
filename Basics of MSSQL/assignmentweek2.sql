create table users (
	user_id int primary key,
	email varchar(50),
	name varchar(50)
);

create table books (
	product_id int primary key,
	title varchar(30),
	price float 
);


create table orders (
	order_no int primary key,
	user_id int,
	product_id int,
	foreign key (user_id) references users(user_id), 
	foreign key (product_id) references books(product_id)
);

insert into orders values (408,5,105)

update books set price=2001.99 where product_id=105 

select * from books
select * from orders

select * from users

exec sp_rename 'users.name1', 'name' ,'column'

--Full outer join

select * from users u inner join orders o on u.user_id=o.user_id inner join books b on b.product_id=o.product_id where price=(select max(price) from books)

--all books and all users and all orders 
select * from users u inner join orders o on u.user_id=o.user_id inner join books b on b.product_id=o.product_id

--find all orders
select count(*) count_of_orders from orders 

--find the particular user who has order these books 
select u.name,b.title from users u inner join orders o on u.user_id=o.user_id inner join books b on b.product_id=o.product_id where title='half girlfriend'

--find particular user who has orders these books
select u.name,b.title from users u inner join orders o on u.user_id=o.user_id inner join books b on b.product_id=o.product_id

--total price of the book 
select u.name,sum(b.price) total_amount from users u inner join orders o on u.user_id=o.user_id inner join books b on b.product_id=o.product_id group by name

--find the most valuable user 
select top 1 u.name,sum(b.price) total_amount from users u inner join orders o on u.user_id=o.user_id inner join books b on b.product_id=o.product_id group by name order by total_amount desc 

--range of books from high to low
select title,price from books order by price desc

--highest price book
select top 1 title,price from books order by price desc

--cheapest price book
select top 1 title,price from books order by price asc

--find newly added book 
select top 1 title,product_id from books order by product_id asc



