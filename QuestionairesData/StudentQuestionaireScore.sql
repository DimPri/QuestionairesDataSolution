CREATE TABLE [dbo].[StudentQuestionaireScore]
(
	[QuestionaireId] INT NOT NULL , 
    [StudentId] INT NOT NULL, 
	[IsReExamination] BIT NOT NULL,
    [ClosedBookScore] INT NULL, 
    [OpenBookScore] INT NULL, 
    [LimitsScore] NCHAR(1) NULL, 
    [BoldfaceScore] NCHAR(1) NULL, 
	[DateOfScoring] DATE NOT NULL,	
	CONSTRAINT [PK_StudentQuestionaireScoresTable] PRIMARY KEY ([QuestionaireId],[StudentId]),
    CONSTRAINT [FK_1_StudentQuestionaireScoresTable_ToQuestionairesTable] FOREIGN KEY ([QuestionaireId]) REFERENCES [dbo].[Questionaire]([Id]) ON DELETE CASCADE,	
    CONSTRAINT [FK_2_StudentQuestionaireScoresTable_ToStudentsTable] FOREIGN KEY ([StudentId]) REFERENCES [Student]([Id]) ON DELETE CASCADE  
)
