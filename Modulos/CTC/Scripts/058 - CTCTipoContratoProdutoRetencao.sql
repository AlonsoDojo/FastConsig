CREATE TABLE FastConsig.dbo.CTCTipoContratoProdutoRetencao (
  Id int IDENTITY,
  TipoContrato varchar(4) NOT NULL,
  EnteConsignante varchar(2) NULL,
  ProdutoOrigem varchar(6) NOT NULL,
  ProdutoRetencao int NULL,
  ContaPagamento int NULL,
  CONSTRAINT PK_CTCTipoContratoProdutoRetencao_Id PRIMARY KEY CLUSTERED (Id),
  CONSTRAINT KEY_CTCTipoContratoProdutoRetencao UNIQUE (TipoContrato, EnteConsignante, ProdutoOrigem, ProdutoRetencao)
)
ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.CTCTipoContratoProdutoRetencao
  ADD CONSTRAINT FK_CTCTipoContratoProdutoRetencao_ContaPagamento FOREIGN KEY (ContaPagamento) REFERENCES dbo.CTCContas (Id)
GO

ALTER TABLE FastConsig.dbo.CTCTipoContratoProdutoRetencao
  ADD CONSTRAINT FK_CTCTipoContratoProdutoRetencao_EnteConsignante FOREIGN KEY (EnteConsignante) REFERENCES dbo.CTCEnteConsignante (Codigo)
GO

ALTER TABLE FastConsig.dbo.CTCTipoContratoProdutoRetencao
  ADD CONSTRAINT FK_CTCTipoContratoProdutoRetencao_ProdutoRetencao FOREIGN KEY (ProdutoRetencao) REFERENCES dbo.Produtos (Id)
GO

ALTER TABLE FastConsig.dbo.CTCTipoContratoProdutoRetencao
  ADD CONSTRAINT FK_CTCTipoContratoProdutoRetencao_TipoContrato FOREIGN KEY (TipoContrato) REFERENCES dbo.CTCTipoContrato (Codigo)
GO