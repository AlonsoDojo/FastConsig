CREATE TABLE FastConsig.dbo.CTCMoeda (
  Id int IDENTITY,
  Codigo varchar(2) NOT NULL,
  Descricao varchar(50) NULL,
  CONSTRAINT PK_CTCMoeda PRIMARY KEY CLUSTERED (Id, Codigo)
)
ON [PRIMARY]
GO

CREATE UNIQUE INDEX UK_CTCMoeda_Codigo
  ON FastConsig.dbo.CTCMoeda (Codigo)
  ON [PRIMARY]
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

SET IDENTITY_INSERT FastConsig.dbo.CTCMoeda ON
GO
INSERT FastConsig.dbo.CTCMoeda(Id, Codigo, Descricao) VALUES (1, N'02', 'Dólar Americano Comercial (Venda)')
INSERT FastConsig.dbo.CTCMoeda(Id, Codigo, Descricao) VALUES (2, N'03', 'Dólar Americano Turismo')
INSERT FastConsig.dbo.CTCMoeda(Id, Codigo, Descricao) VALUES (3, N'09', 'Real')
INSERT FastConsig.dbo.CTCMoeda(Id, Codigo, Descricao) VALUES (4, N'14', 'EURO')
INSERT FastConsig.dbo.CTCMoeda(Id, Codigo, Descricao) VALUES (5, N'15', 'Cruzeiro Real')
INSERT FastConsig.dbo.CTCMoeda(Id, Codigo, Descricao) VALUES (6, N'2', 'Dólar Americano Comercial (Venda)')
INSERT FastConsig.dbo.CTCMoeda(Id, Codigo, Descricao) VALUES (7, N'3', 'Dólar Americano Turismo')
INSERT FastConsig.dbo.CTCMoeda(Id, Codigo, Descricao) VALUES (8, N'9', 'Real')
GO
SET IDENTITY_INSERT FastConsig.dbo.CTCMoeda OFF
GO