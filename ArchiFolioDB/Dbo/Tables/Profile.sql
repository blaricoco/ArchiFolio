CREATE TABLE [dbo].[Profile]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [EmailAddress] NVARCHAR(100) NOT NULL, 
    [Description] NVARCHAR(500) NOT NULL, 
    [ImagePath] NVARCHAR(1000) NULL, 
    [Profession] NVARCHAR(50) NULL
)
