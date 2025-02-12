CREATE TABLE FastConsig.dbo.JobFilaStatus (
  Id int IDENTITY,
  Descricao varchar(50) NOT NULL,
  CONSTRAINT PK_JobFilaStatus PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

SET IDENTITY_INSERT FastConsig.dbo.JobFilaStatus ON
GO
INSERT FastConsig.dbo.JobFilaStatus(Id, Descricao) VALUES (1, 'Em Fila de Processamento')
INSERT FastConsig.dbo.JobFilaStatus(Id, Descricao) VALUES (2, 'Em Processamento')
INSERT FastConsig.dbo.JobFilaStatus(Id, Descricao) VALUES (3, 'Processada')
INSERT FastConsig.dbo.JobFilaStatus(Id, Descricao) VALUES (5, 'Não Processada')
INSERT FastConsig.dbo.JobFilaStatus(Id, Descricao) VALUES (6, 'Finalizada (Não Processada)')
INSERT FastConsig.dbo.JobFilaStatus(Id, Descricao) VALUES (7, 'DataPrev Cancelamento Taxa Juros')
GO
SET IDENTITY_INSERT FastConsig.dbo.JobFilaStatus OFF
GO