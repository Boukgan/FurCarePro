CREATE TABLE tblPets
(
    PetID INT IDENTITY(1,1) PRIMARY KEY,

    CustomerID INT,

    PetName VARCHAR(100),

    Species VARCHAR(50),

    Breed VARCHAR(100),

    Gender VARCHAR(20),

    Weight DECIMAL(5,2),

    FOREIGN KEY(CustomerID)
    REFERENCES tblUsers(UserID)
);