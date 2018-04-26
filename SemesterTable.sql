CREATE TABLE [dbo].[SemesterTable]
(
	[SemesterId] INT NOT NULL PRIMARY KEY, 
    [Semester] NCHAR(10) NOT NULL, 
    [StarDate] DATE NOT NULL, 
    [EndDate] DATE NOT NULL
)
