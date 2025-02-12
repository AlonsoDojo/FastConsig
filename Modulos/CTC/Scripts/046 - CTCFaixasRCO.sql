CREATE TABLE FastConsig.dbo.CTCFaixasRCO (
  Id int IDENTITY,
  Vigencia int NOT NULL,
  TipoContrato varchar(4) NOT NULL,
  ValorInicial decimal(18, 2) NOT NULL,
  ValorFinal decimal(18, 2) NOT NULL,
  Valor decimal(18, 2) NOT NULL,
  EnteConsignante varchar(2) NULL,
  CONSTRAINT PK_CTCFaixasRCO_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.CTCFaixasRCO
  ADD CONSTRAINT FK_CTCFaixasRCO_EnteConsignante FOREIGN KEY (EnteConsignante) REFERENCES dbo.CTCTipoEnteConsignante (Codigo)
GO

ALTER TABLE FastConsig.dbo.CTCFaixasRCO
  ADD CONSTRAINT FK_CTCFaixasRCO_TipoContrato FOREIGN KEY (TipoContrato) REFERENCES dbo.CTCTipoContrato (Codigo)
GO

ALTER TABLE FastConsig.dbo.CTCFaixasRCO
  ADD CONSTRAINT FK_CTCFaixasRCO_Vigencia FOREIGN KEY (Vigencia) REFERENCES dbo.CTCVigenciaFaixasRCO (Id)
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

SET IDENTITY_INSERT FastConsig.dbo.CTCFaixasRCO ON
GO
INSERT FastConsig.dbo.CTCFaixasRCO(Id, Vigencia, TipoContrato, ValorInicial, ValorFinal, Valor, EnteConsignante) VALUES (1, 1, '0202', 0.00, 1000.00, 145.00, '01')
INSERT FastConsig.dbo.CTCFaixasRCO(Id, Vigencia, TipoContrato, ValorInicial, ValorFinal, Valor, EnteConsignante) VALUES (2, 1, '0202', 1000.01, 2000.00, 165.00, '01')
INSERT FastConsig.dbo.CTCFaixasRCO(Id, Vigencia, TipoContrato, ValorInicial, ValorFinal, Valor, EnteConsignante) VALUES (3, 1, '0202', 2000.01, 4000.00, 203.00, '01')
INSERT FastConsig.dbo.CTCFaixasRCO(Id, Vigencia, TipoContrato, ValorInicial, ValorFinal, Valor, EnteConsignante) VALUES (4, 1, '0202', 4000.01, 8000.00, 282.00, '01')
INSERT FastConsig.dbo.CTCFaixasRCO(Id, Vigencia, TipoContrato, ValorInicial, ValorFinal, Valor, EnteConsignante) VALUES (5, 1, '0202', 8000.01, 15000.00, 387.00, '01')
INSERT FastConsig.dbo.CTCFaixasRCO(Id, Vigencia, TipoContrato, ValorInicial, ValorFinal, Valor, EnteConsignante) VALUES (6, 1, '0202', 15000.01, 40000.00, 699.00, '01')
INSERT FastConsig.dbo.CTCFaixasRCO(Id, Vigencia, TipoContrato, ValorInicial, ValorFinal, Valor, EnteConsignante) VALUES (7, 1, '0202', 40000.01, 999999.00, 1313.00, '01')
INSERT FastConsig.dbo.CTCFaixasRCO(Id, Vigencia, TipoContrato, ValorInicial, ValorFinal, Valor, EnteConsignante) VALUES (8, 1, '0202', 0.00, 1000.00, 163.00, '03')
INSERT FastConsig.dbo.CTCFaixasRCO(Id, Vigencia, TipoContrato, ValorInicial, ValorFinal, Valor, EnteConsignante) VALUES (9, 1, '0202', 1000.01, 2000.00, 179.00, '03')
INSERT FastConsig.dbo.CTCFaixasRCO(Id, Vigencia, TipoContrato, ValorInicial, ValorFinal, Valor, EnteConsignante) VALUES (10, 1, '0202', 2000.01, 4000.00, 206.00, '03')
INSERT FastConsig.dbo.CTCFaixasRCO(Id, Vigencia, TipoContrato, ValorInicial, ValorFinal, Valor, EnteConsignante) VALUES (11, 1, '0202', 4000.01, 8000.00, 261.00, '03')
INSERT FastConsig.dbo.CTCFaixasRCO(Id, Vigencia, TipoContrato, ValorInicial, ValorFinal, Valor, EnteConsignante) VALUES (12, 1, '0202', 8000.01, 15000.00, 360.00, '03')
INSERT FastConsig.dbo.CTCFaixasRCO(Id, Vigencia, TipoContrato, ValorInicial, ValorFinal, Valor, EnteConsignante) VALUES (13, 1, '0202', 15000.01, 40000.00, 604.00, '03')
INSERT FastConsig.dbo.CTCFaixasRCO(Id, Vigencia, TipoContrato, ValorInicial, ValorFinal, Valor, EnteConsignante) VALUES (14, 1, '0202', 40000.01, 999999.00, 1553.00, '03')
GO
SET IDENTITY_INSERT FastConsig.dbo.CTCFaixasRCO OFF
GO