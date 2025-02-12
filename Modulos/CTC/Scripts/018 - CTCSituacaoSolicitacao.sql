CREATE TABLE FastConsig.dbo.CTCSituacaoSolicitacao (
  Id int IDENTITY,
  Codigo varchar(1) NOT NULL,
  Descricao varchar(50) NOT NULL,
  CONSTRAINT PK_CTCSituacaoSolicitacao_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

CREATE UNIQUE INDEX IDX_CTCSituacaoSolicitacao_Codigo
  ON FastConsig.dbo.CTCSituacaoSolicitacao (Codigo)
  ON [PRIMARY]
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

SET IDENTITY_INSERT FastConsig.dbo.CTCSituacaoSolicitacao ON
GO
INSERT FastConsig.dbo.CTCSituacaoSolicitacao(Id, Codigo, Descricao) VALUES (1, '0', 'Recusada')
INSERT FastConsig.dbo.CTCSituacaoSolicitacao(Id, Codigo, Descricao) VALUES (2, '1', 'Agendada')
GO
SET IDENTITY_INSERT FastConsig.dbo.CTCSituacaoSolicitacao OFF
GO