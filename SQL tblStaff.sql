CREATE TABLE tblStaff
(
    StaffID INT IDENTITY(1,1) PRIMARY KEY,

    StaffName VARCHAR(100),

    Position VARCHAR(50),

    Phone VARCHAR(20),

    Email VARCHAR(100),

    Status VARCHAR(50)
)

INSERT INTO tblStaff
VALUES
('Syafaiz','Senior Groomer','0121111111','syafaiz@furcare.com','Active'),

('Imran','Assistant Groomer','0122222222','imran@furcare.com','Active'),

('Bukhari','Pet Stylist','0123333333','bukhari@furcare.com','Active');