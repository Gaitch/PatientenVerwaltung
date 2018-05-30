CREATE DATABASE praxis;
USE praxis;

CREATE TABLE patient (
	id INT IDENTITY(0, 1) PRIMARY KEY,
	title VARCHAR(50),
	gender VARCHAR(50) NOT NULL,
	lastname VARCHAR(100) NOT NULL,
	firsatname VARCHAR(100) NOT NULL,
	birthdate DATE NOT NULL,
	[address] VARCHAR(100),
	zipcode VARCHAR(10),
	phone VARCHAR(30),
	email VARCHAR(100)
);

CREATE TABLE patient_card (
	id INT IDENTITY(0, 1) PRIMARY KEY,
	patient_id INT NOT NULL,
);

CREATE TABLE treatment (
	id INT IDENTITY(0, 1) PRIMARY KEY,
	patientcard_id INT NOT NULL,
	date_of_treatment DATE NOT NULL,
	[description] VARCHAR(2048),
	examination VARCHAR(2048),
	cost MONEY NOT NULL
);

CREATE TABLE prescription (
	id INT IDENTITY(0, 1) PRIMARY KEY,
	treatment_id INT NOT NULL,
	[description] VARCHAR(2048)
);

CREATE TABLE recipe (
	prescription_id INT NOT NULL,
	medication VARCHAR(1024) NOT NULL,
	instruction VARCHAR(2048) NOT NULL
);