CREATE TABLE FastConsig.dbo.Fila (
  Id int IDENTITY,
  Nome varchar(200) NULL,
  CONSTRAINT PK_Fila_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

SET IDENTITY_INSERT FastConsig.dbo.Fila ON
GO
INSERT FastConsig.dbo.Fila(Id, Nome) VALUES (1, 'default')
INSERT FastConsig.dbo.Fila(Id, Nome) VALUES (2, 'fastconsig')
INSERT FastConsig.dbo.Fila(Id, Nome) VALUES (3, 'sincronizacao')
INSERT FastConsig.dbo.Fila(Id, Nome) VALUES (4, 'averbacao_dataprev')
INSERT FastConsig.dbo.Fila(Id, Nome) VALUES (5, 'averbacao_serpro')
GO
SET IDENTITY_INSERT FastConsig.dbo.Fila OFF
GO