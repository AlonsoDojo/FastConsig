CREATE TABLE FastConsig.dbo.CTCEventoTarifa (
  Id int IDENTITY,
  Codigo varchar(4) NOT NULL,
  Descricao varchar(100) NOT NULL,
  CONSTRAINT PK_CTCEventoTarifa_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

CREATE UNIQUE INDEX IDX_CTCEventoTarifa_Codigo
  ON FastConsig.dbo.CTCEventoTarifa (Codigo)
  ON [PRIMARY]
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

SET IDENTITY_INSERT FastConsig.dbo.CTCEventoTarifa ON
GO
INSERT FastConsig.dbo.CTCEventoTarifa(Id, Codigo, Descricao) VALUES (1, '0001', 'Tarifa por Solicitação de Portabilidade')
INSERT FastConsig.dbo.CTCEventoTarifa(Id, Codigo, Descricao) VALUES (2, '0002', 'Tarifa por não responder dentro do prazo legal')
INSERT FastConsig.dbo.CTCEventoTarifa(Id, Codigo, Descricao) VALUES (3, '0003', 'Desistência de portabilidade por parte do proponente')
INSERT FastConsig.dbo.CTCEventoTarifa(Id, Codigo, Descricao) VALUES (4, '0004', 'Mensalidade')
GO
SET IDENTITY_INSERT FastConsig.dbo.CTCEventoTarifa OFF
GO