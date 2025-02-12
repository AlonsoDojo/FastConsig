CREATE TABLE FastConsig.dbo.Propostas (
  Id int IDENTITY,
  DataCriacao datetime NULL,
  DataUltimaAlteracao datetime NULL,
  Fase int NULL,
  Status int NULL,
  Usuario varchar(50) NULL,
  Observacoes varchar(max) NULL,
  Gerente int NULL,
  MotivoRecusa text NULL,
  Promotora int NULL DEFAULT (1),
  DataAtualizacao datetime NULL,
  UsuarioProposta varchar(50) NULL,
  ProfissionalCertificado bigint NULL,
  Pendente bit NULL,
  TipoFormalizacao int NULL,
  TipoComunicacao int NULL,
  MensagemInterna varchar(max) NULL,
  Retencao bit NULL,
  CONSTRAINT PK_Propostas PRIMARY KEY CLUSTERED (Id) WITH (FILLFACTOR = 80)
)
ON [PRIMARY]
TEXTIMAGE_ON [PRIMARY]
GO

CREATE INDEX IX_Propostas
  ON FastConsig.dbo.Propostas (DataCriacao)
  WITH (FILLFACTOR = 80)
  ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.Propostas
  ADD CONSTRAINT FK_Propostas_Fase FOREIGN KEY (Fase) REFERENCES dbo.Fases (Id)
GO

ALTER TABLE FastConsig.dbo.Propostas
  ADD CONSTRAINT FK_Propostas_Gerente FOREIGN KEY (Gerente) REFERENCES dbo.Gerentes (Id)
GO

ALTER TABLE FastConsig.dbo.Propostas
  ADD CONSTRAINT FK_Propostas_Promotora FOREIGN KEY (Promotora) REFERENCES dbo.Promotoras (Id)
GO

ALTER TABLE FastConsig.dbo.Propostas
  ADD CONSTRAINT FK_Propostas_Status FOREIGN KEY (Status) REFERENCES dbo.Status (Id)
GO

ALTER TABLE FastConsig.dbo.Propostas
  ADD CONSTRAINT FK_Propostas_TipoComunicacao FOREIGN KEY (TipoComunicacao) REFERENCES dbo.TipoComunicacao (Id)
GO

ALTER TABLE FastConsig.dbo.Propostas
  ADD CONSTRAINT FK_Propostas_TipoFormalizacao FOREIGN KEY (TipoFormalizacao) REFERENCES dbo.TipoFormalizacao (Id)
GO

ALTER TABLE FastConsig.dbo.Propostas
  ADD CONSTRAINT FK_Propostas_Usuario FOREIGN KEY (Usuario) REFERENCES dbo.Usuario (Id)
GO

ALTER TABLE FastConsig.dbo.Propostas
  ADD CONSTRAINT FK_Propostas_UsuarioProposta FOREIGN KEY (UsuarioProposta) REFERENCES dbo.Usuario (Id)
GO