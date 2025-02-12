CREATE TABLE FastConsig.dbo.Nacionalidade (
  Id int IDENTITY,
  Descricao varchar(50) NOT NULL,
  CodigoIntegracaoMatera varchar(2) NULL,
  CodigoIntegracaoSicred varchar(2) NULL,
  CodigoIntegracaoBMP varchar(2) NULL,
  CONSTRAINT PK_Nacionalidade_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

SET IDENTITY_INSERT FastConsig.dbo.Nacionalidade ON
GO
INSERT FastConsig.dbo.Nacionalidade(Id, Descricao, CodigoIntegracaoMatera, CodigoIntegracaoSicred, CodigoIntegracaoBMP) VALUES (1, 'Brasileira', 'BR', 'BR', NULL)
INSERT FastConsig.dbo.Nacionalidade(Id, Descricao, CodigoIntegracaoMatera, CodigoIntegracaoSicred, CodigoIntegracaoBMP) VALUES (2, 'Estrangeira', 'ES', 'ES', NULL)
GO
SET IDENTITY_INSERT FastConsig.dbo.Nacionalidade OFF
GO