CREATE TABLE FastConsig.dbo.FilaProcessamentoAssincrona (
  Id int IDENTITY,
  Descricao varchar(max) NOT NULL,
  AguardandoProcessamento bit NULL,
  Processando bit NULL,
  Finalizado bit NULL,
  ComErro bit NULL,
  MaximoTentativas int NULL,
  TentativasUtilizadas int NULL,
  DataInicioAgendada datetime NULL,
  DataInicio datetime NULL,
  DataFinalizacao datetime NULL,
  DataUltimoErro datetime NULL,
  Chave bigint NULL,
  Sistema varchar(50) NULL,
  Notificar bit NULL,
  NotificarParametros varchar(max) NULL,
  Fila int NOT NULL DEFAULT (1),
  CONSTRAINT PK_FilaProcessamentoAssincrona_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
TEXTIMAGE_ON [PRIMARY]
GO

CREATE INDEX IDX_FilaProcessamentoAssincrona_Chave
  ON FastConsig.dbo.FilaProcessamentoAssincrona (Chave)
  ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.FilaProcessamentoAssincrona
  ADD CONSTRAINT FK_FilaProcessamentoAssincrona_Fila FOREIGN KEY (Fila) REFERENCES dbo.Fila (Id)
GO