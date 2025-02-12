CREATE TABLE FastConsig.dbo.CTCTipoContrato (
  Id int IDENTITY,
  Codigo varchar(4) NOT NULL,
  Descricao varchar(100) NOT NULL,
  CONSTRAINT PK_CTCTipoContrato_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

CREATE UNIQUE INDEX UK_CTCTipoContrato_Codigo
  ON FastConsig.dbo.CTCTipoContrato (Codigo)
  ON [PRIMARY]
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

SET IDENTITY_INSERT FastConsig.dbo.CTCTipoContrato ON
GO
INSERT FastConsig.dbo.CTCTipoContrato(Id, Codigo, Descricao) VALUES (1, '0202', 'Crédito Consignado')
INSERT FastConsig.dbo.CTCTipoContrato(Id, Codigo, Descricao) VALUES (2, '0203', 'Crédito Pessoal sem consignação em folha de pagamento')
INSERT FastConsig.dbo.CTCTipoContrato(Id, Codigo, Descricao) VALUES (3, '0211', 'Imobiliário - Home Equity')
INSERT FastConsig.dbo.CTCTipoContrato(Id, Codigo, Descricao) VALUES (4, '0299', 'Imobiliário - Outros Empréstimos')
INSERT FastConsig.dbo.CTCTipoContrato(Id, Codigo, Descricao) VALUES (5, '0401', 'Veículo')
INSERT FastConsig.dbo.CTCTipoContrato(Id, Codigo, Descricao) VALUES (6, '0901', 'Imobiliário – Financiamento Habitacional - SFH')
INSERT FastConsig.dbo.CTCTipoContrato(Id, Codigo, Descricao) VALUES (7, '0902', 'Imobiliário – Financiamento Habitacional – Carteira Hipotecária (sem SFH)')
INSERT FastConsig.dbo.CTCTipoContrato(Id, Codigo, Descricao) VALUES (8, '0903', 'Imobiliário - financiamento imobiliário – empreendim., exceto habitacional')
INSERT FastConsig.dbo.CTCTipoContrato(Id, Codigo, Descricao) VALUES (9, '0212', 'Microcrédito (Outros Créditos) ')
INSERT FastConsig.dbo.CTCTipoContrato(Id, Codigo, Descricao) VALUES (10, '0402', 'Aquisição de bens – Outros bens (Outros Créditos)')
INSERT FastConsig.dbo.CTCTipoContrato(Id, Codigo, Descricao) VALUES (11, '0403', 'Microcrédito (Outros Créditos)')
INSERT FastConsig.dbo.CTCTipoContrato(Id, Codigo, Descricao) VALUES (12, '0213', 'Cheque Especial')
INSERT FastConsig.dbo.CTCTipoContrato(Id, Codigo, Descricao) VALUES (13, '0215', 'Capital de Giro com prazo de vencimento até 365 dias')
INSERT FastConsig.dbo.CTCTipoContrato(Id, Codigo, Descricao) VALUES (14, '0216', 'Capital de Giro com prazo vencimento superior 365 dias')
INSERT FastConsig.dbo.CTCTipoContrato(Id, Codigo, Descricao) VALUES (15, '0217', 'Capital de Giro com teto rotativo')
GO
SET IDENTITY_INSERT FastConsig.dbo.CTCTipoContrato OFF
GO