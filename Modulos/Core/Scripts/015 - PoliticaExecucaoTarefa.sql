CREATE TABLE FastConsig.dbo.PoliticaExecucaoTarefa (
  Id int IDENTITY,
  TipoTarefa int NOT NULL,
  Politica int NOT NULL,
  Peso int NOT NULL,
  Validacao bit NULL,
  Execucao bit NULL,
  Erro bit NULL,
  Exito bit NULL,
  CONSTRAINT PK_PoliticaExecucaoTarefa_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO