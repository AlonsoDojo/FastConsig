CREATE TABLE FastConsig.dbo.Promotoras (
  Id int IDENTITY,
  Nome varchar(100) NOT NULL,
  Cep varchar(8) NULL,
  Endereco varchar(100) NULL,
  Numero varchar(8) NULL,
  Complemento varchar(50) NULL,
  Bairro varchar(50) NULL,
  Cidade varchar(50) NULL,
  Estado varchar(2) NULL,
  DDD varchar(2) NULL,
  Telefone varchar(9) NULL,
  Email varchar(100) NULL,
  Cnpj varchar(14) NULL,
  Ativo bit NULL,
  Correspondente bit NULL,
  NomeFantasia varchar(100) NULL,
  IndiceReclamacoes decimal(5, 2) NULL,
  ResultadoReclamacoes int NULL,
  IndiceAcoesJudiciais decimal(5, 2) NULL,
  ResultadoAcoesJudiciais int NULL,
  IndicadorNaoConformidade bit NULL,
  DataBaseConsultaQuadroSocietario date NULL,
  Gerente int NULL,
  CONSTRAINT PK_Promotoras_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.Promotoras
  ADD CONSTRAINT FK_Promotoras_Gerente FOREIGN KEY (Gerente) REFERENCES dbo.Gerentes (Id)
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

SET IDENTITY_INSERT FastConsig.dbo.Promotoras ON
GO
INSERT FastConsig.dbo.Promotoras(Id, Nome, Cep, Endereco, Numero, Complemento, Bairro, Cidade, Estado, DDD, Telefone, Email, Cnpj, Ativo, Correspondente, NomeFantasia, IndiceReclamacoes, ResultadoReclamacoes, IndiceAcoesJudiciais, ResultadoAcoesJudiciais, IndicadorNaoConformidade, DataBaseConsultaQuadroSocietario, Gerente) VALUES (1, 'BMP', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT FastConsig.dbo.Promotoras OFF
GO
