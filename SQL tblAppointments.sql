CREATE TABLE tblAppointments
(
    AppointmentID INT IDENTITY(1,1) PRIMARY KEY,

    PetID INT,

    ServiceID INT,

    AppointmentDate DATETIME,

    Status VARCHAR(50),

    FOREIGN KEY(PetID)
    REFERENCES tblPets(PetID),

    FOREIGN KEY(ServiceID)
    REFERENCES tblServices(ServiceID)
)