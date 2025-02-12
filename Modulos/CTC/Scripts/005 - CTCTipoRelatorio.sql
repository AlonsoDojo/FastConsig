CREATE TABLE FastConsig.dbo.CTCTipoRelatorio (
  Id int IDENTITY,
  Codigo varchar(1) NOT NULL,
  Descricao varchar(50) NOT NULL,
  CONSTRAINT PK_CTCTipoRelatoro_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

CREATE UNIQUE INDEX UK_CTCTipoRelatorio_Codigo
  ON FastConsig.dbo.CTCTipoRelatorio (Codigo)
  ON [PRIMARY]
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

SET IDENTITY_INSERT FastConsig.dbo.CTCTipoRelatorio ON
GO
INSERT FastConsig.dbo.CTCTipoRelatorio(Id, Codigo, Descricao) VALUES (1, 'S', 'Sob Demanda')
INSERT FastConsig.dbo.CTCTipoRelatorio(Id, Codigo, Descricao) VALUES (2, 'A', 'Automático')
GO
SET IDENTITY_INSERT FastConsig.dbo.CTCTipoRelatorio OFF
GO