CREATE TABLE FastConsig.dbo.CTCOcorrencia (
  Id int IDENTITY,
  Descricao varchar(250) NOT NULL,
  Visivel bit NULL,
  Sistema bit NULL,
  CONSTRAINT PK_CTCOcorrencia_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

SET IDENTITY_INSERT FastConsig.dbo.CTCOcorrencia ON
GO
INSERT FastConsig.dbo.CTCOcorrencia(Id, Descricao, Visivel, Sistema) VALUES (1, 'Portabilidade Recebida', CONVERT(bit, 'False'), CONVERT(bit, 'True'))
INSERT FastConsig.dbo.CTCOcorrencia(Id, Descricao, Visivel, Sistema) VALUES (2, 'Cliente não Localizado no Originador', CONVERT(bit, 'False'), CONVERT(bit, 'True'))
INSERT FastConsig.dbo.CTCOcorrencia(Id, Descricao, Visivel, Sistema) VALUES (3, 'Contrato não Localizado no Originador', CONVERT(bit, 'False'), CONVERT(bit, 'True'))
INSERT FastConsig.dbo.CTCOcorrencia(Id, Descricao, Visivel, Sistema) VALUES (4, 'Cálculo da Posição do Originador', CONVERT(bit, 'False'), CONVERT(bit, 'True'))
INSERT FastConsig.dbo.CTCOcorrencia(Id, Descricao, Visivel, Sistema) VALUES (5, 'Produto de Retenção não Localizado', CONVERT(bit, 'False'), CONVERT(bit, 'True'))
INSERT FastConsig.dbo.CTCOcorrencia(Id, Descricao, Visivel, Sistema) VALUES (6, 'Portabilidade Aceita', CONVERT(bit, 'False'), CONVERT(bit, 'True'))
INSERT FastConsig.dbo.CTCOcorrencia(Id, Descricao, Visivel, Sistema) VALUES (7, 'Portabilidade Retida', CONVERT(bit, 'False'), CONVERT(bit, 'True'))
INSERT FastConsig.dbo.CTCOcorrencia(Id, Descricao, Visivel, Sistema) VALUES (8, 'Pagamento Confirmado', CONVERT(bit, 'False'), CONVERT(bit, 'True'))
INSERT FastConsig.dbo.CTCOcorrencia(Id, Descricao, Visivel, Sistema) VALUES (9, 'Cancelamento da Portabilidade', CONVERT(bit, 'False'), CONVERT(bit, 'True'))
INSERT FastConsig.dbo.CTCOcorrencia(Id, Descricao, Visivel, Sistema) VALUES (10, 'Contrato não é de Titularidade do Banco Paulista', CONVERT(bit, 'False'), CONVERT(bit, 'True'))
INSERT FastConsig.dbo.CTCOcorrencia(Id, Descricao, Visivel, Sistema) VALUES (11, 'Contrato Liquidado', CONVERT(bit, 'False'), CONVERT(bit, 'True'))
GO
SET IDENTITY_INSERT FastConsig.dbo.CTCOcorrencia OFF
GO