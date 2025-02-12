CREATE TABLE FastConsig.dbo.PoliticaConfiguracaoExecucaoSimulacao (
  Id int IDENTITY,
  Produto int NOT NULL,
  TipoPessoa int NOT NULL,
  Politica int NOT NULL,
  Peso int NOT NULL,
  Entrada bit NULL,
  Saida bit NULL,
  CONSTRAINT PK_PoliticaConfiguracaoExecucaoSimulacao_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.PoliticaConfiguracaoExecucaoSimulacao
  ADD CONSTRAINT FK_PoliticaConfiguracaoExecucaoSimulacao_Politica FOREIGN KEY (Politica) REFERENCES dbo.Politicas (Id)
GO

ALTER TABLE FastConsig.dbo.PoliticaConfiguracaoExecucaoSimulacao
  ADD CONSTRAINT FK_PoliticaConfiguracaoExecucaoSimulacao_Produto FOREIGN KEY (Produto) REFERENCES dbo.Produtos (Id)
GO

ALTER TABLE FastConsig.dbo.PoliticaConfiguracaoExecucaoSimulacao
  ADD CONSTRAINT FK_PoliticaConfiguracaoExecucaoSimulacao_TipoPessoa FOREIGN KEY (TipoPessoa) REFERENCES dbo.TipoPessoa (Id)
GO