CREATE TABLE FastConsig.dbo.MeioLiberacao (
  Id int IDENTITY,
  Descricao varchar(50) NOT NULL,
  Banco bit NULL,
  Agencia bit NULL,
  Conta bit NULL,
  Chave bit NULL,
  Ativo bit NULL,
  CONSTRAINT PK_MeioLiberacao_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

SET IDENTITY_INSERT FastConsig.dbo.MeioLiberacao ON
GO
INSERT FastConsig.dbo.MeioLiberacao(Id, Descricao, Banco, Agencia, Conta, Chave, Ativo) VALUES (1, 'TED', CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'False'), CONVERT(bit, 'True'))
INSERT FastConsig.dbo.MeioLiberacao(Id, Descricao, Banco, Agencia, Conta, Chave, Ativo) VALUES (2, 'PIX', CONVERT(bit, 'False'), CONVERT(bit, 'False'), CONVERT(bit, 'False'), CONVERT(bit, 'True'), CONVERT(bit, 'True'))
GO
SET IDENTITY_INSERT FastConsig.dbo.MeioLiberacao OFF
GO