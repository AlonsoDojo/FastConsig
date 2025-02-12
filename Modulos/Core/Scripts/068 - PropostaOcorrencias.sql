CREATE TABLE FastConsig.dbo.PropostaOcorrencias (
  Proposta int NOT NULL,
  Ocorrencia int NOT NULL,
  DataOcorrencia datetime NOT NULL,
  Restritiva varchar(1) NULL,
  Complemento varchar(max) NULL,
  Id int IDENTITY,
  Liberada bit NULL,
  UsuarioLiberador varchar(50) NULL,
  Motivo varchar(max) NULL,
  DataHoraLiberacao datetime NULL,
  Severidade int NULL,
  Fase int NULL,
  Usuario varchar(50) NULL,
  Pessoa int NULL,
  CONSTRAINT PropostaOcorrencias_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
TEXTIMAGE_ON [PRIMARY]
GO

CREATE INDEX IDX_PropostaOcorrencias
  ON FastConsig.dbo.PropostaOcorrencias (Proposta, Restritiva, Liberada)
  ON [PRIMARY]
GO

CREATE INDEX PropostaOcorrencias_IDX
  ON FastConsig.dbo.PropostaOcorrencias (Proposta)
  WITH (FILLFACTOR = 80)
  ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.PropostaOcorrencias
  ADD CONSTRAINT FK_PropostaOcorrencias_Fase FOREIGN KEY (Fase) REFERENCES dbo.Fases (Id)
GO

ALTER TABLE FastConsig.dbo.PropostaOcorrencias
  ADD CONSTRAINT FK_PropostaOcorrencias_Ocorrencia FOREIGN KEY (Ocorrencia) REFERENCES dbo.Ocorrencias (Id)
GO

ALTER TABLE FastConsig.dbo.PropostaOcorrencias
  ADD CONSTRAINT FK_PropostaOcorrencias_Pessoa FOREIGN KEY (Pessoa) REFERENCES dbo.Pessoas (Id)
GO

ALTER TABLE FastConsig.dbo.PropostaOcorrencias
  ADD CONSTRAINT FK_PropostaOcorrencias_Proposta FOREIGN KEY (Proposta) REFERENCES dbo.Propostas (Id)
GO

ALTER TABLE FastConsig.dbo.PropostaOcorrencias
  ADD CONSTRAINT FK_PropostaOcorrencias_Usuario FOREIGN KEY (Usuario) REFERENCES dbo.Usuario (Id)
GO

ALTER TABLE FastConsig.dbo.PropostaOcorrencias
  ADD CONSTRAINT FK_PropostaOcorrencias_UsuarioLiberador FOREIGN KEY (UsuarioLiberador) REFERENCES dbo.Usuario (Id)
GO