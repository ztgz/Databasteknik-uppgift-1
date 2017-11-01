USE master
GO

IF EXISTS(SELECT name FROM sys.databases WHERE name = 'Uppgift1')
     DROP DATABASE Uppgift1
GO

--DROP DATABASE Uppgift1;
CREATE DATABASE Uppgift1;
GO

USE Uppgift1;

CREATE TABLE Adress(
	Postnummer varchar(10),
	Gatuadress varchar(100),
	Postort varchar(100) NOT NULL,
	i int identity(1,1) NOT NULL,
	PRIMARY KEY(Postnummer,Gatuadress)
);

CREATE TABLE Person(
	Id int IDENTITY(1,1) PRIMARY KEY,
	Namn varchar(100) not null,
	Epost varchar(100)
);

CREATE TABLE PersonligKontakt(
	Id int IDENTITY(1,1) primary key,
	FK_Id int,
	FOREIGN KEY (FK_Id) REFERENCES Person(Id)
);

CREATE TABLE JobbKontakt(
	Id int IDENTITY(1,1) primary key,
	FK_Id int,
	FOREIGN KEY (FK_Id) REFERENCES Person(Id)
);

CREATE TABLE ÖvrigKontakt(
	Id int IDENTITY(1,1) primary key,
	FK_Id int,
	FOREIGN KEY (FK_Id) REFERENCES Person(Id)
);

CREATE TABLE Adressregister(
	AdressId int IDENTITY(1,1) PRIMARY KEY,
	FK_Id int REFERENCES Person(Id)
	ON DELETE CASCADE
	ON UPDATE CASCADE,
	FK_Postnummer varchar(10),
	FK_Gatuadress varchar(100),
	FOREIGN KEY (FK_Postnummer,FK_Gatuadress) REFERENCES Adress(Postnummer,Gatuadress)
	ON DELETE CASCADE
	ON UPDATE CASCADE
);

CREATE TABLE Telefonnummer(
	Nummer varchar(50) PRIMARY KEY
);

CREATE TABLE Telefonlista(
	TelefonId int IDENTITY(1,1) PRIMARY KEY,
	FK_Nummer varchar(50),
	FK_Id int,
	FOREIGN KEY (FK_Nummer) REFERENCES Telefonnummer(Nummer)
	ON DELETE CASCADE
	ON UPDATE CASCADE,
	FOREIGN KEY (FK_Id) REFERENCES Person(Id)
	ON DELETE CASCADE
	ON UPDATE CASCADE
);

INSERT INTO Person
values ('Arvid Ek', 'Arvid@testmail.com'),
		('Johan En', 'johan@testmail.com');

INSERT INTO Person(Namn)
values('Elin Persson');

INSERT INTO PersonligKontakt
VALUES(1)

INSERT INTO ÖvrigKontakt
VALUES(2)

INSERT INTO JobbKontakt
VALUES(3)

INSERT Adress
values('16970', 'Gårdsvägen', 'Solna'),
		('75421', 'Frödringsgatan', 'Uppsala');

INSERT INTO Adressregister(FK_Id, FK_Postnummer, FK_Gatuadress)
VALUES (1, '16970', 'Gårdsvägen'),
	(3, '16970', 'Gårdsvägen'),
	(2, '75421', 'Frödringsgatan');

INSERT INTO Telefonnummer(Nummer)
values('0764666333'),
	  ('0365555888'),
	  ('0764666555');

INSERT INTO Telefonlista(FK_Nummer, FK_Id)
VALUES('0764666333', 1),
	('0764666333', 3),
	('0365555888', 2);
