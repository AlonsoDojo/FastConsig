CREATE TABLE FastConsig.dbo.GrupoFuncionalidade (
  Id int IDENTITY,
  Nome varchar(50) NOT NULL,
  Icone varchar(50) NULL,
  Habilitado bit NULL,
  Ordem int NOT NULL DEFAULT (0),
  CONSTRAINT PK_GrupoFuncionalidade PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

SET IDENTITY_INSERT FastConsig.dbo.GrupoFuncionalidade ON
GO
INSERT FastConsig.dbo.GrupoFuncionalidade(Id, Nome, Icone, Habilitado, Ordem) VALUES (1, 'Crédito', 'uil-usd-square', CONVERT(bit, 'True'), 1)
INSERT FastConsig.dbo.GrupoFuncionalidade(Id, Nome, Icone, Habilitado, Ordem) VALUES (2, 'Comunicados', 'uil-bell', CONVERT(bit, 'True'), 10)
INSERT FastConsig.dbo.GrupoFuncionalidade(Id, Nome, Icone, Habilitado, Ordem) VALUES (3, 'Configurações', 'uil-cog', CONVERT(bit, 'True'), 15)
INSERT FastConsig.dbo.GrupoFuncionalidade(Id, Nome, Icone, Habilitado, Ordem) VALUES (4, 'Portabilidade', 'uil-share-alt', CONVERT(bit, 'True'), 5)
INSERT FastConsig.dbo.GrupoFuncionalidade(Id, Nome, Icone, Habilitado, Ordem) VALUES (5, 'Relatórios', 'uil-print-slash', CONVERT(bit, 'True'), 20)
INSERT FastConsig.dbo.GrupoFuncionalidade(Id, Nome, Icone, Habilitado, Ordem) VALUES (6, 'Segurança', 'uil-lock-access', CONVERT(bit, 'True'), 25)
INSERT FastConsig.dbo.GrupoFuncionalidade(Id, Nome, Icone, Habilitado, Ordem) VALUES (7, 'Dashboards', 'uil-graph', CONVERT(bit, 'True'), 30)
GO
SET IDENTITY_INSERT FastConsig.dbo.GrupoFuncionalidade OFF
GO
