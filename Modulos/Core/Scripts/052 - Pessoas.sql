CREATE TABLE FastConsig.dbo.Pessoas (
  Id int IDENTITY,
  CpfCnpj char(14) NULL,
  Nome varchar(150) NULL,
  TipoPessoa char(1) NULL,
  DataNascimento date NULL,
  Nacionalidade int NULL,
  Naturalidade varchar(30) NULL,
  Sexo char(1) NULL,
  EstadoCivil int NULL,
  Pis bigint NULL,
  TipoDocumentoIdentidade int NULL,
  NumeroDocumentoIdentidade varchar(15) NULL,
  OrgaoEmissor int NULL,
  UFEmissaoDocumentoIdentidade varchar(2) NULL,
  DataEmissaoDocumentoIdentidade date NULL,
  Mae varchar(100) NULL,
  Pai varchar(100) NULL,
  Conjuge varchar(100) NULL,
  CBO int NULL,
  DDDResidencial int NULL,
  TelefoneResidencial varchar(18) NULL,
  DDDCelular int NULL,
  Celular int NULL,
  DDDRecado int NULL,
  TelefoneRecado int NULL,
  Email varchar(100) NULL,
  PPE bit NULL,
  CEPResidencial varchar(8) NULL,
  EnderecoResidencial varchar(100) NULL,
  NumeroResidencial varchar(7) NULL,
  ComplementoResidencial varchar(50) NULL,
  BairroResidencial varchar(50) NULL,
  CidadeResidencial varchar(80) NULL,
  EstadoResidencial char(2) NULL,
  TempoResidenciaAnos int NULL,
  TempoResidenciaMeses int NULL,
  TempoResidenciaAnteriorAnos int NULL,
  TempoResidenciaAnteriorMeses int NULL,
  CEPComercial varchar(8) NULL,
  EnderecoComercial varchar(100) NULL,
  NumeroComercial varchar(7) NULL,
  ComplementoComercial varchar(50) NULL,
  BairroComercial varchar(50) NULL,
  CidadeComercial varchar(80) NULL,
  UFComercial varchar(2) NULL,
  Empresa varchar(100) NULL,
  Cargo varchar(100) NULL,
  DDDComercial int NULL,
  TelefoneComercial varchar(18) NULL,
  CnpjEmpresa int NULL,
  NomeEmpresa varchar(100) NULL,
  ValorRenda decimal(18, 2) NULL,
  ValorOutrasRendas decimal(12, 2) NULL,
  NumeroBeneficio varchar(20) NULL,
  NumeroBeneficio2 varchar(20) NULL,
  EspecieBeneficio int NULL,
  Orgao int NULL,
  UFBeneficio varchar(2) NULL,
  IfPagadora int NULL,
  AgenciaPagadora int NULL,
  ContaCorrente varchar(20) NULL,
  IndicadorAnalfabetismo bit NULL
)
ON [PRIMARY]
GO

CREATE INDEX IX_IX_Pessoas_1
  ON FastConsig.dbo.Pessoas (CpfCnpj)
  WITH (FILLFACTOR = 80)
  ON [PRIMARY]
GO

CREATE INDEX IX_IX_Pessoas_2
  ON FastConsig.dbo.Pessoas (Nome)
  WITH (FILLFACTOR = 80)
  ON [PRIMARY]
GO

CREATE INDEX IX_Pessoas
  ON FastConsig.dbo.Pessoas (Id)
  ON [PRIMARY]
GO

CREATE UNIQUE CLUSTERED INDEX UK_Pessoas_Id
  ON FastConsig.dbo.Pessoas (Id)
  WITH (FILLFACTOR = 80)
  ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.Pessoas
  ADD CONSTRAINT FK_Pessoas_CBO FOREIGN KEY (CBO) REFERENCES dbo.RamoAtividade (Id)
GO

ALTER TABLE FastConsig.dbo.Pessoas
  ADD CONSTRAINT FK_Pessoas_EspecieBeneficio FOREIGN KEY (EspecieBeneficio) REFERENCES dbo.TipoBeneficioINSS (Id)
GO

ALTER TABLE FastConsig.dbo.Pessoas
  ADD CONSTRAINT FK_Pessoas_EstadoCivil FOREIGN KEY (EstadoCivil) REFERENCES dbo.EstadoCivil (Id)
GO

ALTER TABLE FastConsig.dbo.Pessoas
  ADD CONSTRAINT FK_Pessoas_Nacionalidade FOREIGN KEY (Nacionalidade) REFERENCES dbo.Nacionalidade (Id)
GO

ALTER TABLE FastConsig.dbo.Pessoas
  ADD CONSTRAINT FK_Pessoas_Orgao FOREIGN KEY (Orgao) REFERENCES dbo.OrgaoSIAPE (Codigo)
GO

ALTER TABLE FastConsig.dbo.Pessoas
  ADD CONSTRAINT FK_Pessoas_OrgaoEmissor FOREIGN KEY (OrgaoEmissor) REFERENCES dbo.OrgaoEmissor (Id)
GO

ALTER TABLE FastConsig.dbo.Pessoas
  ADD CONSTRAINT FK_Pessoas_TipoDocumentoIdentidade FOREIGN KEY (TipoDocumentoIdentidade) REFERENCES dbo.TipoDocumentoIdentidade (Id)
GO