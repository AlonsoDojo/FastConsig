CREATE TABLE FastConsig.dbo.PerfilFuncionalidade (
  Id int IDENTITY,
  IdPerfil int NULL,
  IdFuncionalidade int NULL,
  CONSTRAINT PK_PerfilFuncionalidade PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.PerfilFuncionalidade
  ADD CONSTRAINT FK_PerfilFuncionalidade_Funcionalidade FOREIGN KEY (IdFuncionalidade) REFERENCES dbo.Funcionalidade (Id)
GO

ALTER TABLE FastConsig.dbo.PerfilFuncionalidade
  ADD CONSTRAINT FK_PerfilFuncionalidade_Perfil FOREIGN KEY (IdPerfil) REFERENCES dbo.Perfil (Id)
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

SET IDENTITY_INSERT FastConsig.dbo.PerfilFuncionalidade ON
GO
INSERT FastConsig.dbo.PerfilFuncionalidade(Id, IdPerfil, IdFuncionalidade) VALUES (1, 1, 1)
INSERT FastConsig.dbo.PerfilFuncionalidade(Id, IdPerfil, IdFuncionalidade) VALUES (2, 1, 2)
INSERT FastConsig.dbo.PerfilFuncionalidade(Id, IdPerfil, IdFuncionalidade) VALUES (3, 1, 3)
INSERT FastConsig.dbo.PerfilFuncionalidade(Id, IdPerfil, IdFuncionalidade) VALUES (4, 1, 4)
INSERT FastConsig.dbo.PerfilFuncionalidade(Id, IdPerfil, IdFuncionalidade) VALUES (5, 1, 5)
INSERT FastConsig.dbo.PerfilFuncionalidade(Id, IdPerfil, IdFuncionalidade) VALUES (6, 1, 6)
INSERT FastConsig.dbo.PerfilFuncionalidade(Id, IdPerfil, IdFuncionalidade) VALUES (7, 1, 7)
INSERT FastConsig.dbo.PerfilFuncionalidade(Id, IdPerfil, IdFuncionalidade) VALUES (10, 1, 8)
INSERT FastConsig.dbo.PerfilFuncionalidade(Id, IdPerfil, IdFuncionalidade) VALUES (11, 1, 9)
INSERT FastConsig.dbo.PerfilFuncionalidade(Id, IdPerfil, IdFuncionalidade) VALUES (12, 1, 10)
INSERT FastConsig.dbo.PerfilFuncionalidade(Id, IdPerfil, IdFuncionalidade) VALUES (13, 1, 11)
INSERT FastConsig.dbo.PerfilFuncionalidade(Id, IdPerfil, IdFuncionalidade) VALUES (14, 1, 12)
INSERT FastConsig.dbo.PerfilFuncionalidade(Id, IdPerfil, IdFuncionalidade) VALUES (15, 1, 13)
INSERT FastConsig.dbo.PerfilFuncionalidade(Id, IdPerfil, IdFuncionalidade) VALUES (16, 1, 14)
INSERT FastConsig.dbo.PerfilFuncionalidade(Id, IdPerfil, IdFuncionalidade) VALUES (17, 1, 15)
INSERT FastConsig.dbo.PerfilFuncionalidade(Id, IdPerfil, IdFuncionalidade) VALUES (18, 1, 16)
INSERT FastConsig.dbo.PerfilFuncionalidade(Id, IdPerfil, IdFuncionalidade) VALUES (19, 1, 17)
INSERT FastConsig.dbo.PerfilFuncionalidade(Id, IdPerfil, IdFuncionalidade) VALUES (20, 1, 18)
INSERT FastConsig.dbo.PerfilFuncionalidade(Id, IdPerfil, IdFuncionalidade) VALUES (21, 1, 19)
INSERT FastConsig.dbo.PerfilFuncionalidade(Id, IdPerfil, IdFuncionalidade) VALUES (22, 1, 20)
INSERT FastConsig.dbo.PerfilFuncionalidade(Id, IdPerfil, IdFuncionalidade) VALUES (23, 1, 21)
INSERT FastConsig.dbo.PerfilFuncionalidade(Id, IdPerfil, IdFuncionalidade) VALUES (24, 1, 22)
INSERT FastConsig.dbo.PerfilFuncionalidade(Id, IdPerfil, IdFuncionalidade) VALUES (25, 1, 23)
INSERT FastConsig.dbo.PerfilFuncionalidade(Id, IdPerfil, IdFuncionalidade) VALUES (26, 1, 24)
INSERT FastConsig.dbo.PerfilFuncionalidade(Id, IdPerfil, IdFuncionalidade) VALUES (27, 1, 25)
INSERT FastConsig.dbo.PerfilFuncionalidade(Id, IdPerfil, IdFuncionalidade) VALUES (28, 1, 26)
INSERT FastConsig.dbo.PerfilFuncionalidade(Id, IdPerfil, IdFuncionalidade) VALUES (29, 1, 27)
INSERT FastConsig.dbo.PerfilFuncionalidade(Id, IdPerfil, IdFuncionalidade) VALUES (30, 1, 28)
INSERT FastConsig.dbo.PerfilFuncionalidade(Id, IdPerfil, IdFuncionalidade) VALUES (31, 1, 29)
INSERT FastConsig.dbo.PerfilFuncionalidade(Id, IdPerfil, IdFuncionalidade) VALUES (32, 1, 30)
INSERT FastConsig.dbo.PerfilFuncionalidade(Id, IdPerfil, IdFuncionalidade) VALUES (33, 1, 31)
INSERT FastConsig.dbo.PerfilFuncionalidade(Id, IdPerfil, IdFuncionalidade) VALUES (34, 1, 32)
INSERT FastConsig.dbo.PerfilFuncionalidade(Id, IdPerfil, IdFuncionalidade) VALUES (35, 1, 33)
INSERT FastConsig.dbo.PerfilFuncionalidade(Id, IdPerfil, IdFuncionalidade) VALUES (36, 1, 34)
INSERT FastConsig.dbo.PerfilFuncionalidade(Id, IdPerfil, IdFuncionalidade) VALUES (37, 1, 35)
INSERT FastConsig.dbo.PerfilFuncionalidade(Id, IdPerfil, IdFuncionalidade) VALUES (38, 1, 36)
GO
SET IDENTITY_INSERT FastConsig.dbo.PerfilFuncionalidade OFF
GO