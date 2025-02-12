CREATE TABLE FastConsig.dbo.CTCFluxoPagamento (
  Id int IDENTITY,
  Codigo varchar(1) NOT NULL,
  Descricao varchar(50) NOT NULL,
  CONSTRAINT PK_CTCFluxoPagamento_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

CREATE UNIQUE INDEX IDX_CTCFluxoPagamento_Codigo
  ON FastConsig.dbo.CTCFluxoPagamento (Codigo)
  ON [PRIMARY]
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

SET IDENTITY_INSERT FastConsig.dbo.CTCFluxoPagamento ON
GO
INSERT FastConsig.dbo.CTCFluxoPagamento(Id, Codigo, Descricao) VALUES (1, 'N', 'Normal')
INSERT FastConsig.dbo.CTCFluxoPagamento(Id, Codigo, Descricao) VALUES (2, 'I', 'Irregular')
INSERT FastConsig.dbo.CTCFluxoPagamento(Id, Codigo, Descricao) VALUES (3, 'A', 'Ambos')
GO
SET IDENTITY_INSERT FastConsig.dbo.CTCFluxoPagamento OFF
GO