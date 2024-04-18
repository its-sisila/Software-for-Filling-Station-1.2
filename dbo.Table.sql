CREATE TABLE [Users]
(
    [firstName] NVARCHAR(50) NOT NULL, 
    [lastName] NVARCHAR(50) NOT NULL, 
    [username] NVARCHAR(50) NOT NULL, 
    [password] NCHAR(10) NOT NULL, 
    [id] NCHAR(10) NOT NULL, 
    PRIMARY KEY ([id])
)
