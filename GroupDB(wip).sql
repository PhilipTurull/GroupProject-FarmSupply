if exists(select * from  group2sp212330.OrderDetails)
drop table group2sp212330.OrderDetails;

if exists(select * from  group2sp212330.Orders)
drop table group2sp212330.Orders;

if exists(select * from  group2sp212330.SalesDetails)
drop table group2sp212330.SalesDetails;

if exists(select * from  group2sp212330.Sales)
drop table group2sp212330.Sales;

if exists(select * from  group2sp212330.Customers)
drop table group2sp212330.Customers;

if exists(select * from  group2sp212330.EmployeeInfo)
drop table group2sp212330.EmployeeInfo;

if exists(select * from  group2sp212330.Employees)
drop table group2sp212330.Employees;

if exists(select * from  group2sp212330.Schedules)
drop table group2sp212330.Schedules;

if exists(select * from  group2sp212330.Products)
drop table group2sp212330.Products;

--table prod
create table group2sp212330.Products 
(UPC int primary key,
 Name varchar(80),
 Price money,
 Description varchar(100),
 Quantity int,
inStock bit);

--table Schedule
create table group2sp212330.Schedules
(ScheduleType int primary key,
StartHour time,
LunchHour time,
EndHour time,
BreakOne time,
BreakTwo time);

--table Employ
create table group2sp212330.Employees
(EmployeeID int primary key,
 SecurityLevel int,
 ScheduleType int foreign key references group2sp212330.Schedules(ScheduleType));

--table Customer
create table group2sp212330.Customers
(CustomerID int  primary key,
 SecurityLevel int,
 Name varchar(40),
 Phone varchar(12),
 Email varchar(64),
 Address varchar(64));

--table sale
create table group2sp212330.Sales
(SaleID int primary key,
 SaleDate date,
 ArrivalDate date,
 CustomerID int foreign key references group2sp212330.Customers(CustomerID),
 EmployeeID int foreign key references group2sp212330.Employees(EmployeeID));

--table saleDe
create table group2sp212330.SalesDetails
(UPC int foreign key references group2sp212330.Products(UPC),
 SaleID int foreign key references group2sp212330.Sales(SaleID),
 Price money,
 Quantity int,
Total money,
PRIMARY KEY (UPC, SaleID));

--table order
create table group2sp212330.Orders
(OrderID int  primary key,
 EmployeeID int foreign key references group2sp212330.Employees(EmployeeID),
 OrderDate date,
 ArrivalDate date);

--table ordDe
create table group2sp212330.OrderDetails
(UPC int foreign key references group2sp212330.Products(UPC),
OrderID int  foreign key references group2sp212330.Orders(OrderID),
EmployeeID int foreign key references group2sp212330.Employees(EmployeeID),
Quantity int,
Price money,
Total money,
PRIMARY KEY (UPC, OrderID));



--table EmpInfo
create table group2sp212330.EmployeeInfo
(EmployeeID int foreign key  references group2sp212330.Employees(EmployeeID),
 DateofHire date,
 Phone varchar(12),
 Email varchar(64),
 Address varchar(64));

 select * from  group2sp212330.EmployeeInfo;

--create table turullpsp20.ShippingLabel
--(VendorName varchar(50),
-- VendorAddress1	varchar(50),
-- VendorAddress2 varchar(50),
-- VendorCity varchar(50),
-- VendorState char(2),
-- VendorZipCode varchar(20));

--insert prod
--insert sale
--insert saleDe
--insert order
--insert ordDe
--insert Employ
--insert Schedule
--insert Customer
--insert EmpInfo

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