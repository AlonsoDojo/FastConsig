CREATE TABLE FastConsig.dbo.CTCContaConjutaSolidaria (
  Id int IDENTITY,
  Codigo varchar(1) NOT NULL,
  Descricao varchar(50) NOT NULL,
  CONSTRAINT PK_CTCContaConjutaSolidaria_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

CREATE UNIQUE INDEX IDX_CTCContaConjutaSolidaria_Codigo
  ON FastConsig.dbo.CTCContaConjutaSolidaria (Codigo)
  ON [PRIMARY]
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

SET IDENTITY_INSERT FastConsig.dbo.CTCContaConjutaSolidaria ON
GO
INSERT FastConsig.dbo.CTCContaConjutaSolidaria(Id, Codigo, Descricao) VALUES (1, 'S', 'Sim')
INSERT FastConsig.dbo.CTCContaConjutaSolidaria(Id, Codigo, Descricao) VALUES (2, 'N', 'Não')
GO
SET IDENTITY_INSERT FastConsig.dbo.CTCContaConjutaSolidaria OFF
GO