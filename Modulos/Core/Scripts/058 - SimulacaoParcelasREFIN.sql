CREATE TABLE FastConsig.dbo.SimulacaoParcelasREFIN (
  Id int IDENTITY,
  Simulacao int NULL,
  Empresa varchar(2) NOT NULL,
  Agencia varchar(4) NOT NULL,
  Contrato varchar(10) NOT NULL,
  Parcela varchar(3) NULL,
  Vencimento date NULL,
  ValorPrestacao decimal(18, 2) NULL,
  SaldoDevedor decimal(18, 2) NULL,
  Situacao varchar(1) NULL,
  DataPagamento date NULL,
  PrincipalEmAberto decimal(18, 2) NULL,
  DiasAtraso int NULL,
  Utilizado bit NULL,
  CONSTRAINT PK_SimulacaoParcelasREFIN_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO