CREATE TABLE FastConsig.dbo.CTCTipoRequisicaoSimulacao (
  Id int IDENTITY,
  Descricao varchar(50) NOT NULL,
  CONSTRAINT PK_CTCTipoRequisicaoSimulacao_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

SET IDENTITY_INSERT FastConsig.dbo.CTCTipoRequisicaoSimulacao ON
GO
INSERT FastConsig.dbo.CTCTipoRequisicaoSimulacao(Id, Descricao) VALUES (1, 'Originador')
INSERT FastConsig.dbo.CTCTipoRequisicaoSimulacao(Id, Descricao) VALUES (2, 'Proponente')
INSERT FastConsig.dbo.CTCTipoRequisicaoSimulacao(Id, Descricao) VALUES (3, 'Proposta')
GO
SET IDENTITY_INSERT FastConsig.dbo.CTCTipoRequisicaoSimulacao OFF
GO