CREATE TABLE FastConsig.dbo.Lojas (
  Id int IDENTITY,
  RedeLoja int NOT NULL,
  Loja int NOT NULL,
  Nome varchar(40) NULL,
  Abreviatura varchar(20) NULL,
  Endereco varchar(40) NULL,
  Numero varchar(7) NULL,
  Complemento varchar(20) NULL,
  Bairro varchar(15) NULL,
  Cidade varchar(20) NULL,
  Estado varchar(2) NULL,
  Cep varchar(8) NULL,
  Cnpj varchar(15) NULL,
  CONSTRAINT PK_Lojas PRIMARY KEY CLUSTERED (Id),
  CONSTRAINT KEY_Lojas UNIQUE (RedeLoja, Loja)
)
ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.Lojas
  ADD CONSTRAINT FK_Lojas_RedeLoja FOREIGN KEY (RedeLoja) REFERENCES dbo.RedeLoja (Id)
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

SET IDENTITY_INSERT FastConsig.dbo.Lojas ON
GO
INSERT FastConsig.dbo.Lojas(Id, RedeLoja, Loja, Nome, Abreviatura, Endereco, Numero, Complemento, Bairro, Cidade, Estado, Cep, Cnpj) VALUES (1, 1, 1, 'BMP', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
SET IDENTITY_INSERT FastConsig.dbo.Lojas OFF
GO