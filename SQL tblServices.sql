CREATE TABLE tblServices
(
    ServiceID INT IDENTITY(1,1) PRIMARY KEY,

    ServiceName VARCHAR(100),

    Price DECIMAL(10,2),

    Duration INT,

    Description VARCHAR(255)
)

INSERT INTO tblServices
VALUES
('Basic Wash',25,30,'Basic pet wash'),

('Full Grooming',60,90,'Complete grooming'),

('Nail Trimming',15,15,'Nail trimming service'),

('Ear Cleaning',20,20,'Ear cleaning service'),

('Premium Spa',120,120,'Luxury spa package')