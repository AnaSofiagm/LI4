CREATE TABLE [dbo].[Receita]
(
	[IdReceita] INT NOT NULL PRIMARY KEY, 
    [NomeReceita] NVARCHAR(50) NOT NULL, 
    [Dificuldade] INT NOT NULL, 
    [Avaliacao] INT NOT NULL, 
    [Categoria] NVARCHAR(50) NOT NULL, 
    [InformacaoNutricional] TEXT NOT NULL, 
    [TempoPreparacao] INT NOT NULL
)
