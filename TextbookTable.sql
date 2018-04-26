CREATE TABLE [dbo].[TextbookTable]
(
	[BookId] INT NOT NULL PRIMARY KEY, 
    [BookName] NCHAR(50) NOT NULL, 
    [CourseId] INT NOT NULL, 
    CONSTRAINT [FK_TextbookTable_CourseTable] FOREIGN KEY (CourseId) REFERENCES CourseTable(CourseId)
)
