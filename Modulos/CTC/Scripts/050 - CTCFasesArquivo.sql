CREATE TABLE FastConsig.dbo.CTCFasesArquivo (
  Id int IDENTITY,
  Arquivo int NOT NULL,
  Fase int NOT NULL,
  Ordem int NOT NULL,
  CONSTRAINT PK_CTCFasesArquivo_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.CTCFasesArquivo
  ADD CONSTRAINT FK_CTCFasesArquivo_Arquivo FOREIGN KEY (Arquivo) REFERENCES dbo.CTCDominioArquivo (Id)
GO

ALTER TABLE FastConsig.dbo.CTCFasesArquivo
  ADD CONSTRAINT FK_CTCFasesArquivo_Fase FOREIGN KEY (Fase) REFERENCES dbo.CTCFases (Id)
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

SET IDENTITY_INSERT FastConsig.dbo.CTCFasesArquivo ON
GO
INSERT FastConsig.dbo.CTCFasesArquivo(Id, Arquivo, Fase, Ordem) VALUES (1, 4, 1, 0)
INSERT FastConsig.dbo.CTCFasesArquivo(Id, Arquivo, Fase, Ordem) VALUES (2, 4, 2, 1)
INSERT FastConsig.dbo.CTCFasesArquivo(Id, Arquivo, Fase, Ordem) VALUES (3, 4, 3, 2)
INSERT FastConsig.dbo.CTCFasesArquivo(Id, Arquivo, Fase, Ordem) VALUES (4, 4, 4, 3)
GO
SET IDENTITY_INSERT FastConsig.dbo.CTCFasesArquivo OFF
GO