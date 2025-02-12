CREATE TABLE FastConsig.dbo.CTCArquivos (
  Id int IDENTITY,
  NomeArquivo varchar(150) NOT NULL,
  ISPBEmissor varchar(8) NOT NULL,
  ISPBDestinatario varchar(8) NOT NULL,
  DataReferencia datetime NOT NULL,
  SituacaoArquivo int NOT NULL,
  Conteudo varchar(max) NULL,
  DominioArquivo int NULL,
  Status varchar(50) NOT NULL,
  DataHoraArquivo datetime NULL,
  FluxoArquivo varchar(1) NOT NULL,
  Mensagem varchar(max) NULL,
  DataEntrada datetime NOT NULL DEFAULT (getdate()),
  NumeroControleEmissor varchar(20) NULL,
  NumeroControleDestinatario varchar(20) NULL,
  Identificador int NULL,
  CodigoErro varchar(8) NULL,
  CONSTRAINT PK_CTCArquivos_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.CTCArquivos
  ADD CONSTRAINT FK_CTCArquivos_DominioArquivo FOREIGN KEY (DominioArquivo) REFERENCES dbo.CTCDominioArquivo (Id)
GO

ALTER TABLE FastConsig.dbo.CTCArquivos
  ADD CONSTRAINT FK_CTCArquivos_SituacaoArquivo FOREIGN KEY (SituacaoArquivo) REFERENCES dbo.CTCSituacaoArquivo (Id)
GO