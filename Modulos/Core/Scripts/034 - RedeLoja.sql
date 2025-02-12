CREATE TABLE FastConsig.dbo.RedeLoja (
  Id int IDENTITY,
  Nome varchar(100) NULL,
  Abreviatura varchar(40) NULL,
  Endereco varchar(40) NULL,
  Numero varchar(7) NULL,
  Complemento varchar(20) NULL,
  Cidade varchar(20) NULL,
  Bairro varchar(20) NULL,
  Estado varchar(2) NULL,
  Cep varchar(8) NULL,
  Cnpj varchar(14) NULL,
  Promotora int NOT NULL,
  CONSTRAINT PK_RedeLoja PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.RedeLoja
  ADD CONSTRAINT FK_RedeLoja_Promotora FOREIGN KEY (Promotora) REFERENCES dbo.Promotoras (Id)
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

SET IDENTITY_INSERT FastConsig.dbo.RedeLoja ON
GO
INSERT FastConsig.dbo.RedeLoja(Id, Nome, Abreviatura, Endereco, Numero, Complemento, Cidade, Bairro, Estado, Cep, Cnpj, Promotora) VALUES (1, 'BMP', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
GO
SET IDENTITY_INSERT FastConsig.dbo.RedeLoja OFF
GO