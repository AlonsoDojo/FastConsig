CREATE TABLE FastConsig.dbo.Usuario (
  Id varchar(50) NOT NULL,
  Login varchar(100) NOT NULL,
  Nome varchar(100) NULL,
  Bloqueado bit NULL,
  Habilitado bit NULL,
  Email varchar(250) NULL,
  DataUltimoLogin datetime NULL,
  DataRegistro datetime NULL,
  UsuarioRegistro varchar(100) NULL,
  Departamento int NULL,
  cpfcnpj bigint NULL,
  Promotora int NULL,
  Senha varchar(max) NULL,
  DataUltimaTrocaSenha datetime NULL,
  Celular varchar(15) NULL,
  Dominio int NULL,
  PreferenciaUsuario varchar(max) NULL,
  RedeLojas int NULL,
  Loja int NULL,
  TermoUsuario bit NULL DEFAULT (1),
  CONSTRAINT PK_Usuario PRIMARY KEY CLUSTERED (Id),
  CONSTRAINT KEY_Usuario_Login UNIQUE (Login, Dominio)
)
ON [PRIMARY]
TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.Usuario
  ADD CONSTRAINT FK_Usuario_Departamento FOREIGN KEY (Departamento) REFERENCES dbo.Departamento (id)
GO

ALTER TABLE FastConsig.dbo.Usuario
  ADD CONSTRAINT FK_Usuario_Dominio FOREIGN KEY (Dominio) REFERENCES dbo.Dominio (Id)
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

INSERT FastConsig.dbo.Usuario(Id, Login, Nome, Bloqueado, Habilitado, Email, DataUltimoLogin, DataRegistro, UsuarioRegistro, Departamento, cpfcnpj, Promotora, Senha, DataUltimaTrocaSenha, Celular, Dominio, PreferenciaUsuario, RedeLojas, Loja, TermoUsuario) VALUES (N'1', 'luiz.giro', 'Luiz Carlos Giro', CONVERT(bit, 'False'), CONVERT(bit, 'False'), 'lcgiro@gmail.com', '2024-09-13 23:08:21.957', '2024-09-02 23:29:20.257', NULL, NULL, NULL, NULL, 'fNN0aPC3h5mIrfFvss5BNQ==', NULL, NULL, 1, NULL, NULL, NULL, CONVERT(bit, 'False'))
INSERT FastConsig.dbo.Usuario(Id, Login, Nome, Bloqueado, Habilitado, Email, DataUltimoLogin, DataRegistro, UsuarioRegistro, Departamento, cpfcnpj, Promotora, Senha, DataUltimaTrocaSenha, Celular, Dominio, PreferenciaUsuario, RedeLojas, Loja, TermoUsuario) VALUES (N'2', 'marcelo.sousa', 'Marcelo Sousa', CONVERT(bit, 'False'), CONVERT(bit, 'False'), 'marcelo.sousa.com', '2024-09-13 23:08:21.957', '2024-09-02 23:29:20.257', NULL, NULL, NULL, NULL, 'fNN0aPC3h5mIrfFvss5BNQ==', NULL, NULL, 1, NULL, NULL, NULL, CONVERT(bit, 'False'))
GO
