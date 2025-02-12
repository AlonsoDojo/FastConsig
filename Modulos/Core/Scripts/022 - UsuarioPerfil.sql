CREATE TABLE FastConsig.dbo.UsuarioPerfil (
  Id int IDENTITY,
  IdUsuario varchar(50) NULL,
  IdPerfil int NULL,
  CONSTRAINT PK_UsuarioPerfil PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

CREATE INDEX IDX_UsuarioPerfil_09022023_01
  ON FastConsig.dbo.UsuarioPerfil (IdPerfil)
  INCLUDE (IdUsuario)
  WITH (FILLFACTOR = 80)
  ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.UsuarioPerfil
  ADD CONSTRAINT FK_UsuarioPerfil_Perfil FOREIGN KEY (IdPerfil) REFERENCES dbo.Perfil (Id)
GO

ALTER TABLE FastConsig.dbo.UsuarioPerfil
  ADD CONSTRAINT FK_UsuarioPerfil_Usuario FOREIGN KEY (IdUsuario) REFERENCES dbo.Usuario (Id)
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

SET IDENTITY_INSERT FastConsig.dbo.UsuarioPerfil ON
GO
INSERT FastConsig.dbo.UsuarioPerfil(Id, IdUsuario, IdPerfil) VALUES (1, '1', 1)
INSERT FastConsig.dbo.UsuarioPerfil(Id, IdUsuario, IdPerfil) VALUES (2, '2', 1)
GO
SET IDENTITY_INSERT FastConsig.dbo.UsuarioPerfil OFF
GO