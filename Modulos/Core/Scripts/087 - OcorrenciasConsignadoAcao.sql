CREATE TABLE FastConsig.dbo.OcorrenciasConsignadoAcao (
  Id int IDENTITY,
  Descricao varchar(50) NOT NULL,
  CONSTRAINT PK_OcorrenciasConsignadoAcao_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

SET IDENTITY_INSERT FastConsig.dbo.OcorrenciasConsignadoAcao ON
GO
INSERT FastConsig.dbo.OcorrenciasConsignadoAcao(Id, Descricao) VALUES (1, 'Aprovar')
INSERT FastConsig.dbo.OcorrenciasConsignadoAcao(Id, Descricao) VALUES (2, 'Reprovar')
INSERT FastConsig.dbo.OcorrenciasConsignadoAcao(Id, Descricao) VALUES (3, 'Reenviar')
INSERT FastConsig.dbo.OcorrenciasConsignadoAcao(Id, Descricao) VALUES (4, 'Pendenciar')
GO
SET IDENTITY_INSERT FastConsig.dbo.OcorrenciasConsignadoAcao OFF
GO
