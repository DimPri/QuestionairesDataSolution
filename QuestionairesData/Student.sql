CREATE TABLE [dbo].[Student]
(
	[Id] INT PRIMARY KEY IDENTITY (1,1) NOT NULL, 
    [FirstName] NVARCHAR(20) NULL, 
    [LastName] NVARCHAR(30) NULL, 
    [Asma] NCHAR(10) NULL, 
    [Seira] NCHAR(3) NULL, 
    [Tmhma] NCHAR(2) NULL
)