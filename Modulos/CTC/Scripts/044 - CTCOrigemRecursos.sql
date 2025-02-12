CREATE TABLE FastConsig.dbo.CTCOrigemRecursos (
  Id int IDENTITY,
  Codigo varchar(4) NULL,
  Descricao varchar(150) NULL,
  CONSTRAINT PK_CTCOrigemRecursos_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

CREATE UNIQUE INDEX IDX_CTCOrigemRecursos_Codigo
  ON FastConsig.dbo.CTCOrigemRecursos (Codigo)
  ON [PRIMARY]
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

SET IDENTITY_INSERT FastConsig.dbo.CTCOrigemRecursos ON
GO
INSERT FastConsig.dbo.CTCOrigemRecursos(Id, Codigo, Descricao) VALUES (1, '0207', 'Fundos estaduais ou distritais')
INSERT FastConsig.dbo.CTCOrigemRecursos(Id, Codigo, Descricao) VALUES (2, '0208', 'Recursos captados em depósitos de poupança pelas entidades integrantes do SBPE destinados às operações de financiamento imobiliário')
INSERT FastConsig.dbo.CTCOrigemRecursos(Id, Codigo, Descricao) VALUES (3, '0212', 'Fundos ou programas especiais do governo federal')
INSERT FastConsig.dbo.CTCOrigemRecursos(Id, Codigo, Descricao) VALUES (4, '0213', 'FGTS – Fundo de Garantia do Tempo de Serviço')
GO
SET IDENTITY_INSERT FastConsig.dbo.CTCOrigemRecursos OFF
GO