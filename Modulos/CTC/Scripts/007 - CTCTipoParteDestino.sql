CREATE TABLE FastConsig.dbo.CTCTipoParteDestino (
  Id int IDENTITY,
  Descricao varchar(50) NOT NULL,
  ISPB varchar(8) NULL,
  CONSTRAINT PK_CTCTipoParte_Id_copy PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

SET IDENTITY_INSERT FastConsig.dbo.CTCTipoParteDestino ON
GO
INSERT FastConsig.dbo.CTCTipoParteDestino(Id, Descricao, ISPB) VALUES (1, 'CTC', '02992335')
INSERT FastConsig.dbo.CTCTipoParteDestino(Id, Descricao, ISPB) VALUES (2, 'Originadora', '61820817')
INSERT FastConsig.dbo.CTCTipoParteDestino(Id, Descricao, ISPB) VALUES (3, 'Proponente', NULL)
INSERT FastConsig.dbo.CTCTipoParteDestino(Id, Descricao, ISPB) VALUES (4, 'Todos', '61820817')
GO
SET IDENTITY_INSERT FastConsig.dbo.CTCTipoParteDestino OFF
GO