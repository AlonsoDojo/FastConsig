CREATE TABLE FastConsig.dbo.FamiliaProduto (
  Id int IDENTITY,
  Descricao varchar(50) NOT NULL,
  CONSTRAINT PK_FamiliaProduto_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

SET IDENTITY_INSERT FastConsig.dbo.FamiliaProduto ON
GO
INSERT FastConsig.dbo.FamiliaProduto(Id, Descricao) VALUES (1, 'Consignado - INSS')
INSERT FastConsig.dbo.FamiliaProduto(Id, Descricao) VALUES (2, 'Consignado - SIAPE')
INSERT FastConsig.dbo.FamiliaProduto(Id, Descricao) VALUES (3, 'Retenção - INSS')
INSERT FastConsig.dbo.FamiliaProduto(Id, Descricao) VALUES (4, 'Retenção - SIAPE')
GO
SET IDENTITY_INSERT FastConsig.dbo.FamiliaProduto OFF
GO