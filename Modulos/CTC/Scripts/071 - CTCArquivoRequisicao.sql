CREATE TABLE FastConsig.dbo.CTCArquivoRequisicao (
  Id int IDENTITY,
  Requisicao int NOT NULL,
  Arquivo int NOT NULL,
  CONSTRAINT PK_CTCArquivoRequisicao_Id PRIMARY KEY CLUSTERED (Id),
  CONSTRAINT KEY_CTCArquivoRequisicao UNIQUE (Requisicao, Arquivo)
)
ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.CTCArquivoRequisicao
  ADD CONSTRAINT FK_CTCArquivoRequisicao_Arquivo FOREIGN KEY (Arquivo) REFERENCES dbo.CTCArquivos (Id)
GO

ALTER TABLE FastConsig.dbo.CTCArquivoRequisicao
  ADD CONSTRAINT FK_CTCArquivoRequisicao_Requisicao FOREIGN KEY (Requisicao) REFERENCES dbo.CTCRequisicao (Id)
GO