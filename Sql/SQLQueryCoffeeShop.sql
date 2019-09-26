create database CoffeeShop
create table Customer (ID int identity (1,1),Name varchar(20),Contact varchar(20),Address varchar(20),Item varchar(10),Quantity int,Price float)
create table Item (ID int identity(1,1),Name varchar(10),Price float)
insert into Customer values ('Bob','01750810474','LA','Hot',3,300)
insert into Item values('Regular',80)
select * from Customer
select * from Item
update Customer set Name='Dev',Contact='0934',Address='CA',Item='Cold',Quantity=4 where ID=7
drop table Customer





















