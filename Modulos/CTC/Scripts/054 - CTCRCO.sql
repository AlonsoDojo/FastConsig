CREATE TABLE FastConsig.dbo.CTCRCO (
  Id int IDENTITY,
  AnoMes varchar(6) NOT NULL,
  Tipo varchar(1) NOT NULL,
  IdentidadeParticipanteAdministrado varchar(8) NOT NULL,
  ISPBContraParte varchar(8) NULL,
  TipoContrato varchar(4) NULL,
  EnteConsignante varchar(2) NULL,
  Contrato varchar(40) NULL,
  NUPortabilidade varchar(21) NULL,
  DataContrato date NULL,
  DataVencimentoUltimaParcela date NULL,
  DataReferenciaSaldoDevedor date NULL,
  ValorSaldoDevedor decimal(18, 2) NULL,
  ValorSaldoDevedorAD decimal(18, 2) NULL,
  BaseCalculoRCO decimal(18, 2) NULL,
  DataMovimentoLiquidacaoSTR date NULL,
  ValorSTRLiquidacaoPortabilidade decimal(18, 2) NULL,
  ValorRCO decimal(18, 2) NULL,
  ISPBBancoPagamento varchar(8) NULL,
  CodigoBancoPagamento varchar(3) NULL,
  AgenciaPagamento varchar(4) NULL,
  ContaPagamento varchar(13) NULL,
  Arquivo int NOT NULL,
  CONSTRAINT PK_CTCRCO_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.CTCRCO
  ADD CONSTRAINT FK_CTCRCO_Arquivo FOREIGN KEY (Arquivo) REFERENCES dbo.CTCArquivos (Id)
GO

ALTER TABLE FastConsig.dbo.CTCRCO
  ADD CONSTRAINT FK_CTCRCO_EnteConsignante FOREIGN KEY (EnteConsignante) REFERENCES dbo.CTCTipoEnteConsignante (Codigo)
GO

ALTER TABLE FastConsig.dbo.CTCRCO
  ADD CONSTRAINT FK_CTCRCO_TipoContrato FOREIGN KEY (TipoContrato) REFERENCES dbo.CTCTipoContrato (Codigo)
GO