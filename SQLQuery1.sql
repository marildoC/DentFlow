CREATE TABLE Patients (
    PatientID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(50),
    Surname NVARCHAR(50), 
    Phone NVARCHAR(20), 
    Email NVARCHAR(100),
    Gender NVARCHAR(10),
    DOB DATE,  
    CreatedAt DATETIME DEFAULT GETDATE(), 
    Allergies NVARCHAR(MAX), 
    Treated NVARCHAR(MAX) 
);    
 



CREATE TABLE PatientImages (
    ImageID INT PRIMARY KEY IDENTITY(1,1),
    PatientID INT,
    ImagePath NVARCHAR(MAX),
    FOREIGN KEY (PatientID) REFERENCES Patients(PatientID)  
);  




Select * From Patients 


Select * From dbo.PatientImages



CREATE TABLE Dentists (
    DentistID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(50),
    Surname NVARCHAR(50),
    Phone NVARCHAR(20),
    Email NVARCHAR(100),
    Gender NVARCHAR(10),
    DOB DATE,
    CreatedAt DATETIME DEFAULT GETDATE(),
    Specialty NVARCHAR(MAX)
);


CREATE TABLE DentistImages (
    ImageID INT PRIMARY KEY IDENTITY(1,1),
    DentistID INT,
    ImagePath NVARCHAR(MAX),
    FOREIGN KEY (DentistID) REFERENCES Dentists(DentistID)
        ON DELETE CASCADE    
    );

SELECT * From Dentists

SELECT * From DentistImages   



CREATE TABLE ClinicSettings
(
    SettingsID INT PRIMARY KEY,
    ClinicName NVARCHAR(100),

    MonOpen1 NVARCHAR(10),    
    MonClose1 NVARCHAR(10),
    MonOpen2 NVARCHAR(10),
    MonClose2 NVARCHAR(10),

    TueOpen1 NVARCHAR(10),
    TueClose1 NVARCHAR(10),
    TueOpen2 NVARCHAR(10),
    TueClose2 NVARCHAR(10),

    WedOpen1 NVARCHAR(10),
    WedClose1 NVARCHAR(10),
    WedOpen2 NVARCHAR(10),
    WedClose2 NVARCHAR(10),

    ThuOpen1 NVARCHAR(10),
    ThuClose1 NVARCHAR(10),
    ThuOpen2 NVARCHAR(10),
    ThuClose2 NVARCHAR(10),

    FriOpen1 NVARCHAR(10),
    FriClose1 NVARCHAR(10),
    FriOpen2 NVARCHAR(10),
    FriClose2 NVARCHAR(10),

    SatOpen1 NVARCHAR(10),
    SatClose1 NVARCHAR(10),
    SatOpen2 NVARCHAR(10),
    SatClose2 NVARCHAR(10),

    SunOpen1 NVARCHAR(10),
    SunClose1 NVARCHAR(10),
    SunOpen2 NVARCHAR(10),
    SunClose2 NVARCHAR(10)
); 

INSERT INTO ClinicSettings (SettingsID, ClinicName) VALUES (1, 'My Dental Clinic');

SELECT * From ClinicSettings


CREATE TABLE Appointments (
    AppointmentID INT PRIMARY KEY IDENTITY(1,1),
    DentistID INT,               
    PatientName NVARCHAR(100),   
    AppointmentDate DATE,
    AppointmentTime TIME(0),     
    Notes NVARCHAR(MAX),
    IsCanceled BIT DEFAULT 0,
    CreatedAt DATETIME DEFAULT GETDATE() 
);

ALTER TABLE Appointments
ADD PatientID INT NULL;


ALTER TABLE Appointments
ALTER COLUMN DentistID INT NOT NULL;


ALTER TABLE Appointments
ALTER COLUMN AppointmentDate DATE NOT NULL;


ALTER TABLE Appointments
ALTER COLUMN AppointmentTime TIME(0) NOT NULL;




Select * From Appointments  


EXEC sp_help 'Appointments';
 

 SELECT MonOpen1, MonClose1 , MonOpen2 , MonClose2
FROM ClinicSettings
WHERE SettingsID=1

DELETE FROM Appointments
WHERE AppointmentID = 12;  

select * from dentists



CREATE TABLE Treatments (
    TreatmentID INT PRIMARY KEY IDENTITY(1,1),
    AppointmentID INT NOT NULL,
    DentistName NVARCHAR(100) NOT NULL,
    PatientName NVARCHAR(100) NOT NULL,
    TotalAmount DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (AppointmentID) REFERENCES Appointments(AppointmentID)
);

select * from treatments 

select * from Appointments




ALTER TABLE Treatments
ALTER COLUMN AppointmentID INT NULL; 


ALTER TABLE Treatments
DROP CONSTRAINT FK__Treatment__Appoi__3C34F16F;


ALTER TABLE Treatments
ADD CONSTRAINT FK_Treatments_Appointments
    FOREIGN KEY (AppointmentID)
    REFERENCES Appointments(AppointmentID)
    ON DELETE SET NULL;

    USE YourDatabaseName;
GO
sp_help 'Treatments';


EXEC sp_help 'Treatments';

EXEC sp_fkeys 'Treatments';


ALTER TABLE Treatments
  ALTER COLUMN AppointmentID INT NULL;

ALTER TABLE Treatments
  DROP CONSTRAINT FK_Treatments_Appointments;

ALTER TABLE Treatments
  ADD CONSTRAINT FK_Treatments_Appointments
    FOREIGN KEY (AppointmentID)
    REFERENCES Appointments(AppointmentID)
    ON DELETE SET NULL;



    


    ALTER TABLE Treatments
  DROP CONSTRAINT FK_Treatments_Appointments;  



    ALTER TABLE Treatments
  ALTER COLUMN AppointmentID INT NULL;

ALTER TABLE Treatments
  DROP CONSTRAINT FK_Treatments_Appointments;   

ALTER TABLE Treatments
  ADD CONSTRAINT FK_Treatments_Appointments
    FOREIGN KEY (AppointmentID)
    REFERENCES Appointments(AppointmentID)
    ON DELETE SET NULL;




    CREATE TABLE RevenueRecords (
    RevenueID INT PRIMARY KEY IDENTITY(1,1),
    RevenueDate DATE NOT NULL,
    Amount DECIMAL(10, 2) NOT NULL,
    TreatmentID INT NULL, 
    FOREIGN KEY (TreatmentID) REFERENCES Treatments(TreatmentID)
        ON DELETE SET NULL
);

select * from RevenueRecords

select * from users





 

















