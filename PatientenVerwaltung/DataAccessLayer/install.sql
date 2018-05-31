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
	email VARCHAR(100),
	active BIT DEFAULT 1
);

CREATE TABLE patient_card (
	id INT IDENTITY(0, 1) PRIMARY KEY,
	patient_id INT NOT NULL FOREIGN KEY REFERENCES patient(id),
	active BIT DEFAULT 1
);

CREATE TABLE treatment (
	id INT IDENTITY(0, 1) PRIMARY KEY,
	patientcard_id INT NOT NULL FOREIGN KEY REFERENCES patient_card(id),
	date_of_treatment DATE NOT NULL,
	[description] VARCHAR(2048),
	examination VARCHAR(2048),
	cost MONEY NOT NULL,
	active BIT DEFAULT 1
);

CREATE TABLE prescription (
	id INT IDENTITY(0, 1) PRIMARY KEY,
	treatment_id INT NOT NULL FOREIGN KEY REFERENCES treatment(id),
	[description] VARCHAR(2048),
	active BIT DEFAULT 1
);

CREATE TABLE recipe (
	prescription_id INT NOT NULL FOREIGN KEY REFERENCES prescription(id),
	medication VARCHAR(1024) NOT NULL,
	instruction VARCHAR(2048) NOT NULL,
	active BIT DEFAULT 1
);