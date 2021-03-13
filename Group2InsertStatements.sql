--if exists(select * from  group2sp212330.OrderDetails)
--drop table group2sp212330.OrderDetails;

--if exists(select * from  group2sp212330.Orders)
--drop table group2sp212330.Orders;

--if exists(select * from  group2sp212330.SalesDetails)
--drop table group2sp212330.SalesDetails;

--if exists(select * from  group2sp212330.Sales)
--drop table group2sp212330.Sales;

--if exists(select * from  group2sp212330.Customers)
--drop table group2sp212330.Customers;

--if exists(select * from  group2sp212330.EmployeeInfo)
--drop table group2sp212330.EmployeeInfo;

--if exists(select * from  group2sp212330.Employees)
--drop table group2sp212330.Employees;

--if exists(select * from  group2sp212330.Schedules)
--drop table group2sp212330.Schedules;

--if exists(select * from  group2sp212330.Products)
--drop table group2sp212330.Products;

----table prod
--create table group2sp212330.Products 
--(UPC int primary key,
-- Name varchar(80),
-- Price money,
-- Description varchar(100),
-- Quantity int,
--inStock bit);

--create table group2sp212330.ProdImages(
--ImageIndex int identity primary key,
--ProductImage varbinary(max)
--);

----table Schedule
--create table group2sp212330.Schedules
--(ScheduleType int primary key,
--StartHour time,
--LunchHour time,
--EndHour time,
--BreakOne time,
--BreakTwo time);

----table Employ
--create table group2sp212330.Employees
--(EmployeeID int primary key,
-- SecurityLevel int,
-- ScheduleType int foreign key references group2sp212330.Schedules(ScheduleType));

----table Customer
--create table group2sp212330.Customers
--(CustomerID int  primary key,
-- SecurityLevel int,
-- Name varchar(40),
-- Phone varchar(12),
-- Email varchar(64),
-- Address varchar(64));

----table sale
--create table group2sp212330.Sales
--(SaleID int primary key,
-- SaleDate date,
-- ArrivalDate date,
-- CustomerID int foreign key references group2sp212330.Customers(CustomerID),
-- EmployeeID int foreign key references group2sp212330.Employees(EmployeeID));

----table saleDe
--create table group2sp212330.SalesDetails
--(UPC int foreign key references group2sp212330.Products(UPC),
-- SaleID int foreign key references group2sp212330.Sales(SaleID),
-- Price money,
-- Quantity int,
--Total money,
--PRIMARY KEY (UPC, SaleID));

----table order
--create table group2sp212330.Orders
--(OrderID int  primary key,
-- EmployeeID int foreign key references group2sp212330.Employees(EmployeeID),
-- OrderDate date,
-- ArrivalDate date);

----table ordDe
--create table group2sp212330.OrderDetails
--(UPC int foreign key references group2sp212330.Products(UPC),
--OrderID int  foreign key references group2sp212330.Orders(OrderID),
--EmployeeID int foreign key references group2sp212330.Employees(EmployeeID),
--Quantity int,
--Price money,
--Total money,
--PRIMARY KEY (UPC, OrderID));



--drop table group2sp212330.EmployeeInfo;

--create table group2sp212330.EmployeeInfo
--(EmployeeID int foreign key  references group2sp212330.Employees(EmployeeID),
--Name varchar(30),
-- DateofHire date,
-- Phone varchar(12),
-- Email varchar(64),
-- Address varchar(64),
-- Password varchar(18));

-- select * from  group2sp212330.EmployeeInfo;

----create table turullpsp20.ShippingLabel
----(VendorName varchar(50),
---- VendorAddress1	varchar(50),
---- VendorAddress2 varchar(50),
---- VendorCity varchar(50),
---- VendorState char(2),
---- VendorZipCode varchar(20));

----insert prod
--INSERT INTO group2sp212330.Products (UPC, Name, Price, Description, Quantity, inStock)
--VALUES
--(123456789123,'Wheelbarrow',45.99,'Heavy-duty 6 cubic foot steel tray',1,1),
--(123456789124,'ChickenFeed',19.99,'Help support the health of your hens with Chicken Food',1,1),
--(123456789125,'Shovel',15.99,'High density steel/hardwood',1,1);

----insert sale
--INSERT INTO group2sp212330.Sales (SaleID, SaleDate, ArrivalDate, CustomerID, EmployeeID)
--VALUES
--(1111111111, '01/03/2021', '01/03/2021', 23456, 12343),
--(1111111112, '01/03/2021', '01/04/2021', 23457, 12343),
--(1111111113, '01/02/2021', '01/02/2021', 23458, 12344);

----insert saleDe
--INSERT INTO group2sp212330.SalesDetails (UPC, SaleID, price, Quantity, Total)
--VALUES
--(123456789124, 1111111111, 19.99, 2, 39.98),
--(123456789123, 111111112, 45.99, 1, 45.99),
--(123456789125, 1111111113, 15.99, 1, 15.99);

----insert order
--INSERT INTO group2sp212330.Orders (OrderID, EmployeeID, OrderDate, ArrivalDate)
--VALUES
--(0000000001, 12345, '07/15/2019', '07/16/2019'),
--(0000000002, 12345, '12/05/2020', '12/06/2020'),
--(0000000003, 12345, '01/03/2021', '01/04/2021');

----insert ordDe
--INSERT INTO group2sp212330.OrderDetails (UPC,OrderID,EmployeeID,Quantity,Price,Total)
--VALUES
--(123456789123, 0000000001, 12345, 5, 45.99, 229.95),
--(123456789124, 0000000002, 12345, 100, 19.99, 1999),
--(123456789125, 0000000003, 12345, 20, 15.99, 319.80);

----insert Employ
--INSERT INTO group2sp212330.Employees (EmployeeID, SecurityLevel, ScheduleType)
--VALUES
--(12343,2,3),
--(12344,2,2),
--(12345,3,1);

----insert Schedule
--INSERT INTO group2sp212330.Schedules (ScheduleType, StartHour, LunchHour, EndHour, BreakOne, BreakTwo)
--VALUES
--(3,'06:00:00','10:00:00','15:00:00','08:00:00','13:00:00'),
--(2,'10:00:00','14:00:00','19:00:00','12:00:00','17:00:00'),
--(1,'11:00:00','15:00:00','20:00:00','13:00:00','18:00:00');

----insert Customer
--INSERT INTO group2sp212330.Customers (CustomerID, SecurityLevel, Name, Phone, Email, Address)
--VALUES
--(23456, 1, 'Nancy Smith', '254-171-2727', 'SmithN@gmail.com', 'Address 432 S. Winchester Street Parkersburg, WV 26101'),
--(23457, 1, 'Paul Jacobs', '421-852-1984', 'JacobsPaul@hotmail.com', '775 Rock Maple Street Butler, PA 16001'),
--(23458, 1, 'John Doe', '512-304-2441', 'DoeJ@gmail.com', '276 Charles Drive Elk Grove Village, IL 60007');

----insert EmpInfo
--INSERT INTO group2sp212330.EmployeeInfo (EmployeeID, DateOfHire, Phone, Email, Address)
--VALUES 
--(12343, '01/01/2021', '512-111-1234','SusanB@gmail.com', '534 Brandywine Street Glendale, AZ 85302'),
--(12344,'11/12/2020','512-222-1234','CeaserJ@gmail.com', '732 S. Warren Dr.Duarte, CA 91010'),
--(12345, '05/23/2019', '832-333-4321', 'ChurchillW@yahoo.com','9229 Penn Lane Villa Rica, GA 30180');

--member manager roles x2
--create role PaymentEntry

--grant insert update
--on turullpsp20.apInvoiceLineItems
--to PaymentEntry;

--grant update
--on turullpsp20.apinvoices
--to PaymentEntry;

--alter role db_datareader  add member PaymentEntry;

--if tables exist drop them then create

--this is the table creation sqlfile and is used SOLEY to restore data that has been lost or manipulated.

select ImageIndex, ProductImage from group2sp212330.ProdImages;