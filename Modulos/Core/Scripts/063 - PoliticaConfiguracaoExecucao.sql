CREATE TABLE FastConsig.dbo.PoliticaConfiguracaoExecucao (
  Id int IDENTITY,
  Produto int NOT NULL,
  TipoPessoa int NOT NULL,
  Fase int NOT NULL,
  Politica int NOT NULL,
  Peso int NOT NULL,
  Entrada bit NULL,
  Saida bit NULL,
  CONSTRAINT PK_PoliticaConfiguracaoExecucao_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.PoliticaConfiguracaoExecucao
  ADD CONSTRAINT FK_PoliticaConfiguracaoExecucao_Fase FOREIGN KEY (Fase) REFERENCES dbo.Fases (Id)
GO

ALTER TABLE FastConsig.dbo.PoliticaConfiguracaoExecucao
  ADD CONSTRAINT FK_PoliticaConfiguracaoExecucao_Politica FOREIGN KEY (Politica) REFERENCES dbo.Politicas (Id)
GO

ALTER TABLE FastConsig.dbo.PoliticaConfiguracaoExecucao
  ADD CONSTRAINT FK_PoliticaConfiguracaoExecucao_Produto FOREIGN KEY (Produto) REFERENCES dbo.Produtos (Id)
GO

ALTER TABLE FastConsig.dbo.PoliticaConfiguracaoExecucao
  ADD CONSTRAINT FK_PoliticaConfiguracaoExecucao_TipoPessoa FOREIGN KEY (TipoPessoa) REFERENCES dbo.TipoPessoa (Id)
GO