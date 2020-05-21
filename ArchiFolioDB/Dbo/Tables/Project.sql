CREATE TABLE [dbo].[Project]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ProfileId] INT NOT NULL,
    [Name] NVARCHAR(50) NOT NULL, 
    [Description] NVARCHAR(500) NOT NULL, 
    [ImagePath] NVARCHAR(1000) NULL, 
    [Location] NCHAR(50) NULL, 
    [Budget] INT NULL, 
    [Type] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [FK_Project_Profile] FOREIGN KEY ([ProfileId]) REFERENCES [Profile]([Id])
)
