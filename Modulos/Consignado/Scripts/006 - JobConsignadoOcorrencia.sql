CREATE TABLE FastConsig.dbo.JobConsignadoOcorrencia (
  Id int IDENTITY,
  JobId int NOT NULL,
  ConsignadoOcorrenciaId int NOT NULL,
  Acao int NULL,
  Ocorrencia int NULL,
  CONSTRAINT PK_JobConsignadoOcorrencia PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.JobConsignadoOcorrencia
  ADD CONSTRAINT FK_JobConsignadoOcorrencia_Job FOREIGN KEY (JobId) REFERENCES dbo.Job (Id)
GO

