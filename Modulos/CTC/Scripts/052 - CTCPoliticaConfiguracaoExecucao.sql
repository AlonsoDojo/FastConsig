CREATE TABLE FastConsig.dbo.CTCPoliticaConfiguracaoExecucao (
  Id int IDENTITY,
  TipoArquivo int NOT NULL,
  TipoPessoa int NOT NULL,
  Fase int NOT NULL,
  Politica int NOT NULL,
  Peso int NOT NULL,
  Entrada bit NULL,
  Saida bit NULL,
  TipoFluxo int NOT NULL,
  CONSTRAINT PK_CTCPoliticaConfiguracaoExecucao_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.CTCPoliticaConfiguracaoExecucao
  ADD CONSTRAINT FK_CTCPoliticaConfiguracaoExecucao_Arquivo FOREIGN KEY (TipoArquivo) REFERENCES dbo.CTCDominioArquivo (Id)
GO

ALTER TABLE FastConsig.dbo.CTCPoliticaConfiguracaoExecucao
  ADD CONSTRAINT FK_CTCPoliticaConfiguracaoExecucao_Fase FOREIGN KEY (Fase) REFERENCES dbo.CTCFases (Id)
GO

ALTER TABLE FastConsig.dbo.CTCPoliticaConfiguracaoExecucao
  ADD CONSTRAINT FK_CTCPoliticaConfiguracaoExecucao_Politica FOREIGN KEY (Politica) REFERENCES dbo.CTCPoliticas (Id)
GO

ALTER TABLE FastConsig.dbo.CTCPoliticaConfiguracaoExecucao
  ADD CONSTRAINT FK_CTCPoliticaConfiguracaoExecucao_TipoFluxo FOREIGN KEY (TipoFluxo) REFERENCES dbo.CTCTipoFluxo (Id)
GO

ALTER TABLE FastConsig.dbo.CTCPoliticaConfiguracaoExecucao
  ADD CONSTRAINT FK_CTCPoliticaConfiguracaoExecucao_TipoPessoa FOREIGN KEY (TipoPessoa) REFERENCES dbo.TipoPessoa (Id)
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

SET IDENTITY_INSERT FastConsig.dbo.CTCPoliticaConfiguracaoExecucao ON
GO
INSERT FastConsig.dbo.CTCPoliticaConfiguracaoExecucao(Id, TipoArquivo, TipoPessoa, Fase, Politica, Peso, Entrada, Saida, TipoFluxo) VALUES (2, 4, 1, 1, 1, 0, CONVERT(bit, 'True'), CONVERT(bit, 'False'), 1)
INSERT FastConsig.dbo.CTCPoliticaConfiguracaoExecucao(Id, TipoArquivo, TipoPessoa, Fase, Politica, Peso, Entrada, Saida, TipoFluxo) VALUES (4, 4, 1, 2, 4, 0, CONVERT(bit, 'True'), CONVERT(bit, 'False'), 1)
INSERT FastConsig.dbo.CTCPoliticaConfiguracaoExecucao(Id, TipoArquivo, TipoPessoa, Fase, Politica, Peso, Entrada, Saida, TipoFluxo) VALUES (5, 4, 1, 2, 2, 99, CONVERT(bit, 'True'), CONVERT(bit, 'False'), 1)
INSERT FastConsig.dbo.CTCPoliticaConfiguracaoExecucao(Id, TipoArquivo, TipoPessoa, Fase, Politica, Peso, Entrada, Saida, TipoFluxo) VALUES (6, 4, 1, 2, 3, 5, CONVERT(bit, 'True'), CONVERT(bit, 'False'), 1)
INSERT FastConsig.dbo.CTCPoliticaConfiguracaoExecucao(Id, TipoArquivo, TipoPessoa, Fase, Politica, Peso, Entrada, Saida, TipoFluxo) VALUES (7, 4, 1, 3, 5, 0, CONVERT(bit, 'True'), CONVERT(bit, 'False'), 3)
INSERT FastConsig.dbo.CTCPoliticaConfiguracaoExecucao(Id, TipoArquivo, TipoPessoa, Fase, Politica, Peso, Entrada, Saida, TipoFluxo) VALUES (8, 4, 1, 3, 6, 99, CONVERT(bit, 'True'), CONVERT(bit, 'False'), 3)
INSERT FastConsig.dbo.CTCPoliticaConfiguracaoExecucao(Id, TipoArquivo, TipoPessoa, Fase, Politica, Peso, Entrada, Saida, TipoFluxo) VALUES (10, 4, 1, 4, 8, 0, CONVERT(bit, 'True'), CONVERT(bit, 'False'), 4)
INSERT FastConsig.dbo.CTCPoliticaConfiguracaoExecucao(Id, TipoArquivo, TipoPessoa, Fase, Politica, Peso, Entrada, Saida, TipoFluxo) VALUES (11, 4, 1, 4, 6, 99, CONVERT(bit, 'True'), CONVERT(bit, 'False'), 4)
INSERT FastConsig.dbo.CTCPoliticaConfiguracaoExecucao(Id, TipoArquivo, TipoPessoa, Fase, Politica, Peso, Entrada, Saida, TipoFluxo) VALUES (12, 4, 1, 5, 10, 10, CONVERT(bit, 'True'), CONVERT(bit, 'False'), 5)
INSERT FastConsig.dbo.CTCPoliticaConfiguracaoExecucao(Id, TipoArquivo, TipoPessoa, Fase, Politica, Peso, Entrada, Saida, TipoFluxo) VALUES (13, 4, 1, 5, 6, 99, CONVERT(bit, 'True'), CONVERT(bit, 'False'), 5)
INSERT FastConsig.dbo.CTCPoliticaConfiguracaoExecucao(Id, TipoArquivo, TipoPessoa, Fase, Politica, Peso, Entrada, Saida, TipoFluxo) VALUES (14, 4, 1, 6, 11, 0, CONVERT(bit, 'True'), CONVERT(bit, 'False'), 6)
INSERT FastConsig.dbo.CTCPoliticaConfiguracaoExecucao(Id, TipoArquivo, TipoPessoa, Fase, Politica, Peso, Entrada, Saida, TipoFluxo) VALUES (15, 4, 1, 6, 6, 99, CONVERT(bit, 'True'), CONVERT(bit, 'False'), 6)
INSERT FastConsig.dbo.CTCPoliticaConfiguracaoExecucao(Id, TipoArquivo, TipoPessoa, Fase, Politica, Peso, Entrada, Saida, TipoFluxo) VALUES (16, 4, 1, 3, 12, 0, CONVERT(bit, 'False'), CONVERT(bit, 'True'), 3)
INSERT FastConsig.dbo.CTCPoliticaConfiguracaoExecucao(Id, TipoArquivo, TipoPessoa, Fase, Politica, Peso, Entrada, Saida, TipoFluxo) VALUES (17, 4, 1, 3, 7, 99, CONVERT(bit, 'False'), CONVERT(bit, 'True'), 3)
INSERT FastConsig.dbo.CTCPoliticaConfiguracaoExecucao(Id, TipoArquivo, TipoPessoa, Fase, Politica, Peso, Entrada, Saida, TipoFluxo) VALUES (18, 4, 1, 5, 9, 99, CONVERT(bit, 'False'), CONVERT(bit, 'True'), 5)
INSERT FastConsig.dbo.CTCPoliticaConfiguracaoExecucao(Id, TipoArquivo, TipoPessoa, Fase, Politica, Peso, Entrada, Saida, TipoFluxo) VALUES (19, 4, 1, 6, 9, 99, CONVERT(bit, 'False'), CONVERT(bit, 'True'), 6)
INSERT FastConsig.dbo.CTCPoliticaConfiguracaoExecucao(Id, TipoArquivo, TipoPessoa, Fase, Politica, Peso, Entrada, Saida, TipoFluxo) VALUES (20, 4, 1, 4, 9, 99, CONVERT(bit, 'False'), CONVERT(bit, 'True'), 4)
GO
SET IDENTITY_INSERT FastConsig.dbo.CTCPoliticaConfiguracaoExecucao OFF
GO