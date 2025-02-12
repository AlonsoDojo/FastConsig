CREATE TABLE FastConsig.dbo.CTCEnquadramentoContrato (
  Id int IDENTITY,
  Codigo varchar(2) NOT NULL,
  Descricao varchar(50) NOT NULL,
  CONSTRAINT PK_CTCEnquadramentoContrato_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

CREATE UNIQUE INDEX IDX_CTCEnquadramentoContrato_Codigo
  ON FastConsig.dbo.CTCEnquadramentoContrato (Codigo)
  ON [PRIMARY]
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

SET IDENTITY_INSERT FastConsig.dbo.CTCEnquadramentoContrato ON
GO
INSERT FastConsig.dbo.CTCEnquadramentoContrato(Id, Codigo, Descricao) VALUES (1, '01', 'SFH - Âmbito')
INSERT FastConsig.dbo.CTCEnquadramentoContrato(Id, Codigo, Descricao) VALUES (2, '02', 'SFH - Carteira Hipotecária Habitacioal')
INSERT FastConsig.dbo.CTCEnquadramentoContrato(Id, Codigo, Descricao) VALUES (3, '03', 'SFH - Carteira Hipotecária Comercial')
INSERT FastConsig.dbo.CTCEnquadramentoContrato(Id, Codigo, Descricao) VALUES (4, '04', 'SFI')
INSERT FastConsig.dbo.CTCEnquadramentoContrato(Id, Codigo, Descricao) VALUES (5, '05', 'Outros')
INSERT FastConsig.dbo.CTCEnquadramentoContrato(Id, Codigo, Descricao) VALUES (6, '06', 'CCFFGTS')
INSERT FastConsig.dbo.CTCEnquadramentoContrato(Id, Codigo, Descricao) VALUES (7, '07', 'PMCMV')
INSERT FastConsig.dbo.CTCEnquadramentoContrato(Id, Codigo, Descricao) VALUES (8, '08', 'Proquotista')
GO
SET IDENTITY_INSERT FastConsig.dbo.CTCEnquadramentoContrato OFF
GO