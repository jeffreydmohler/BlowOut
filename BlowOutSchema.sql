/**************************************
​
Creator: Eric Louis - Group 16
​
Description: DB Schema for Checkpoint 4 - IS 403
Creates the BlowOut Database and populates the Instruments table
​
​
***************************************/
​
​
USE master;
​
IF (NOT EXISTS(SELECT name
FROM master.sys.databases
WHERE name LIKE 'BlowOut'))
​
BEGIN
CREATE DATABASE BlowOut;
​
END
​
GO
​
IF(EXISTS(SELECT name
FROM master.sys.databases
WHERE name LIKE 'BlowOut'))
​
BEGIN
​
CREATE TABLE BlowOut.dbo.Client (
    ClientID INT IDENTITY (1, 1) NOT NULL,
    ClientFirstName VARCHAR (30) NOT NULL,
    ClientLastName VARCHAR (30) NOT NULL,
    ClientAddress VARCHAR (30) NOT NULL,
    ClientCity VARCHAR (30) NOT NULL,
    ClientState VARCHAR (30) NOT NULL,
    ClientZip VARCHAR (5) NOT NULL,
    ClientEmail VARCHAR (30) NOT NULL,
    ClientPhone VARCHAR (15) NOT NULL,
	InstrumentCode INT,
    PRIMARY KEY CLUSTERED (ClientID ASC)
);
END
​
USE BlowOut;
​
IF (EXISTS(SELECT * 
	FROM INFORMATION_SCHEMA.TABLES
	WHERE TABLE_NAME = 'Instruments'))
​
BEGIN
	DROP TABLE Instruments;
END
​
	CREATE TABLE Instruments (
    InstrumentCode INT IDENTITY (1,1) NOT NULL,
    InstrumentName VARCHAR (20) NOT NULL,
    InstrumentType VARCHAR (5) NOT NULL,
    Price DECIMAL (6,2) NOT NULL,
    PRIMARY KEY CLUSTERED (InstrumentCode ASC)
	);
​
	INSERT INTO Instruments (InstrumentName, InstrumentType, Price)
	VALUES
​
	('Trumpet', 'New',55),
	('Trombone', 'New', 60),
	('Tuba', 'New', 70),
	('Flute', 'New', 40),
	('Clarinet', 'New', 35),
	('Saxophone', 'New', 42),
​
	('Trumpet', 'Used', 30),
	('Trombone', 'Used', 40),
	('Tuba', 'Used', 45),
	('Flute', 'Used', 25),
	('Clarinet', 'Used', 20),
	('Saxophone', 'Used', 22);
​
ALTER TABLE Client
	ADD CONSTRAINT FK_Client_Instruments
	FOREIGN KEY (InstrumentCode) 
		REFERENCES Instruments (InstrumentCode);