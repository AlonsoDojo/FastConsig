CREATE TABLE FastConsig.dbo.PropostaContratosREFIN (
  Id int IDENTITY,
  Proposta int NOT NULL,
  Empresa varchar(2) NOT NULL,
  Agencia varchar(4) NOT NULL,
  Contrato varchar(10) NOT NULL,
  CpfCnpj varchar(14) NOT NULL,
  DataSituacao date NULL,
  Emissao date NULL,
  Vencimento date NULL,
  Prazo varchar(3) NULL,
  Produto varchar(6) NULL,
  DiasAtraso int NULL,
  Principal decimal(18, 2) NULL,
  ValorContrato decimal(18, 2) NULL,
  ValorTotalAPagar decimal(18, 2) NULL,
  Tac decimal(18, 2) NULL,
  Seguro decimal(18, 2) NULL,
  TaxaMensal decimal(18, 6) NULL,
  TaxaAnual decimal(18, 6) NULL,
  SaldoDevedor decimal(18, 2) NULL,
  DataSaldoDevedor date NULL,
  SaldoAtual decimal(18, 2) NULL,
  IofAtraso decimal(18, 2) NULL,
  SaldoPrincipalEmAberto decimal(18, 2) NULL,
  Matricula varchar(20) NULL,
  TipoBeneficio varchar(3) NULL,
  UfBeneficio varchar(2) NULL,
  Titularidade varchar(1) NULL,
  MeioRecebimentoBeneficio varchar(2) NULL,
  Utilizado bit NULL,
  ValorParcela decimal(18, 2) NULL,
  ParcelasEmAberto int NULL,
  CONSTRAINT PK_PropostaContratosREFIN_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.PropostaContratosREFIN
  ADD CONSTRAINT FK_PropostaContratosREFIN_Proposta FOREIGN KEY (Proposta) REFERENCES dbo.Propostas (Id)
GO