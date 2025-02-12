CREATE TABLE FastConsig.dbo.CTC926Detalhes (
  Id int IDENTITY,
  CTC926 int NULL,
  DataReferencia date NOT NULL,
  DataProcessamentoArquivo datetime NOT NULL,
  NomeArquivo varchar(50) NOT NULL,
  TipoArquivo varchar(1) NOT NULL,
  ISPBEmissor varchar(8) NOT NULL,
  ISPBDestinatario varchar(8) NOT NULL,
  CONSTRAINT PK_CTC926Detalhes_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.CTC926Detalhes
  ADD CONSTRAINT FK_CTC926Detalhes_CTC926 FOREIGN KEY (CTC926) REFERENCES dbo.CTC926 (Id)
GO

ALTER TABLE FastConsig.dbo.CTC926Detalhes
  ADD CONSTRAINT FK_CTC926Detalhes_TipoArquivo FOREIGN KEY (TipoArquivo) REFERENCES dbo.CTCTipoArquivo (Codigo)
GO