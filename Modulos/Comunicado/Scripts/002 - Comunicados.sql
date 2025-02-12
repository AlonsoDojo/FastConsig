CREATE TABLE FastConsig.dbo.Comunicados (
  Id int IDENTITY,
  Usuario varchar(50) NOT NULL,
  DataCriacao datetime NOT NULL,
  DataVigenciaInicial datetime NULL,
  DataVigenciaFinal datetime NULL,
  Status int NULL,
  Titulo varchar(200) NOT NULL,
  ConfirmacaoLeitura bit NULL,
  PaginaPrincipal char(1) NULL,
  Conteudo varchar(max) NOT NULL,
  Publicado bit NULL DEFAULT (0),
  UsuarioAlteracao varchar(50) NULL,
  DataAlteracao datetime NULL,
  DataPublicacao datetime NULL,
  UsuarioPublicador varchar(50) NULL,
  DataDesativacao datetime NULL,
  UsuarioDesativacao varchar(50) NULL,
  CONSTRAINT PK_Comunicados PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.Comunicados
  ADD CONSTRAINT FK_Comunicados_Status FOREIGN KEY (Status) REFERENCES dbo.ComunicadosStatus (Id)
GO

ALTER TABLE FastConsig.dbo.Comunicados
  ADD CONSTRAINT FK_Comunicados_Usuario FOREIGN KEY (Usuario) REFERENCES dbo.Usuario (Id)
GO

ALTER TABLE FastConsig.dbo.Comunicados
  ADD CONSTRAINT FK_Comunicados_UsuarioAlteracao FOREIGN KEY (UsuarioAlteracao) REFERENCES dbo.Usuario (Id)
GO

ALTER TABLE FastConsig.dbo.Comunicados
  ADD CONSTRAINT FK_Comunicados_UsuarioDesativacao FOREIGN KEY (UsuarioDesativacao) REFERENCES dbo.Usuario (Id)
GO

ALTER TABLE FastConsig.dbo.Comunicados
  ADD CONSTRAINT FK_Comunicados_UsuarioPublicador FOREIGN KEY (UsuarioPublicador) REFERENCES dbo.Usuario (Id)
GO