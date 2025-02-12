CREATE TABLE FastConsig.dbo.CTCSituacaoContrato (
  Id int IDENTITY,
  Codigo varchar(3) NOT NULL,
  Descricao varchar(50) NOT NULL,
  CONSTRAINT PK_CTCSituacaoContrato_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

CREATE UNIQUE INDEX UK_CTCSituacaoContrato_Codigo
  ON FastConsig.dbo.CTCSituacaoContrato (Codigo)
  ON [PRIMARY]
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

SET IDENTITY_INSERT FastConsig.dbo.CTCSituacaoContrato ON
GO
INSERT FastConsig.dbo.CTCSituacaoContrato(Id, Codigo, Descricao) VALUES (1, '001', 'Ativo')
INSERT FastConsig.dbo.CTCSituacaoContrato(Id, Codigo, Descricao) VALUES (2, '002', 'Atraso até 59 dias')
INSERT FastConsig.dbo.CTCSituacaoContrato(Id, Codigo, Descricao) VALUES (3, '003', 'Crédito em liquidação')
INSERT FastConsig.dbo.CTCSituacaoContrato(Id, Codigo, Descricao) VALUES (4, '004', 'Atraso acima de 59 dias')
GO
SET IDENTITY_INSERT FastConsig.dbo.CTCSituacaoContrato OFF
GO