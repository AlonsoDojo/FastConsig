CREATE TABLE FastConsig.dbo.SimulacaoParcelas (
  Id int IDENTITY,
  Simulacao int NOT NULL,
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
  CONSTRAINT PK_SimulacaoParcelas_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

CREATE INDEX idx_SimulacaoParcelas_01
  ON FastConsig.dbo.SimulacaoParcelas (Simulacao)
  ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.SimulacaoParcelas
  ADD CONSTRAINT FK_SimulacaoParcelas_Simulacao FOREIGN KEY (Simulacao) REFERENCES dbo.SimulacaoProposta (Id)
GO