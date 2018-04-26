CREATE TABLE [dbo].[UserTable]
(
	[UserId] INT NOT NULL PRIMARY KEY, 
    [Username] NCHAR(25) NOT NULL, 
    [Password] NCHAR(20) NOT NULL, 
    [Role] NCHAR(10) NOT NULL
)
