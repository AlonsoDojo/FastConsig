CREATE TABLE FastConsig.dbo.CTCSituacaoProcessamento (
  Id int IDENTITY,
  Codigo varchar(1) NOT NULL,
  Descricao varchar(50) NOT NULL,
  CONSTRAINT PK_CTCSituacaoProcessamento_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

CREATE UNIQUE INDEX UK_CTCSituacaoProcessamento_Codigo
  ON FastConsig.dbo.CTCSituacaoProcessamento (Codigo)
  ON [PRIMARY]
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

SET IDENTITY_INSERT FastConsig.dbo.CTCSituacaoProcessamento ON
GO
INSERT FastConsig.dbo.CTCSituacaoProcessamento(Id, Codigo, Descricao) VALUES (1, '0', 'Consulta sem dados que atendam ao filtro')
INSERT FastConsig.dbo.CTCSituacaoProcessamento(Id, Codigo, Descricao) VALUES (2, '1', 'Consulta atendida')
GO
SET IDENTITY_INSERT FastConsig.dbo.CTCSituacaoProcessamento OFF
GO