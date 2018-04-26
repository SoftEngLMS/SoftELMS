CREATE TABLE [dbo].[ClassroomTable]
(
	[ClassId] INT NOT NULL PRIMARY KEY, 
    [CourseId] INT NOT NULL, 
    [StudentId] INT NOT NULL, 
    [FacultyId] INT NOT NULL,
	CONSTRAINT [FK_ClassroomTable_CourseTable] FOREIGN KEY (CourseId) REFERENCES CourseTable(CourseId), 
    CONSTRAINT [FK_ClassroomTable_StudenTable] FOREIGN KEY (StudentId) REFERENCES StudentTable(StudentId), 
    CONSTRAINT [FK_ClassroomTable_FacultyTable] FOREIGN KEY (FacultyId) REFERENCES FacultyTable(FacultyId)

)
