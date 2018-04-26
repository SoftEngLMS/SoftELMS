CREATE TABLE [dbo].[CourseTable]
(
	[CourseId] INT NOT NULL PRIMARY KEY, 
    [CourseName] NCHAR(30) NOT NULL, 
    [Credits] INT NOT NULL, 
    [Semester] INT NOT NULL, 
    [FacultyId] INT NOT NULL, 
    [StartDate] DATE NOT NULL, 
    [EndDate] DATE NOT NULL, 
    CONSTRAINT [FK_CourseTable_SemesterTable] FOREIGN KEY (Semester) REFERENCES SemesterTable(SemesterId), 
    CONSTRAINT [FK_CourseTable_ToTable] FOREIGN KEY (FacultyId) REFERENCES FacultyTable(FacultyId)
)
