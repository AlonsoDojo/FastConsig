CREATE TABLE FastConsig.dbo.CTCRegimeAmortizacao (
  Id int IDENTITY,
  Codigo varchar(2) NOT NULL,
  Descricao varchar(50) NOT NULL,
  CONSTRAINT PK_CTCRegimeAmortizacao_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

CREATE UNIQUE INDEX IDX_CTCRegimeAmortizacao_Codigo
  ON FastConsig.dbo.CTCRegimeAmortizacao (Codigo)
  ON [PRIMARY]
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

SET IDENTITY_INSERT FastConsig.dbo.CTCRegimeAmortizacao ON
GO
INSERT FastConsig.dbo.CTCRegimeAmortizacao(Id, Codigo, Descricao) VALUES (1, '01', 'PRICE')
INSERT FastConsig.dbo.CTCRegimeAmortizacao(Id, Codigo, Descricao) VALUES (2, '02', 'SAC')
INSERT FastConsig.dbo.CTCRegimeAmortizacao(Id, Codigo, Descricao) VALUES (3, '03', 'SACRE')
INSERT FastConsig.dbo.CTCRegimeAmortizacao(Id, Codigo, Descricao) VALUES (4, '99', 'Outros')
INSERT FastConsig.dbo.CTCRegimeAmortizacao(Id, Codigo, Descricao) VALUES (5, '1', 'PRICE')
INSERT FastConsig.dbo.CTCRegimeAmortizacao(Id, Codigo, Descricao) VALUES (6, '2', 'SAC')
INSERT FastConsig.dbo.CTCRegimeAmortizacao(Id, Codigo, Descricao) VALUES (7, '3', 'SACRE')
GO
SET IDENTITY_INSERT FastConsig.dbo.CTCRegimeAmortizacao OFF
GO