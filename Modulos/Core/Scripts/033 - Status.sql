CREATE TABLE FastConsig.dbo.Status (
  Id int IDENTITY,
  Descricao varchar(50) NOT NULL,
  Sistema bit NULL,
  CONSTRAINT PK_Status_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

SET IDENTITY_INSERT FastConsig.dbo.Status ON
GO
INSERT FastConsig.dbo.Status(Id, Descricao, Sistema) VALUES (1, 'PENDENTE', CONVERT(bit, 'True'))
INSERT FastConsig.dbo.Status(Id, Descricao, Sistema) VALUES (2, 'APROVADA', CONVERT(bit, 'True'))
INSERT FastConsig.dbo.Status(Id, Descricao, Sistema) VALUES (3, 'AGUARDANDO', CONVERT(bit, 'True'))
INSERT FastConsig.dbo.Status(Id, Descricao, Sistema) VALUES (4, 'REJEITADA', CONVERT(bit, 'True'))
INSERT FastConsig.dbo.Status(Id, Descricao, Sistema) VALUES (5, 'CANCELADA', CONVERT(bit, 'True'))
INSERT FastConsig.dbo.Status(Id, Descricao, Sistema) VALUES (6, 'SALVA', CONVERT(bit, 'True'))
INSERT FastConsig.dbo.Status(Id, Descricao, Sistema) VALUES (7, 'RECUSADA', CONVERT(bit, 'True'))
INSERT FastConsig.dbo.Status(Id, Descricao, Sistema) VALUES (8, 'PROCESSANDO', CONVERT(bit, 'True'))
INSERT FastConsig.dbo.Status(Id, Descricao, Sistema) VALUES (9, 'CONCLUIDO', CONVERT(bit, 'True'))
INSERT FastConsig.dbo.Status(Id, Descricao, Sistema) VALUES (10, 'COM ERRO', CONVERT(bit, 'True'))
INSERT FastConsig.dbo.Status(Id, Descricao, Sistema) VALUES (11, 'REPROCESSANDO', CONVERT(bit, 'True'))
INSERT FastConsig.dbo.Status(Id, Descricao, Sistema) VALUES (12, 'SUBMETIDA', CONVERT(bit, 'True'))
GO
SET IDENTITY_INSERT FastConsig.dbo.Status OFF
GO