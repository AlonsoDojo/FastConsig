CREATE TABLE FastConsig.dbo.PerfilEventoFuncionalidade (
  Id int IDENTITY,
  Habilitado bit NOT NULL,
  IdPerfil int NOT NULL,
  IdEventoFuncionalidade int NOT NULL,
  CONSTRAINT PK_PerfilEventoFuncionalidade PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.PerfilEventoFuncionalidade
  ADD CONSTRAINT FK_PerfilEventoFuncionalidade_EventoFuncionalidade1 FOREIGN KEY (IdEventoFuncionalidade) REFERENCES dbo.EventoFuncionalidade (Id) ON DELETE CASCADE
GO

ALTER TABLE FastConsig.dbo.PerfilEventoFuncionalidade
  ADD CONSTRAINT FK_PerfilEventoFuncionalidade_Perfil FOREIGN KEY (IdPerfil) REFERENCES dbo.Perfil (Id) ON DELETE CASCADE
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

SET IDENTITY_INSERT FastConsig.dbo.PerfilEventoFuncionalidade ON
GO
INSERT FastConsig.dbo.PerfilEventoFuncionalidade(Id, Habilitado, IdPerfil, IdEventoFuncionalidade) VALUES (1, CONVERT(bit, 'False'), 1, 1)
INSERT FastConsig.dbo.PerfilEventoFuncionalidade(Id, Habilitado, IdPerfil, IdEventoFuncionalidade) VALUES (2, CONVERT(bit, 'False'), 1, 2)
INSERT FastConsig.dbo.PerfilEventoFuncionalidade(Id, Habilitado, IdPerfil, IdEventoFuncionalidade) VALUES (3, CONVERT(bit, 'False'), 1, 3)
INSERT FastConsig.dbo.PerfilEventoFuncionalidade(Id, Habilitado, IdPerfil, IdEventoFuncionalidade) VALUES (4, CONVERT(bit, 'False'), 1, 4)
INSERT FastConsig.dbo.PerfilEventoFuncionalidade(Id, Habilitado, IdPerfil, IdEventoFuncionalidade) VALUES (5, CONVERT(bit, 'False'), 1, 5)
INSERT FastConsig.dbo.PerfilEventoFuncionalidade(Id, Habilitado, IdPerfil, IdEventoFuncionalidade) VALUES (6, CONVERT(bit, 'False'), 1, 6)
INSERT FastConsig.dbo.PerfilEventoFuncionalidade(Id, Habilitado, IdPerfil, IdEventoFuncionalidade) VALUES (7, CONVERT(bit, 'False'), 1, 7)
INSERT FastConsig.dbo.PerfilEventoFuncionalidade(Id, Habilitado, IdPerfil, IdEventoFuncionalidade) VALUES (8, CONVERT(bit, 'False'), 1, 8)
INSERT FastConsig.dbo.PerfilEventoFuncionalidade(Id, Habilitado, IdPerfil, IdEventoFuncionalidade) VALUES (9, CONVERT(bit, 'False'), 1, 9)
INSERT FastConsig.dbo.PerfilEventoFuncionalidade(Id, Habilitado, IdPerfil, IdEventoFuncionalidade) VALUES (10, CONVERT(bit, 'False'), 1, 10)
INSERT FastConsig.dbo.PerfilEventoFuncionalidade(Id, Habilitado, IdPerfil, IdEventoFuncionalidade) VALUES (11, CONVERT(bit, 'False'), 1, 11)
INSERT FastConsig.dbo.PerfilEventoFuncionalidade(Id, Habilitado, IdPerfil, IdEventoFuncionalidade) VALUES (12, CONVERT(bit, 'False'), 1, 12)
INSERT FastConsig.dbo.PerfilEventoFuncionalidade(Id, Habilitado, IdPerfil, IdEventoFuncionalidade) VALUES (13, CONVERT(bit, 'False'), 1, 13)
GO
SET IDENTITY_INSERT FastConsig.dbo.PerfilEventoFuncionalidade OFF
GO