CREATE TABLE tblFeedback
(
    FeedbackID INT IDENTITY(1,1) PRIMARY KEY,

    AppointmentID INT,

    Rating INT,

    Comments VARCHAR(500),

    FeedbackDate DATETIME,

    FOREIGN KEY(AppointmentID)
    REFERENCES tblAppointments(AppointmentID)
)