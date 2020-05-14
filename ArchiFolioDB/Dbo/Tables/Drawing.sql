CREATE TABLE [dbo].[Drawing]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ProjectId] INT NOT NULL,
    [Name] NVARCHAR(50) NOT NULL, 
    [Type] NVARCHAR(50) NULL, 
    [Description] NVARCHAR(500) NOT NULL, 
    [ImagePath] NVARCHAR(1000) NULL, 
    CONSTRAINT [FK_Drawing_Project] FOREIGN KEY ([ProjectId]) REFERENCES [Project]([Id])
)
