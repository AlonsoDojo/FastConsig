CREATE TABLE FastConsig.dbo.SimulacaoOperacao (
  Id int IDENTITY,
  Simulacao int NOT NULL,
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
  RedeLojas varchar(6) NULL,
  Loja varchar(4) NULL,
  Tabela varchar(4) NULL,
  TacFinanciada bit NULL,
  IOFFinaciado bit NULL,
  ValorGarantia decimal(12, 2) NULL,
  MetodoAmortizacao int NULL,
  ValorIndexadorProjetado decimal(12, 6) NULL,
  ObjetivoEmprestimo int NULL,
  ValorMargem decimal(12, 2) NULL,
  ValorRenegociacaoTotal decimal(12, 2) NULL,
  CONSTRAINT PK_SimulacaoOperacao_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.SimulacaoOperacao
  ADD CONSTRAINT FK_SimulacaoOperacao_Produto FOREIGN KEY (Produto) REFERENCES dbo.Produtos (Id)
GO

ALTER TABLE FastConsig.dbo.SimulacaoOperacao
  ADD CONSTRAINT FK_SimulacaoOperacao_Simulacao FOREIGN KEY (Simulacao) REFERENCES dbo.SimulacaoProposta (Id)
GO