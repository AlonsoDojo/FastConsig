CREATE TABLE FastConsig.dbo.CTCSituacaoLiquidacaoPortabilidade (
  Id int IDENTITY,
  Codigo varchar(3) NOT NULL,
  Descricao varchar(100) NOT NULL,
  CONSTRAINT PK_CTCSituacaoLiquidacaoPortabilidade_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

CREATE UNIQUE INDEX IDX_CTCSituacaoLiquidacaoPortabilidade_Codigo
  ON FastConsig.dbo.CTCSituacaoLiquidacaoPortabilidade (Codigo)
  ON [PRIMARY]
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

SET IDENTITY_INSERT FastConsig.dbo.CTCSituacaoLiquidacaoPortabilidade ON
GO
INSERT FastConsig.dbo.CTCSituacaoLiquidacaoPortabilidade(Id, Codigo, Descricao) VALUES (1, '001', 'Liquidada')
INSERT FastConsig.dbo.CTCSituacaoLiquidacaoPortabilidade(Id, Codigo, Descricao) VALUES (2, '002', 'Devolvida')
INSERT FastConsig.dbo.CTCSituacaoLiquidacaoPortabilidade(Id, Codigo, Descricao) VALUES (3, '003', 'Paga com valor divergente a menor')
INSERT FastConsig.dbo.CTCSituacaoLiquidacaoPortabilidade(Id, Codigo, Descricao) VALUES (4, '004', 'Paga com valor divergente a maior')
INSERT FastConsig.dbo.CTCSituacaoLiquidacaoPortabilidade(Id, Codigo, Descricao) VALUES (5, '005', 'Devolvida com valor a menor')
INSERT FastConsig.dbo.CTCSituacaoLiquidacaoPortabilidade(Id, Codigo, Descricao) VALUES (6, '006', 'Devolvida com valor a maior')
INSERT FastConsig.dbo.CTCSituacaoLiquidacaoPortabilidade(Id, Codigo, Descricao) VALUES (7, '007', 'Liquidada com data divergente')
INSERT FastConsig.dbo.CTCSituacaoLiquidacaoPortabilidade(Id, Codigo, Descricao) VALUES (8, '008', 'Paga com valor divergente a menor e data divergente')
INSERT FastConsig.dbo.CTCSituacaoLiquidacaoPortabilidade(Id, Codigo, Descricao) VALUES (9, '009', 'Paga com valor divergente a maior e data divergente')
GO
SET IDENTITY_INSERT FastConsig.dbo.CTCSituacaoLiquidacaoPortabilidade OFF
GO