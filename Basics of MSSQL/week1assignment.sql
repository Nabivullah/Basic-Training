create database smartmeter

use smartmeter

create table Customers(
		CustomerId int primary key ,
		Name varchar(30),
		address varchar(50),
		region varchar(50)
);

create table SmartMeterReadings(
		MeterId int primary key ,
		CustomerId int,
		Location varchar(50),
		InstalledDate Date,
		ReadingDateTime Datetime,
		EnergyConsumed int
);

select * from Customers
select * from SmartMeterReadings

insert into SmartMeterReadings values (305,5,'Maharashtra','2024-04-20','2024-06-20 14:30:00',45)


update SmartMeterReadings set MeterId='301' where MeterId=1


--query to fetch 

--energyconsumed between 10 and 50 
select MeterId,ReadingDateTime,EnergyConsumed from SmartMeterReadings where EnergyConsumed between 10 and 50 

--reading time is between '2024-01-01' and '2024-12-31'
select * from SmartMeterReadings where ReadingDateTime between '2024-01-01' and '2024-12-31' 


--exclude meters installed after '2024-06-30'
select * from SmartMeterReadings where InstalledDate < '2024-06-30' 


--calculate avg energy
select AVG(EnergyConsumed) average_energy from SmartMeterReadings

--max energy consumed in a single year 
select MAX(EnergyConsumed) max_energy from SmartMeterReadings

--reading only from current year 
select * from SmartMeterReadings where ReadingDateTime like '%2024%' 