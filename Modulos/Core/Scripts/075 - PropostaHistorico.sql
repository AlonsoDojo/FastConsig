CREATE TABLE FastConsig.dbo.PropostaHistorico (
  Id int IDENTITY,
  Proposta int NULL,
  Fase int NOT NULL,
  DataExecucao datetime NOT NULL,
  Usuario varchar(100) NULL,
  Simulacao int NULL,
  Acao varchar(max) NULL,
  CONSTRAINT PK_PropostaHistorico PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
TEXTIMAGE_ON [PRIMARY]
GO

CREATE INDEX IDX_PropostaHistorico
  ON FastConsig.dbo.PropostaHistorico (Proposta, Fase)
  WITH (FILLFACTOR = 80)
  ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.PropostaHistorico
  ADD CONSTRAINT FK_PropostaHistorico_Simulacao FOREIGN KEY (Simulacao) REFERENCES dbo.SimulacaoProposta (Id)
GO

ALTER TABLE FastConsig.dbo.PropostaHistorico
  ADD CONSTRAINT FK_PropostaHistorico_Propostas FOREIGN KEY (Proposta) REFERENCES dbo.PropostaHistorico (Id)
GO