CREATE TABLE [dbo].[FacultyTable]
(
	[FacultyId] INT NOT NULL PRIMARY KEY, 
    [ProfName] NCHAR(30) NOT NULL, 
    [ProfLastname] NCHAR(30) NOT NULL, 
    [Email] NCHAR(50) NOT NULL, 
    [PhoneNumber] NCHAR(20) NOT NULL, 
    [UserId] INT NULL, 
    CONSTRAINT [FK_FacultyTable_UserTable] FOREIGN KEY (UserId) REFERENCES UserTable(UserId) 
)
