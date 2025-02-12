CREATE TABLE FastConsig.dbo.PropostaParcelas (
  Id int IDENTITY,
  Proposta int NOT NULL,
  Operacao int NULL,
  DataVencimento date NULL,
  ValorLimite decimal(12, 2) NULL,
  ValorParcela decimal(12, 2) NULL,
  ValorRepasse decimal(12, 2) NULL,
  IofNormal decimal(12, 2) NULL,
  IofAdicional decimal(12, 2) NULL,
  Principal decimal(12, 2) NULL,
  Renda decimal(12, 2) NULL,
  Parcela int NULL,
  ValorTotal decimal(12, 2) NULL,
  ValorAmortizacaoSemIOF decimal(12, 2) NULL,
  ValorJuros decimal(12, 2) NULL,
  ValorJurosAcumulado decimal(12, 2) NULL,
  ValorSaldo decimal(12, 2) NULL,
  ValorSaldoRestante decimal(12, 2) NULL,
  ValorReforco decimal(12, 2) NULL,
  TipoParcela varchar(50) NULL,
  Dias int NULL,
  IOFTotal decimal(12, 2) NULL,
  DiasIOF int NULL,
  ValorBaseIOF decimal(12, 2) NULL,
  ValorProjetado decimal(12, 2) NULL,
  DataPagamento date NULL,
  ValorPago decimal(12, 2) NULL,
  NU varchar(50) NULL,
  CONSTRAINT PK_Parcelas_Id PRIMARY KEY CLUSTERED (Id) WITH (FILLFACTOR = 80)
)
ON [PRIMARY]
GO

CREATE INDEX IDX_Parcelas_09022014_01
  ON FastConsig.dbo.PropostaParcelas (Operacao)
  INCLUDE (Id, Proposta, DataVencimento, ValorLimite, ValorParcela, ValorRepasse, IofNormal, IofAdicional, Principal, Renda, Parcela, ValorTotal, ValorAmortizacaoSemIOF, ValorJuros, ValorJurosAcumulado, ValorSaldo, ValorSaldoRestante, ValorReforco, TipoParcela, Dias, IOFTotal, DiasIOF, ValorBaseIOF, ValorProjetado, DataPagamento, ValorPago, NU)
  WITH (FILLFACTOR = 80)
  ON [PRIMARY]
GO

CREATE INDEX IDX_Parcelas_Proposta
  ON FastConsig.dbo.PropostaParcelas (Proposta)
  ON [PRIMARY]
GO

CREATE INDEX IX_PARCELAS_PROPOSTA
  ON FastConsig.dbo.PropostaParcelas (Proposta)
  WITH (FILLFACTOR = 80)
  ON [PRIMARY]
GO