CREATE TABLE FastConsig.dbo.CTCRequisicaoHistorico (
  Id int IDENTITY,
  Requisicao int NOT NULL,
  Ocorrencia int NOT NULL,
  DataOcorrencia datetime NOT NULL,
  Usuario varchar(50) NOT NULL,
  Complemento varchar(max) NULL,
  CONSTRAINT PK_CTCRequisicaoHistorico_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.CTCRequisicaoHistorico
  ADD CONSTRAINT FK_CTCRequisicaoHistorico_Ocorrencia FOREIGN KEY (Ocorrencia) REFERENCES dbo.CTCOcorrencia (Id)
GO

ALTER TABLE FastConsig.dbo.CTCRequisicaoHistorico
  ADD CONSTRAINT FK_CTCRequisicaoHistorico_Requisicao FOREIGN KEY (Requisicao) REFERENCES dbo.CTCRequisicao (Id)
GO