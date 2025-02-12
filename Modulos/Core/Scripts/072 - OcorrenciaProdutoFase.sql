CREATE TABLE FastConsig.dbo.OcorrenciaProdutoFase (
  Id int IDENTITY,
  Ocorrencia int NULL,
  Produto int NULL,
  Fase int NULL,
  Severidade int NULL,
  FaseDestino int NULL,
  Validacoes varchar(max) NULL,
  CONSTRAINT PK_OcorrenciaProdutoFase_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.OcorrenciaProdutoFase
  ADD CONSTRAINT FK_OcorrenciaProdutoFase_Fase FOREIGN KEY (Fase) REFERENCES dbo.Fases (Id)
GO

ALTER TABLE FastConsig.dbo.OcorrenciaProdutoFase
  ADD CONSTRAINT FK_OcorrenciaProdutoFase_FaseDestino FOREIGN KEY (FaseDestino) REFERENCES dbo.Fases (Id)
GO

ALTER TABLE FastConsig.dbo.OcorrenciaProdutoFase
  ADD CONSTRAINT FK_OcorrenciaProdutoFase_Ocorrencia FOREIGN KEY (Ocorrencia) REFERENCES dbo.Ocorrencias (Id)
GO

ALTER TABLE FastConsig.dbo.OcorrenciaProdutoFase
  ADD CONSTRAINT FK_OcorrenciaProdutoFase_Produto FOREIGN KEY (Produto) REFERENCES dbo.Produtos (Id)
GO