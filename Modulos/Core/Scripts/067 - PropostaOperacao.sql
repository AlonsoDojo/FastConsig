CREATE TABLE FastConsig.dbo.PropostaOperacao (
  Proposta int NOT NULL,
  Operacao int IDENTITY,
  Produto int NULL,
  Prazo int NULL,
  ValorOperacao numeric(18, 2) NULL,
  Taxa numeric(12, 6) NULL,
  ValorEntrada decimal(12, 2) NULL,
  ValorParcela decimal(12, 2) NULL,
  ValorTAC decimal(12, 2) NULL,
  ValorTFC decimal(12, 2) NULL,
  ValorPST decimal(12, 2) NULL,
  ValorSeguro decimal(12, 2) NULL,
  ValorIOF decimal(12, 2) NULL,
  ValorIOFNormal decimal(12, 2) NULL,
  ValorIOFAdicional decimal(12, 2) NULL,
  ValorFinanciadoTotal decimal(12, 2) NULL,
  ValorLiberado decimal(12, 2) NULL,
  TaxaMes float NULL,
  TaxaAno float NULL,
  CETMes float NULL,
  CETAno float NULL,
  DataEmissao date NULL,
  DataPrimeiroVencimento date NULL,
  Simulacao int NULL,
  MeioLiberacao int NULL,
  Banco varchar(4) NULL,
  Agencia varchar(4) NULL,
  Conta varchar(15) NULL,
  PropostaLegado varchar(50) NULL,
  ContratoLegado varchar(50) NULL,
  RedeLojas int NULL,
  Loja int NULL,
  Tabela int NULL,
  TacFinanciada bit NULL,
  IOFFinaciado bit NULL,
  EspecieBeneficio int NULL,
  ComprometimentoRenda float NULL,
  Autorizacao int NULL,
  ValorMargem decimal(12, 2) NULL,
  ValorRenegociacaoTotal decimal(12, 2) NULL,
  MeioLiquidacao int NULL,
  BancoLiquidacao varchar(4) NULL,
  AgenciaLiquidacao varchar(4) NULL,
  ContaLiquidacao varchar(15) NULL,
  ChavePIX varchar(250) NULL
)
ON [PRIMARY]
GO

CREATE INDEX IDX_Operacao_ContratoLegado
  ON FastConsig.dbo.PropostaOperacao (ContratoLegado)
  WITH (FILLFACTOR = 80)
  ON [PRIMARY]
GO

CREATE INDEX IDX_Operacao_Id
  ON FastConsig.dbo.PropostaOperacao (Operacao)
  ON [PRIMARY]
GO

CREATE INDEX IDX_Operacao_PropostaLegado
  ON FastConsig.dbo.PropostaOperacao (PropostaLegado)
  WITH (FILLFACTOR = 80)
  ON [PRIMARY]
GO

CREATE INDEX IX_Operacao
  ON FastConsig.dbo.PropostaOperacao (Proposta, Operacao)
  ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.PropostaOperacao
  ADD CONSTRAINT FK_PropostaOperacao_Loja FOREIGN KEY (Loja) REFERENCES dbo.Lojas (Id)
GO

ALTER TABLE FastConsig.dbo.PropostaOperacao
  ADD CONSTRAINT FK_PropostaOperacao_MeioLiberacao FOREIGN KEY (MeioLiberacao) REFERENCES dbo.MeioLiberacao (Id)
GO

ALTER TABLE FastConsig.dbo.PropostaOperacao
  ADD CONSTRAINT FK_PropostaOperacao_Produto FOREIGN KEY (Produto) REFERENCES dbo.Produtos (Id)
GO

ALTER TABLE FastConsig.dbo.PropostaOperacao
  ADD CONSTRAINT FK_PropostaOperacao_Proposta FOREIGN KEY (Proposta) REFERENCES dbo.Propostas (Id)
GO

ALTER TABLE FastConsig.dbo.PropostaOperacao
  ADD CONSTRAINT FK_PropostaOperacao_RedeLojas FOREIGN KEY (RedeLojas) REFERENCES dbo.RedeLoja (Id)
GO

ALTER TABLE FastConsig.dbo.PropostaOperacao
  ADD CONSTRAINT FK_PropostaOperacao_Simulacao FOREIGN KEY (Simulacao) REFERENCES dbo.SimulacaoProposta (Id)
GO