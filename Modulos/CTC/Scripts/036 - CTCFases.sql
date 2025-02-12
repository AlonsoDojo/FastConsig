CREATE TABLE FastConsig.dbo.CTCFases (
  Id int IDENTITY,
  Descricao varchar(50) NOT NULL,
  CONSTRAINT PK_CTCFases_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

SET IDENTITY_INSERT FastConsig.dbo.CTCFases ON
GO
INSERT FastConsig.dbo.CTCFases(Id, Descricao) VALUES (1, 'Recepção')
INSERT FastConsig.dbo.CTCFases(Id, Descricao) VALUES (2, 'Resposta')
INSERT FastConsig.dbo.CTCFases(Id, Descricao) VALUES (3, 'Aceitação')
INSERT FastConsig.dbo.CTCFases(Id, Descricao) VALUES (4, 'Retenção')
INSERT FastConsig.dbo.CTCFases(Id, Descricao) VALUES (5, 'Pagamento')
INSERT FastConsig.dbo.CTCFases(Id, Descricao) VALUES (6, 'Cancelamento')
GO
SET IDENTITY_INSERT FastConsig.dbo.CTCFases OFF
GO