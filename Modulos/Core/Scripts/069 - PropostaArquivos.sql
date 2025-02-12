CREATE TABLE FastConsig.dbo.PropostaArquivos (
  Id int IDENTITY,
  Proposta int NOT NULL,
  NomeArquivo varchar(max) NOT NULL,
  ChaveArquivo varchar(max) NOT NULL,
  TipoDocumento int NULL,
  Pessoa int NULL,
  Conteudo varbinary(max) NULL,
  CONSTRAINT PK_PropostaArquivos_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.PropostaArquivos
  ADD CONSTRAINT FK_PropostaArquivos_Pessoa FOREIGN KEY (Pessoa) REFERENCES dbo.Pessoas (Id)
GO

ALTER TABLE FastConsig.dbo.PropostaArquivos
  ADD CONSTRAINT FK_PropostaArquivos_Proposta FOREIGN KEY (Proposta) REFERENCES dbo.Propostas (Id)
GO

ALTER TABLE FastConsig.dbo.PropostaArquivos
  ADD CONSTRAINT FK_PropostaArquivos_TipoDocumento FOREIGN KEY (TipoDocumento) REFERENCES dbo.TipoDocumento (Id)
GO