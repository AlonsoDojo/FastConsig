CREATE TABLE FastConsig.dbo.CTCFasesFluxo (
  Id int NOT NULL,
  TipoArquivo int NOT NULL,
  TipoFluxo int NOT NULL,
  Fase int NOT NULL,
  Status varchar(50) NOT NULL,
  Ordem int NOT NULL,
  CONSTRAINT PK_CTCFasesFluxo_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.CTCFasesFluxo
  ADD CONSTRAINT FK_CTCFasesFluxo_Fase FOREIGN KEY (Fase) REFERENCES dbo.CTCFases (Id)
GO

ALTER TABLE FastConsig.dbo.CTCFasesFluxo
  ADD CONSTRAINT FK_CTCFasesFluxo_TipoArquivo FOREIGN KEY (TipoArquivo) REFERENCES dbo.CTCDominioArquivo (Id)
GO

ALTER TABLE FastConsig.dbo.CTCFasesFluxo
  ADD CONSTRAINT FK_CTCFasesFluxo_TipoFluxo FOREIGN KEY (TipoFluxo) REFERENCES dbo.CTCTipoFluxo (Id)
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

INSERT FastConsig.dbo.CTCFasesFluxo(Id, TipoArquivo, TipoFluxo, Fase, Status, Ordem) VALUES (1, 4, 1, 1, 'AGUARDANDO', 0)
INSERT FastConsig.dbo.CTCFasesFluxo(Id, TipoArquivo, TipoFluxo, Fase, Status, Ordem) VALUES (2, 4, 1, 2, 'AGUARDANDO', 1)
INSERT FastConsig.dbo.CTCFasesFluxo(Id, TipoArquivo, TipoFluxo, Fase, Status, Ordem) VALUES (3, 4, 3, 2, 'AGUARDANDO', 0)
INSERT FastConsig.dbo.CTCFasesFluxo(Id, TipoArquivo, TipoFluxo, Fase, Status, Ordem) VALUES (4, 4, 3, 3, 'AGUARDANDO', 1)
INSERT FastConsig.dbo.CTCFasesFluxo(Id, TipoArquivo, TipoFluxo, Fase, Status, Ordem) VALUES (5, 4, 5, 2, 'AGUARDANDO', 0)
INSERT FastConsig.dbo.CTCFasesFluxo(Id, TipoArquivo, TipoFluxo, Fase, Status, Ordem) VALUES (6, 4, 5, 5, 'AGUARDANDO', 1)
INSERT FastConsig.dbo.CTCFasesFluxo(Id, TipoArquivo, TipoFluxo, Fase, Status, Ordem) VALUES (7, 4, 4, 2, 'AGUARDANDO', 0)
INSERT FastConsig.dbo.CTCFasesFluxo(Id, TipoArquivo, TipoFluxo, Fase, Status, Ordem) VALUES (8, 4, 4, 4, 'AGUARDANDO', 1)
INSERT FastConsig.dbo.CTCFasesFluxo(Id, TipoArquivo, TipoFluxo, Fase, Status, Ordem) VALUES (9, 4, 6, 5, 'AGUARDANDO PAGAMENTO', 0)
INSERT FastConsig.dbo.CTCFasesFluxo(Id, TipoArquivo, TipoFluxo, Fase, Status, Ordem) VALUES (10, 4, 6, 6, 'AGUARDANDO', 1)
GO