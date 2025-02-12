CREATE TABLE FastConsig.dbo.CTCIndicadorRemuneracao (
  Id int IDENTITY,
  Codigo varchar(2) NOT NULL,
  Descricao varchar(50) NOT NULL,
  CONSTRAINT PK_CTCIndicadorRemuneracao_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

CREATE UNIQUE INDEX IDX_CTCIndicadorRemuneracao_Codigo
  ON FastConsig.dbo.CTCIndicadorRemuneracao (Codigo)
  ON [PRIMARY]
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

SET IDENTITY_INSERT FastConsig.dbo.CTCIndicadorRemuneracao ON
GO
INSERT FastConsig.dbo.CTCIndicadorRemuneracao(Id, Codigo, Descricao) VALUES (1, '01', 'ITRD')
INSERT FastConsig.dbo.CTCIndicadorRemuneracao(Id, Codigo, Descricao) VALUES (2, '02', 'IDTR')
INSERT FastConsig.dbo.CTCIndicadorRemuneracao(Id, Codigo, Descricao) VALUES (3, '03', 'UFIR Diaria')
INSERT FastConsig.dbo.CTCIndicadorRemuneracao(Id, Codigo, Descricao) VALUES (4, '04', 'UFIRM Mensal')
INSERT FastConsig.dbo.CTCIndicadorRemuneracao(Id, Codigo, Descricao) VALUES (5, '05', 'FAJ-TR')
INSERT FastConsig.dbo.CTCIndicadorRemuneracao(Id, Codigo, Descricao) VALUES (6, '06', 'TR')
INSERT FastConsig.dbo.CTCIndicadorRemuneracao(Id, Codigo, Descricao) VALUES (7, '07', 'IGPM')
INSERT FastConsig.dbo.CTCIndicadorRemuneracao(Id, Codigo, Descricao) VALUES (8, '08', 'CDI')
INSERT FastConsig.dbo.CTCIndicadorRemuneracao(Id, Codigo, Descricao) VALUES (9, '09', 'Percentual do CDI')
INSERT FastConsig.dbo.CTCIndicadorRemuneracao(Id, Codigo, Descricao) VALUES (10, '10', 'SELIC')
INSERT FastConsig.dbo.CTCIndicadorRemuneracao(Id, Codigo, Descricao) VALUES (11, '99', 'Outros')
INSERT FastConsig.dbo.CTCIndicadorRemuneracao(Id, Codigo, Descricao) VALUES (12, '1', 'ITRD')
INSERT FastConsig.dbo.CTCIndicadorRemuneracao(Id, Codigo, Descricao) VALUES (13, '2', 'IDTR')
INSERT FastConsig.dbo.CTCIndicadorRemuneracao(Id, Codigo, Descricao) VALUES (14, '3', 'UFIR Diaria')
INSERT FastConsig.dbo.CTCIndicadorRemuneracao(Id, Codigo, Descricao) VALUES (15, '4', 'UFIRM Mensal')
INSERT FastConsig.dbo.CTCIndicadorRemuneracao(Id, Codigo, Descricao) VALUES (16, '5', 'FAJ-TR')
INSERT FastConsig.dbo.CTCIndicadorRemuneracao(Id, Codigo, Descricao) VALUES (17, '6', 'TR')
INSERT FastConsig.dbo.CTCIndicadorRemuneracao(Id, Codigo, Descricao) VALUES (18, '7', 'IGPM')
INSERT FastConsig.dbo.CTCIndicadorRemuneracao(Id, Codigo, Descricao) VALUES (19, '8', 'CDI')
INSERT FastConsig.dbo.CTCIndicadorRemuneracao(Id, Codigo, Descricao) VALUES (20, '9', 'Percentual do CDI')
GO
SET IDENTITY_INSERT FastConsig.dbo.CTCIndicadorRemuneracao OFF
GO