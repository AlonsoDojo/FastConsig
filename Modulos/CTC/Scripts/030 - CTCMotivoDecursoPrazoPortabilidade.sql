CREATE TABLE FastConsig.dbo.CTCMotivoDecursoPrazoPortabilidade (
  Id int IDENTITY,
  Codigo varchar(3) NOT NULL,
  Descricao varchar(150) NOT NULL,
  CONSTRAINT PK_CTCMotivoDecursoPrazoPortabilidade_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

CREATE UNIQUE INDEX IDX_CTCMotivoDecursoPrazoPortabilidade_Codigo
  ON FastConsig.dbo.CTCMotivoDecursoPrazoPortabilidade (Codigo)
  ON [PRIMARY]
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

SET IDENTITY_INSERT FastConsig.dbo.CTCMotivoDecursoPrazoPortabilidade ON
GO
INSERT FastConsig.dbo.CTCMotivoDecursoPrazoPortabilidade(Id, Codigo, Descricao) VALUES (1, '4', 'Decurso de prazo por falta de informação do saldo devedor por parte da IF Originadora')
INSERT FastConsig.dbo.CTCMotivoDecursoPrazoPortabilidade(Id, Codigo, Descricao) VALUES (2, '5', 'Decurso de prazo por não efetivação de nova STR após devolução de financeiro não reconhecido por parte da IF Originadora')
INSERT FastConsig.dbo.CTCMotivoDecursoPrazoPortabilidade(Id, Codigo, Descricao) VALUES (3, '6', 'Decurso de prazo por STR não paga dentro do prazo')
INSERT FastConsig.dbo.CTCMotivoDecursoPrazoPortabilidade(Id, Codigo, Descricao) VALUES (4, '9', 'Decurso de prazo por não efetivação da portabilidade')
INSERT FastConsig.dbo.CTCMotivoDecursoPrazoPortabilidade(Id, Codigo, Descricao) VALUES (5, '10', 'Decurso de Prazo por não informar dados para transferência de garantia')
GO
SET IDENTITY_INSERT FastConsig.dbo.CTCMotivoDecursoPrazoPortabilidade OFF
GO