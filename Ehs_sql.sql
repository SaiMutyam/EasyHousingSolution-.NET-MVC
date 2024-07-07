
Create database Ehs_Db;

use Ehs_Db


Create table Users
(
	UserID int identity(1,1) primary key,
	UserName varchar(25) ,
	Password varchar(25) not null,
	UserType varchar(15)
);


Create table States
(
	StateId int identity(1,1) primary key,
	StateName varchar(30)
);

Create table City
(
	CityId int identity(1,1) primary key,
	CityName varchar(50) not null,
	StateId int not null FOREIGN KEY REFERENCES States(StateId)
);

Create table Seller
(
	SellerId int identity(1,1) primary key,
	UserName varchar(25) not null,
	FirstName varchar(25) not null,
	LastName varchar(25),
	DateofBirth date not null,
	PhoneNo varchar(10) not null,
	Address varchar(250) not null,
	StateId int not null FOREIGN KEY REFERENCES States(StateId),
	CityId int  not null FOREIGN KEY REFERENCES City(CityId),
	EmailId varchar(50) not null
);






Create table Buyer
(
	BuyerId int identity(1,1) primary key,
	FirstName varchar(25) not null,
	LastName varchar(25),
	DateOfBirth date not null,
	PhoneNo varchar(10) not null,
	EmailId varchar(50) not null
);


Create table Property
(
	PropertyId int identity(1,1) primary key,
	PropertyName varchar(50) not null,
	PropertyType varchar(15) not null,
	PropertyOption varchar(10) not null,
	Description varchar(250),
	Address varchar(250) not null,
	PriceRange money not null,
	InitialDeposit money not null,
	LandMark varchar(25) not null,
	IsActive bit not null,
	SellerId int not null FOREIGN KEY REFERENCES Seller(SellerId)
);


Create table Images
(
	ImageId int identity(1,1) primary key,
	PropertyId int not null FOREIGN KEY REFERENCES Property(PropertyId),
	Image image not null
);

Create table Cart
(
	CartId int identity(1,1) primary key,
	BuyerId int not null Foreign key REFERENCES Buyer(BuyerId),
	PropertyId int not null FOREIGN KEY REFERENCES Property(PropertyId)
);

select * from Users;
select * from States;
select * from Seller;
select * from Property;
select * from Images;
select * from City;
select * from Cart;
select * from Buyer;





 insert into States values('Karnataka');
 insert into States values('Andra Pradesh');
 insert into States values('Bihar');
 insert into States values('Kerala');
 insert into States values('Maharashtra');
 insert into States values('Tamil Nadu');
 insert into States values('Telangana');

 select*from States
 

 insert into City values('Bangalore',1);
 insert into City values('Hyderabad',2);
 insert into City values('Patna',3);
 insert into City values('Trivandrum',4);
 insert into City values('Mumbai',5);
 insert into City values('Chennai',6);
 insert into City values('Hyderabad',7);
 
 select*from City

 
insert into Buyer values( 'alok', 'sharma','1992-01-22',9867543065,'alok@gmail.com');

insert into Buyer values( 'elok', 'NULL','1900-10-06',9867543065,'elok@gmail.com');

insert into Buyer values('aliya', 'savitha','1900-10-01',9867543065,'aliya@gmail.com');

insert into Buyer values( 'amulu', 'shree','1900-01-12',9867543065,'amulu@gmail.com');

insert into Buyer values( 'arya', 'shilpa','1890-12-12',9867543065,'arya@gmail.com');

insert into Buyer values( 'kaviya', 'sharma','1990-10-01',9867543065,'kaviya@gmail.com');

insert into Buyer values( 'arish', 'NULL','2000-12-12',9867543065,'arish@gmail.com');



INSERT INTO Seller VALUES('AMITHANAND','AMITH','ANAD','2012-01-22',8086555847,'KERALA',1,1,'AMITH@GMAIL.COM');
INSERT INTO Seller VALUES('KUMARALOK','ALOK','KUMAR','2017-02-12',8086555777,'KARNADAKA',2,2,'ALOKKUMAR@GMAIL.COM');
INSERT INTO Seller VALUES('SREEANJU','ANJU','SREE','1990-03-23',8086555888,'TAMIL NADU',3,3,'ANJUSREE@GMAIL.COM');
INSERT INTO Seller VALUES('RIYAANAND','RIYA','ANAD','1999-05-19',8086558797,'KERALA',4,4,'RIYA@GMAIL.COM');
INSERT INTO Seller VALUES('AYSHAASHOK','AYSHA','ASHOK','1998-03-20',8086555846,'KERALA',5,5,'AYSHAASHOK@GMAIL.COM');
INSERT INTO Seller VALUES('MANJIMA','MANJIMA','MAHESH','1969-01-25',8086444481,'DELHI',6,6,'MANJIMAMAHESH.COM');
INSERT INTO Seller VALUES('ANJALI','ANAGA','ANJALI','2000-04-22',8086555123,'PUNE',7,7,'ANJALI@GMAIL.COM');


insert into Property VALUES('Jaswanth Villa','Single House','Rent','3 BHK,2800 sft,Peaceful environment','#06 Jaswanth Villa,Nizampet,Hyderabad,Telangana',4000-5000,2500,'Nizampet',1,1);
insert into Property VALUES('HHH APARTMENTS','Flat','Rent','2 BHK,1500 sft,Community','#301,Hemavathi badavane,Mysore,Karnataka',2000-3000,1500,'Hemavathi badvane',1,2);
insert into Property VALUES('Sri Constructions','Vacant Land','Lease','6000 sft,Land for lease','#321,Townhall,hundred road street,Mumbai,Maharastra',300-450,500,'hundred road street',1,3);
insert into Property VALUES('VVV Residency','Group House','sale','5900 sft,Gound Floor in Group House is for sale','#02  ,skyline villa,Kozhikode, Kerala',300-450,500,'Kozhikode',1,4);
insert into Property VALUES('Friends Cafe','Shop/Cafe','Rent','1260 sft,Cafe is for rent at crowded people area','#118,Friends Cafe,Madrasroadstreet,Kazibad,Pune',300-450,500,'Madrasroadstreet',1,5);
insert into Property VALUES('Farmers Association','Agri Land','Sale','1.5 Acre,2 Crops per Year, Good Soil','#900,mountain hill,kodaikanal,Kashmircity,Delhi',8000000-8600000,200000,'Kodaikanal',1,6);
insert into Property VALUES('STAY HOME','P.G Hostel','Rent','3 Sharing,Including Food and Lockers','#876,goodlightstreet,mindtreeroad,Gujarat',8000000-8600000,200000,'GoodlightStreet',1,7);

select * from Property;

insert into Users values ('Rajakanth','raja@123','Seller');
insert into Users values ('Delip','delip@147','Buyer');
insert into Users values ('Manjunath','manju@258','Seller') 
insert into Users values ('Raguram','raguram@369','Buyer');
insert into Users values ('Sumithra','sumi@789','Seller');
insert into Users values ('Ramya','ram@456','Buyer');
insert into Users values ('Pavithra','pavi@321','Seller');
insert into Users values ('Mohan','mohan@654','Buyer');

select * from Users;


select * from AspNetRoleClaims;
select * from AspNetRoles;
select * from AspNetUserClaims;
select * from AspNetUserLogins;
select * from AspNetUserRoles;
select * from AspNetUsers;
select * from AspNetUserTokens;


select * from AspNetRoles;
select * from AspNetUserRoles;
select * from AspNetUsers;










