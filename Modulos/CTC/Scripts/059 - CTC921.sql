CREATE TABLE FastConsig.dbo.CTC921 (
  Id int IDENTITY,
  DataReferenciaArquivo date NOT NULL,
  TipoRelatorio varchar(1) NOT NULL,
  MesAno varchar(6) NULL,
  DataInicio date NULL,
  DataFim date NULL,
  SituacaoProcessamento varchar(1) NULL,
  Arquivo int NULL,
  CONSTRAINT PK_CTC921_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.CTC921
  ADD CONSTRAINT FK_CTC921_Arquivo FOREIGN KEY (Arquivo) REFERENCES dbo.CTCArquivos (Id)
GO

ALTER TABLE FastConsig.dbo.CTC921
  ADD CONSTRAINT FK_CTC921_SituacaoProcessamento FOREIGN KEY (SituacaoProcessamento) REFERENCES dbo.CTCSituacaoProcessamento (Codigo)
GO

ALTER TABLE FastConsig.dbo.CTC921
  ADD CONSTRAINT FK_CTC921_TipoRelatorio FOREIGN KEY (TipoRelatorio) REFERENCES dbo.CTCTipoRelatorio (Codigo)
GO