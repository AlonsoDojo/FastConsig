CREATE TABLE FastConsig.dbo.Fases (
  Id int IDENTITY,
  Descricao varchar(50) NOT NULL,
  Sistema bit NULL,
  CONSTRAINT PK_Fases_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

SET IDENTITY_INSERT FastConsig.dbo.Fases ON
GO
INSERT FastConsig.dbo.Fases(Id, Descricao, Sistema) VALUES (1, 'PROSPECÇÃO', CONVERT(bit, 'True'))
INSERT FastConsig.dbo.Fases(Id, Descricao, Sistema) VALUES (2, 'CAPTURA', CONVERT(bit, 'True'))
INSERT FastConsig.dbo.Fases(Id, Descricao, Sistema) VALUES (3, 'MESA PROMOTORA', CONVERT(bit, 'True'))
INSERT FastConsig.dbo.Fases(Id, Descricao, Sistema) VALUES (4, 'CONSULTA', CONVERT(bit, 'True'))
INSERT FastConsig.dbo.Fases(Id, Descricao, Sistema) VALUES (5, 'ANÁLISE BACKOFFICE', CONVERT(bit, 'True'))
INSERT FastConsig.dbo.Fases(Id, Descricao, Sistema) VALUES (6, 'ANÁLISE PLD', CONVERT(bit, 'True'))
INSERT FastConsig.dbo.Fases(Id, Descricao, Sistema) VALUES (7, 'ASSINATURA DIGITAL', CONVERT(bit, 'True'))
INSERT FastConsig.dbo.Fases(Id, Descricao, Sistema) VALUES (8, 'AVERBAÇÃO', CONVERT(bit, 'True'))
INSERT FastConsig.dbo.Fases(Id, Descricao, Sistema) VALUES (9, 'INTEGRAÇÃO', CONVERT(bit, 'True'))
INSERT FastConsig.dbo.Fases(Id, Descricao, Sistema) VALUES (10, 'RETORNO CRITICA', CONVERT(bit, 'True'))
GO
SET IDENTITY_INSERT FastConsig.dbo.Fases OFF
GO