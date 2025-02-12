CREATE TABLE FastConsig.dbo.Ocorrencias (
  Id int IDENTITY,
  Descricao varchar(120) NOT NULL,
  PermiteLiberacaoComplemento bit NULL,
  Pendencia bit NULL,
  Recusa bit NULL,
  Informativa bit NULL,
  CONSTRAINT PK_Ocorrencias PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

SET IDENTITY_INSERT FastConsig.dbo.Ocorrencias ON
GO
INSERT FastConsig.dbo.Ocorrencias(Id, Descricao, PermiteLiberacaoComplemento, Pendencia, Recusa, Informativa, Sistema) VALUES (1, 'Proposta Rejeitada', CONVERT(bit, 'False'), CONVERT(bit, 'False'), CONVERT(bit, 'True'), CONVERT(bit, 'False'), CONVERT(bit, 'True'))
INSERT FastConsig.dbo.Ocorrencias(Id, Descricao, PermiteLiberacaoComplemento, Pendencia, Recusa, Informativa, Sistema) VALUES (2, 'Ocorrência Teste Pendência', CONVERT(bit, 'False'), CONVERT(bit, 'False'), CONVERT(bit, 'False'), CONVERT(bit, 'True'), CONVERT(bit, 'False'))
INSERT FastConsig.dbo.Ocorrencias(Id, Descricao, PermiteLiberacaoComplemento, Pendencia, Recusa, Informativa, Sistema) VALUES (3, 'Pendência Genérica de Retorno a Mesa Promotora', CONVERT(bit, 'False'), CONVERT(bit, 'True'), CONVERT(bit, 'False'), CONVERT(bit, 'False'), CONVERT(bit, 'False'))
GO
SET IDENTITY_INSERT FastConsig.dbo.Ocorrencias OFF
GO