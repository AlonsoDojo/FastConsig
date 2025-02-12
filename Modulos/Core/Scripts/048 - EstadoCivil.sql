CREATE TABLE FastConsig.dbo.EstadoCivil (
  Id int IDENTITY,
  Descricao varchar(50) NULL,
  CodigoIntegracaoSicred varchar(1) NULL,
  CodigoIntegracaoMatera int NULL,
  CodigoIntegracaoBMP int NULL,
  CONSTRAINT PK_EstadoCivil PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

SET IDENTITY_INSERT FastConsig.dbo.EstadoCivil ON
GO
INSERT FastConsig.dbo.EstadoCivil(Id, Descricao, CodigoIntegracaoSicred, CodigoIntegracaoMatera, CodigoIntegracaoBMP) VALUES (1, 'Solteiro', 'S', 1, NULL)
INSERT FastConsig.dbo.EstadoCivil(Id, Descricao, CodigoIntegracaoSicred, CodigoIntegracaoMatera, CodigoIntegracaoBMP) VALUES (2, 'Casado', 'C', 2, NULL)
INSERT FastConsig.dbo.EstadoCivil(Id, Descricao, CodigoIntegracaoSicred, CodigoIntegracaoMatera, CodigoIntegracaoBMP) VALUES (3, 'Separado', NULL, NULL, NULL)
INSERT FastConsig.dbo.EstadoCivil(Id, Descricao, CodigoIntegracaoSicred, CodigoIntegracaoMatera, CodigoIntegracaoBMP) VALUES (4, 'Divorciado', 'D', 3, NULL)
INSERT FastConsig.dbo.EstadoCivil(Id, Descricao, CodigoIntegracaoSicred, CodigoIntegracaoMatera, CodigoIntegracaoBMP) VALUES (5, 'Viuvo', 'V', 4, NULL)
INSERT FastConsig.dbo.EstadoCivil(Id, Descricao, CodigoIntegracaoSicred, CodigoIntegracaoMatera, CodigoIntegracaoBMP) VALUES (6, 'Outros', 'O', 8, NULL)
INSERT FastConsig.dbo.EstadoCivil(Id, Descricao, CodigoIntegracaoSicred, CodigoIntegracaoMatera, CodigoIntegracaoBMP) VALUES (7, 'Desquitado', 'D', 5, NULL)
INSERT FastConsig.dbo.EstadoCivil(Id, Descricao, CodigoIntegracaoSicred, CodigoIntegracaoMatera, CodigoIntegracaoBMP) VALUES (8, 'Amasiado', 'A', NULL, NULL)
GO
SET IDENTITY_INSERT FastConsig.dbo.EstadoCivil OFF
GO