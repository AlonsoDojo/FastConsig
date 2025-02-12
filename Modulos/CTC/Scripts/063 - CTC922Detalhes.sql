CREATE TABLE FastConsig.dbo.CTC922Detalhes (
  Id int IDENTITY,
  CTC922 int NOT NULL,
  TipoParte int NOT NULL,
  MotivoRetencao varchar(3) NULL,
  QtdRetencao int NULL,
  MotivoDecursoPrazo varchar(3) NULL,
  QtdDecursoPrazo int NULL,
  MotivoCancelamento varchar(3) NULL,
  QtdCancelamento int NULL,
  MotivoDevolucaoLiquidacao varchar(2) NULL,
  QtdDevolucaoLiquidacao int NULL,
  TipoContrato varchar(4) NOT NULL,
  EnteConsignante varchar(2) NULL,
  SituacaoPortabilidade varchar(2) NULL,
  QtdSituacaoPortabilidade int NULL,
  CONSTRAINT PK_CTC922Detalhes_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.CTC922Detalhes
  ADD CONSTRAINT FK_CTC922Detalhes_CTC922 FOREIGN KEY (CTC922) REFERENCES dbo.CTC922 (Id)
GO

ALTER TABLE FastConsig.dbo.CTC922Detalhes
  ADD CONSTRAINT FK_CTC922Detalhes_EnteConsignante FOREIGN KEY (EnteConsignante) REFERENCES dbo.CTCEnteConsignante (Codigo)
GO

ALTER TABLE FastConsig.dbo.CTC922Detalhes
  ADD CONSTRAINT FK_CTC922Detalhes_MotivoCancelamento FOREIGN KEY (MotivoCancelamento) REFERENCES dbo.CTCMotivoCancelamentoPortabilidade (Codigo)
GO

ALTER TABLE FastConsig.dbo.CTC922Detalhes
  ADD CONSTRAINT FK_CTC922Detalhes_MotivoDecursoPrazo FOREIGN KEY (MotivoDecursoPrazo) REFERENCES dbo.CTCMotivoDecursoPrazoPortabilidade (Codigo)
GO

ALTER TABLE FastConsig.dbo.CTC922Detalhes
  ADD CONSTRAINT FK_CTC922Detalhes_MotivoDevolucaoLiquidacao FOREIGN KEY (MotivoDevolucaoLiquidacao) REFERENCES dbo.CTCMotivoDevolucaoLiquidacaoPortabilidade (Codigo)
GO

ALTER TABLE FastConsig.dbo.CTC922Detalhes
  ADD CONSTRAINT FK_CTC922Detalhes_MotivoRetencao FOREIGN KEY (MotivoRetencao) REFERENCES dbo.CTCMotivoRetencaoContrato (Codigo)
GO

ALTER TABLE FastConsig.dbo.CTC922Detalhes
  ADD CONSTRAINT FK_CTC922Detalhes_SituacaoPortabilidade FOREIGN KEY (SituacaoPortabilidade) REFERENCES dbo.CTCSituacaoPortabilidade (Codigo)
GO

ALTER TABLE FastConsig.dbo.CTC922Detalhes
  ADD CONSTRAINT FK_CTC922Detalhes_TipoContrato FOREIGN KEY (TipoContrato) REFERENCES dbo.CTCTipoContrato (Codigo)
GO

ALTER TABLE FastConsig.dbo.CTC922Detalhes
  ADD CONSTRAINT FK_CTC922Detalhes_TipoParte FOREIGN KEY (TipoParte) REFERENCES dbo.CTC922TipoParte (Id)
GO