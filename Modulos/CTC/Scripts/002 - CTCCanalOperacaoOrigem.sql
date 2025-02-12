CREATE TABLE FastConsig.dbo.CTCCanalOperacaoOrigem (
  Id int IDENTITY,
  Codigo varchar(2) NULL,
  Descricao varchar(50) NULL,
  CONSTRAINT PK_CTCCanalOperacaoOrigem_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

CREATE UNIQUE INDEX IDX_CTCCanalOperacaoOrigem_Codigo
  ON FastConsig.dbo.CTCCanalOperacaoOrigem (Codigo)
  ON [PRIMARY]
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

SET IDENTITY_INSERT FastConsig.dbo.CTCCanalOperacaoOrigem ON
GO
INSERT FastConsig.dbo.CTCCanalOperacaoOrigem(Id, Codigo, Descricao) VALUES (1, '01', 'Correspondente Bancário')
INSERT FastConsig.dbo.CTCCanalOperacaoOrigem(Id, Codigo, Descricao) VALUES (2, '1', 'Correspondente Bancário')
INSERT FastConsig.dbo.CTCCanalOperacaoOrigem(Id, Codigo, Descricao) VALUES (3, '02', 'Outros')
INSERT FastConsig.dbo.CTCCanalOperacaoOrigem(Id, Codigo, Descricao) VALUES (4, '2', 'Outros')
GO
SET IDENTITY_INSERT FastConsig.dbo.CTCCanalOperacaoOrigem OFF
GO