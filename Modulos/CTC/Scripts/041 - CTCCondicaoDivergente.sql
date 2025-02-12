CREATE TABLE FastConsig.dbo.CTCCondicaoDivergente (
  Id int IDENTITY,
  Codigo varchar(3) NOT NULL,
  Descricao varchar(50) NOT NULL,
  CONSTRAINT PK_CTCCondicaoDivergente_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

CREATE UNIQUE INDEX IDX_CTCCondicaoDivergente_Codigo
  ON FastConsig.dbo.CTCCondicaoDivergente (Codigo)
  ON [PRIMARY]
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

SET IDENTITY_INSERT FastConsig.dbo.CTCCondicaoDivergente ON
GO
INSERT FastConsig.dbo.CTCCondicaoDivergente(Id, Codigo, Descricao) VALUES (1, '001', 'Tipo de Taxa')
INSERT FastConsig.dbo.CTCCondicaoDivergente(Id, Codigo, Descricao) VALUES (2, '002', 'Prazo da Operação')
INSERT FastConsig.dbo.CTCCondicaoDivergente(Id, Codigo, Descricao) VALUES (3, '003', 'Regime de Amortização')
INSERT FastConsig.dbo.CTCCondicaoDivergente(Id, Codigo, Descricao) VALUES (4, '004', 'Índice de Remuneração')
INSERT FastConsig.dbo.CTCCondicaoDivergente(Id, Codigo, Descricao) VALUES (5, '005', 'Tarifa Mensal Inicial')
GO
SET IDENTITY_INSERT FastConsig.dbo.CTCCondicaoDivergente OFF
GO