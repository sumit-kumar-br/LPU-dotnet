create database DemoDB
go

use DemoDB
go

create table Students(Id int primary key identity(1,1),
				Name varchar(100),
				Email varchar(100)
				);
go

select * from Students


