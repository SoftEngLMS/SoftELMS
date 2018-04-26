CREATE TABLE [dbo].[AssignmentTable]
(
	[AssignmentId] INT NOT NULL	, 
    [StudentId] INT NOT NULL, 
    [CourseId] INT NOT NULL, 
    [Description] NCHAR(250) NOT NULL, 
    [StartDate] DATE NOT NULL, 
    [DueDate] DATETIME NOT NULL, 
    [Grade] INT NULL, 
    [FacultyId] INT NOT NULL, 
    CONSTRAINT [FK_AssignmentTable_FacultyTable] FOREIGN KEY (FacultyId) REFERENCES FacultyTable(FacultyId), 
    CONSTRAINT [FK_AssignmentTable_CourseTable] FOREIGN KEY (CourseId) REFERENCES CourseTable(CourseId), 
    CONSTRAINT [FK_AssignmentTable_ToTable] FOREIGN KEY (StudentId) REFERENCES StudentTable(StudentId)
)
