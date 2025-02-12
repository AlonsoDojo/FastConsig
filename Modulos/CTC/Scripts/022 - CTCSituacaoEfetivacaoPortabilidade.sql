CREATE TABLE FastConsig.dbo.CTCSituacaoEfetivacaoPortabilidade (
  Id int IDENTITY,
  Codigo varchar(3) NOT NULL,
  Descricao varchar(50) NOT NULL,
  CONSTRAINT PK_CTCSituacaoEfetivacaoPortabilidade_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

CREATE UNIQUE INDEX IDX_CTCSituacaoEfetivacaoPortabilidade_Codigo
  ON FastConsig.dbo.CTCSituacaoEfetivacaoPortabilidade (Codigo)
  ON [PRIMARY]
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

SET IDENTITY_INSERT FastConsig.dbo.CTCSituacaoEfetivacaoPortabilidade ON
GO
INSERT FastConsig.dbo.CTCSituacaoEfetivacaoPortabilidade(Id, Codigo, Descricao) VALUES (1, '001', 'Comandada pelo credor original (via ACTC902)')
INSERT FastConsig.dbo.CTCSituacaoEfetivacaoPortabilidade(Id, Codigo, Descricao) VALUES (2, '002', 'Comandada pelo CTC (se existir o parâmetro)')
GO
SET IDENTITY_INSERT FastConsig.dbo.CTCSituacaoEfetivacaoPortabilidade OFF
GO