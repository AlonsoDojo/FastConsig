CREATE TABLE FastConsig.dbo.CTCTipoArquivoEnviado (
  Id int IDENTITY,
  Codigo varchar(1) NOT NULL,
  Descricao varchar(50) NOT NULL,
  CONSTRAINT PK_CTCTipoArquivoEnviado_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

CREATE UNIQUE INDEX UK_CTCTipoArquivoEnviado_Codigo
  ON FastConsig.dbo.CTCTipoArquivoEnviado (Codigo)
  ON [PRIMARY]
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

SET IDENTITY_INSERT FastConsig.dbo.CTCTipoArquivoEnviado ON
GO
INSERT FastConsig.dbo.CTCTipoArquivoEnviado(Id, Codigo, Descricao) VALUES (1, '1', 'PRO')
INSERT FastConsig.dbo.CTCTipoArquivoEnviado(Id, Codigo, Descricao) VALUES (2, '2', 'RET')
INSERT FastConsig.dbo.CTCTipoArquivoEnviado(Id, Codigo, Descricao) VALUES (3, '3', 'ERR')
INSERT FastConsig.dbo.CTCTipoArquivoEnviado(Id, Codigo, Descricao) VALUES (4, '4', 'Varredura')
GO
SET IDENTITY_INSERT FastConsig.dbo.CTCTipoArquivoEnviado OFF
GO