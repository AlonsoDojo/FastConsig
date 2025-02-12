CREATE TABLE FastConsig.dbo.CTC924Detalhes (
  Id int IDENTITY,
  CTC924 int NOT NULL,
  DataSolicitacao date NOT NULL,
  NUPortabilidade varchar(21) NULL,
  SituacaoPortabilidadeCTC varchar(2) NULL,
  ISPBProponente varchar(8) NULL,
  DataReferenciaSaldoDevedorProponente date NULL,
  ValorSaldoDevedorProponente decimal(18, 2) NULL,
  DataReferenciaSaldoDevedorOriginal date NULL,
  ValorSaldoDevedorOriginal decimal(18, 2) NULL,
  Contrato varchar(40) NULL,
  CNPJBaseIFOriginal varchar(8) NULL,
  TipoContrato varchar(4) NULL,
  EnteConsignante varchar(2) NULL,
  CNPJCorrespondenteBancario varchar(14) NULL,
  TipoCliente varchar(1) NULL,
  CpfCnpjCliente varchar(14) NULL,
  NomeCliente varchar(150) NULL,
  TelefoneCliente varchar(20) NULL,
  EmailCliente varchar(150) NULL,
  LogradouroEnderecoCliente varchar(150) NULL,
  NumeroEnderecoCliente varchar(20) NULL,
  CidadeEnderecoCliente varchar(50) NULL,
  UFEnderecoCliente varchar(2) NULL,
  CEPEnderecoCliente varchar(8) NULL,
  DataDecursoPrazo date NULL,
  MotivoDecursoPrazo varchar(3) NULL,
  DataCancelamento date NULL,
  MotivoCancelamento varchar(3) NULL,
  ISPBSolicitanteCancelamento varchar(8) NULL,
  DataRetencao date NULL,
  MotivoRetencaoContrato varchar(3) NULL,
  DataLiquidacao date NULL,
  SituacaoLiquidacao varchar(3) NULL,
  ValorLiquidacaoPortabilidade decimal(18, 2) NULL,
  DataDevolucaoLiquidacao date NULL,
  SituacaoDevolucaoLiquidacao varchar(3) NULL,
  MotivoDevolucaoLiquidacao varchar(2) NULL,
  ValorDevolucaoLiquidacao decimal(18, 2) NULL,
  DataEfetivacaoPortabilidade date NULL,
  SituacaoEfetivacaoPortabilidade varchar(3) NULL,
  ValorRCO decimal(18, 2) NULL,
  CONSTRAINT PK_CTC924Detalhes_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.CTC924Detalhes
  ADD CONSTRAINT FK_CTC924Detalhes_CTC924 FOREIGN KEY (CTC924) REFERENCES dbo.CTC924 (Id)
GO

ALTER TABLE FastConsig.dbo.CTC924Detalhes
  ADD CONSTRAINT FK_CTC924Detalhes_EnteConsignante FOREIGN KEY (EnteConsignante) REFERENCES dbo.CTCEnteConsignante (Codigo)
GO

ALTER TABLE FastConsig.dbo.CTC924Detalhes
  ADD CONSTRAINT FK_CTC924Detalhes_MotivoCancelamento FOREIGN KEY (MotivoCancelamento) REFERENCES dbo.CTCMotivoCancelamentoPortabilidade (Codigo)
GO

ALTER TABLE FastConsig.dbo.CTC924Detalhes
  ADD CONSTRAINT FK_CTC924Detalhes_MotivoDecursoPrazo FOREIGN KEY (MotivoDecursoPrazo) REFERENCES dbo.CTCMotivoDecursoPrazoPortabilidade (Codigo)
GO

ALTER TABLE FastConsig.dbo.CTC924Detalhes
  ADD CONSTRAINT FK_CTC924Detalhes_MotivoDevolucaoLiquidacao FOREIGN KEY (MotivoDevolucaoLiquidacao) REFERENCES dbo.CTCMotivoDevolucaoLiquidacaoPortabilidade (Codigo)
GO

ALTER TABLE FastConsig.dbo.CTC924Detalhes
  ADD CONSTRAINT FK_CTC924Detalhes_MotivoRetencaoContrato FOREIGN KEY (MotivoRetencaoContrato) REFERENCES dbo.CTCMotivoRetencaoContrato (Codigo)
GO

ALTER TABLE FastConsig.dbo.CTC924Detalhes
  ADD CONSTRAINT FK_CTC924Detalhes_SituacaoDevolucaoLiquidacao FOREIGN KEY (SituacaoDevolucaoLiquidacao) REFERENCES dbo.CTCSituacaoLiquidacaoPortabilidade (Codigo)
GO

ALTER TABLE FastConsig.dbo.CTC924Detalhes
  ADD CONSTRAINT FK_CTC924Detalhes_SituacaoEfetivacaoPortabilidade FOREIGN KEY (SituacaoEfetivacaoPortabilidade) REFERENCES dbo.CTCSituacaoEfetivacaoPortabilidade (Codigo)
GO

ALTER TABLE FastConsig.dbo.CTC924Detalhes
  ADD CONSTRAINT FK_CTC924Detalhes_SituacaoLiquidacao FOREIGN KEY (SituacaoLiquidacao) REFERENCES dbo.CTCSituacaoLiquidacaoPortabilidade (Codigo)
GO

ALTER TABLE FastConsig.dbo.CTC924Detalhes
  ADD CONSTRAINT FK_CTC924Detalhes_SituacaoPortabilidadeCTC FOREIGN KEY (SituacaoPortabilidadeCTC) REFERENCES dbo.CTCSituacaoPortabilidade (Codigo)
GO

ALTER TABLE FastConsig.dbo.CTC924Detalhes
  ADD CONSTRAINT FK_CTC924Detalhes_TipoContrato FOREIGN KEY (TipoContrato) REFERENCES dbo.CTCTipoContrato (Codigo)
GO