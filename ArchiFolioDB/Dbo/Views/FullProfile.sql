CREATE VIEW [dbo].[FullProfile]
	AS 

	SELECT	[prof].[Id] AS profId, [prof].[FirstName], [prof].[LastName], 
			[prof].[EmailAddress], [prof].[Description] AS profDescription, 
			[prof].[ImagePath] AS profImage, [prof].[Profession] , 
			
			[proj].[Id], [proj].[ProfileId], [proj].[Name], 
			[proj].[Description], [proj].[ImagePath], 
			[proj].[Location], [proj].[Budget], [proj].[Type]
	FROM		dbo.Profile prof
	LEFT JOIN	dbo.Project proj
	ON			prof.Id = proj.ProfileId
