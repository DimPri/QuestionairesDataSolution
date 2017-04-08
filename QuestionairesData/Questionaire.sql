CREATE TABLE [dbo].[Questionaire]
(
	[Id] INT IDENTITY (1,1) NOT NULL,	 
    [Codename] NCHAR(10) NOT NULL,     
    [Comments] NVARCHAR(60) NULL,
	CONSTRAINT [PK_QuestionairesTable] PRIMARY KEY ([Id]) 
)
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Codename like ΕΕΞ, ΣΑ2301',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'Questionaire',
    @level2type = N'COLUMN',
    @level2name = N'Codename'