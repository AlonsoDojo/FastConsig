CREATE TABLE FastConsig.dbo.CTCTipoEnteConsignante (
  Id int IDENTITY,
  Codigo varchar(2) NOT NULL,
  Descricao varchar(50) NOT NULL,
  CONSTRAINT PK_CTCTipoEnteConsignante_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

CREATE UNIQUE INDEX UK_CTCTipoEnteConsignante_Codigo
  ON FastConsig.dbo.CTCTipoEnteConsignante (Codigo)
  ON [PRIMARY]
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

SET IDENTITY_INSERT FastConsig.dbo.CTCTipoEnteConsignante ON
GO
INSERT FastConsig.dbo.CTCTipoEnteConsignante(Id, Codigo, Descricao) VALUES (1, '01', 'Consignado (INSS)')
INSERT FastConsig.dbo.CTCTipoEnteConsignante(Id, Codigo, Descricao) VALUES (2, '02', 'Consignado (Empresa Privada)')
INSERT FastConsig.dbo.CTCTipoEnteConsignante(Id, Codigo, Descricao) VALUES (3, '03', 'Consignado (Órgão Público)')
INSERT FastConsig.dbo.CTCTipoEnteConsignante(Id, Codigo, Descricao) VALUES (4, '1', 'Consignado (INSS)')
INSERT FastConsig.dbo.CTCTipoEnteConsignante(Id, Codigo, Descricao) VALUES (5, '2', 'Consignado (Empresa Privada)')
INSERT FastConsig.dbo.CTCTipoEnteConsignante(Id, Codigo, Descricao) VALUES (6, '3', 'Consignado (Órgão Público)')
GO
SET IDENTITY_INSERT FastConsig.dbo.CTCTipoEnteConsignante OFF
GO