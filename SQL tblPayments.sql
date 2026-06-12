CREATE TABLE tblPayments
(
    PaymentID INT IDENTITY(1,1) PRIMARY KEY,

    AppointmentID INT,

    Amount DECIMAL(10,2),

    PaymentMethod VARCHAR(50),

    PaymentDate DATETIME,

    PaymentStatus VARCHAR(50),

    FOREIGN KEY(AppointmentID)
    REFERENCES tblAppointments(AppointmentID)
)