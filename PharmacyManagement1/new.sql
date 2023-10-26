
Create database Pharmacy123

create table users(
Id int identity(1,1) primary key,
UserRole varchar(50) not null,
Name varchar(250) not null,
Dob varchar(250) not null,
Mobile bigint not null,
Email varchar(250) not null,
Username varchar(250) unique not null,
Pass varchar(250) not null
)
select * from users

create table Medic(
Id int identity(1,1) primary key,
Mid varchar(250) not null,
Mname varchar(250) not null,
Mnumber varchar(250) not null,
Mdate date,
Edate date,
Quantity bigint not null,
Perunit bigint not null
)
select * from Medic
select Mname from Medic where Edate >= getdate() and Quantity >'0'
select Mname from Medic where Edate >= getdate() and Quantity >'0'