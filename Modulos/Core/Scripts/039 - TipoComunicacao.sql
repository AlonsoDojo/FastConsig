CREATE TABLE FastConsig.dbo.TipoComunicacao (
  Id int IDENTITY,
  SMS bit NULL,
  EMail bit NULL,
  Whatsapp bit NULL,
  Fisico bit NULL,
  CONSTRAINT PK_TipoComunicacao_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

SET IDENTITY_INSERT FastConsig.dbo.TipoComunicacao ON
GO
INSERT FastConsig.dbo.TipoComunicacao(Id, SMS, EMail, Whatsapp, Fisico) VALUES (1, CONVERT(bit, 'True'), CONVERT(bit, 'False'), CONVERT(bit, 'False'), CONVERT(bit, 'False'))
INSERT FastConsig.dbo.TipoComunicacao(Id, SMS, EMail, Whatsapp, Fisico) VALUES (2, CONVERT(bit, 'False'), CONVERT(bit, 'False'), CONVERT(bit, 'True'), CONVERT(bit, 'False'))
GO
SET IDENTITY_INSERT FastConsig.dbo.TipoComunicacao OFF
GO