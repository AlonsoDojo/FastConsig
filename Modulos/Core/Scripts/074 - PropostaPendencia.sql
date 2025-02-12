CREATE TABLE FastConsig.dbo.PropostaPendencia (
  Id int IDENTITY,
  Proposta int NOT NULL,
  DataHora datetime NOT NULL,
  FaseAtual int NOT NULL,
  StatusAtual int NOT NULL,
  FaseDestino int NOT NULL,
  Concluido bit NULL,
  Analista varchar(100) NULL,
  Validacoes varchar(max) NULL,
  CONSTRAINT PK_PropostaPendencia_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.PropostaPendencia
  ADD CONSTRAINT FK_PropostaPendencia_FaseAtual FOREIGN KEY (FaseAtual) REFERENCES dbo.Fases (Id)
GO

ALTER TABLE FastConsig.dbo.PropostaPendencia
  ADD CONSTRAINT FK_PropostaPendencia_FaseDestino FOREIGN KEY (FaseDestino) REFERENCES dbo.Fases (Id)
GO

ALTER TABLE FastConsig.dbo.PropostaPendencia
  ADD CONSTRAINT FK_PropostaPendencia_Proposta FOREIGN KEY (Proposta) REFERENCES dbo.Propostas (Id)
GO