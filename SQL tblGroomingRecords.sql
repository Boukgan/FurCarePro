CREATE TABLE tblGroomingRecords
(
    RecordID INT IDENTITY(1,1) PRIMARY KEY,

    AppointmentID INT,

    StaffID INT,

    GroomingNotes VARCHAR(500),

    GroomingStatus VARCHAR(50),

    CompletionDate DATETIME,

    FOREIGN KEY(AppointmentID)
    REFERENCES tblAppointments(AppointmentID),

    FOREIGN KEY(StaffID)
    REFERENCES tblStaff(StaffID)
)