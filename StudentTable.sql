CREATE TABLE [dbo].[StudentTable]
(
	[StudentId] INT NOT NULL PRIMARY KEY, 
    [StudentName] NCHAR(30) NOT NULL, 
    [StudentLastname] NCHAR(30) NOT NULL, 
    [Classification] NCHAR(15) NOT NULL, 
    [Gender] NCHAR(10) NOT NULL, 
    [Email] NCHAR(50) NOT NULL, 
    [PhoneNumber] NCHAR(20) NOT NULL, 
    [UserId] INT NULL, 
    CONSTRAINT [FK_StudentTable_UserTable] FOREIGN KEY (UserId) REFERENCES UserTable(UserId) 
)
