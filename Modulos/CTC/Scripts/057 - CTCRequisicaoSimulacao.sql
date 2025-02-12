CREATE TABLE FastConsig.dbo.CTCRequisicaoSimulacao (
  Id int IDENTITY,
  Requisicao int NOT NULL,
  Simulacao int NOT NULL,
  DataReferencia date NULL,
  SaldoDevedor decimal(18, 2) NULL,
  Taxa decimal(18, 6) NULL,
  CET decimal(18, 6) NULL,
  Parcelas int NULL,
  ValorParcela decimal(18, 2) NULL,
  PrimeiroVencimento date NULL,
  UltimoVencimento date NULL,
  Tipo int NOT NULL,
  Tabela varchar(4) NULL,
  CONSTRAINT PK_CTCRequisicaoSimulacao_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.CTCRequisicaoSimulacao
  ADD CONSTRAINT FK_CTCRequisicaoSimulacao_Requisicao FOREIGN KEY (Requisicao) REFERENCES dbo.CTCRequisicao (Id)
GO

ALTER TABLE FastConsig.dbo.CTCRequisicaoSimulacao
  ADD CONSTRAINT FK_CTCRequisicaoSimulacao_Tipo FOREIGN KEY (Tipo) REFERENCES dbo.CTCTipoRequisicaoSimulacao (Id)
GO