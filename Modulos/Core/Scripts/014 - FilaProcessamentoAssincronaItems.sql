CREATE TABLE FastConsig.dbo.FilaProcessamentoAssincronaItems (
  Id int IDENTITY,
  FilaProcessamento int NOT NULL,
  Ordem int NOT NULL,
  Descricao varchar(max) NULL,
  Parametros varchar(max) NULL,
  AguardandoProcessamento bit NULL,
  ComErro bit NULL,
  EmProcessamento bit NULL,
  Finalizado bit NULL,
  DataInicio datetime NULL,
  DataFim datetime NULL,
  Mensagem varchar(max) NULL,
  Notificar bit NULL,
  NotificarParametros varchar(max) NULL,
  Chave bigint NULL,
  CONSTRAINT PK_FilaProcessamentoAssincronaItems_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.FilaProcessamentoAssincronaItems
  ADD CONSTRAINT FK_FilaProcessamentoAssincronaItems_FilaProcessamento FOREIGN KEY (FilaProcessamento) REFERENCES dbo.FilaProcessamentoAssincrona (Id)
GO
