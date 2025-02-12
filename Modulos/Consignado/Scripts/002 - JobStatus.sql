CREATE TABLE FastConsig.dbo.JobStatus (
  Id char(1) NOT NULL,
  Descricao varchar(50) NOT NULL,
  CONSTRAINT PK_JobStatus PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

INSERT FastConsig.dbo.JobStatus(Id, Descricao) VALUES (N'A', 'Aguardando')
INSERT FastConsig.dbo.JobStatus(Id, Descricao) VALUES (N'C', 'Encerrado')
INSERT FastConsig.dbo.JobStatus(Id, Descricao) VALUES (N'E', 'Erro')
INSERT FastConsig.dbo.JobStatus(Id, Descricao) VALUES (N'O', 'Processado')
INSERT FastConsig.dbo.JobStatus(Id, Descricao) VALUES (N'P', 'Processando')
INSERT FastConsig.dbo.JobStatus(Id, Descricao) VALUES (N'R', 'Revisar')
GO