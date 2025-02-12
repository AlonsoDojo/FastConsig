CREATE TABLE FastConsig.dbo.SimulacaoPessoa (
  Id int IDENTITY,
  CpfCnpj char(14) NULL,
  Nome varchar(100) NULL,
  TipoPessoa char(1) NULL,
  DataNascimento date NULL,
  NumeroBeneficio varchar(100) NULL,
  DDDCelular int NULL,
  Celular int NULL,
  Email varchar(100) NULL,
  NumeroBeneficio2 varchar(100) NULL,
  EspecieBeneficio int NULL,
  Orgao int NULL,
  UFBeneficio varchar(2) NULL,
  IfPagadora int NULL,
  AgenciaPagadora int NULL,
  ContaCorrente varchar(20) NULL,
  Simulacao int NULL,
  IndicadorAnalfabetismo bit NULL,
  ValorRenda decimal(12, 2) NULL,
  CONSTRAINT PK_SimulacaoPessoa_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO