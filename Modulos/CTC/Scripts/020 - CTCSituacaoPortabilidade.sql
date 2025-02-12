CREATE TABLE FastConsig.dbo.CTCSituacaoPortabilidade (
  Id int IDENTITY,
  Codigo varchar(2) NOT NULL,
  Descricao varchar(150) NOT NULL,
  CONSTRAINT PK_CTCSituacaoPortabilidade_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

CREATE UNIQUE INDEX IDX_CTCSituacaoPortabilidade_Codigo
  ON FastConsig.dbo.CTCSituacaoPortabilidade (Codigo)
  ON [PRIMARY]
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

SET IDENTITY_INSERT FastConsig.dbo.CTCSituacaoPortabilidade ON
GO
INSERT FastConsig.dbo.CTCSituacaoPortabilidade(Id, Codigo, Descricao) VALUES (1, '2', 'Solicitada pelo Proponente')
INSERT FastConsig.dbo.CTCSituacaoPortabilidade(Id, Codigo, Descricao) VALUES (2, '3', 'Decurso de prazo por falta de informação do saldo devedor por parte da IF Originadora')
INSERT FastConsig.dbo.CTCSituacaoPortabilidade(Id, Codigo, Descricao) VALUES (3, '4', 'Contrato retido pela Originadora')
INSERT FastConsig.dbo.CTCSituacaoPortabilidade(Id, Codigo, Descricao) VALUES (4, '5', 'Portabilidade Aceita pela Originadora')
INSERT FastConsig.dbo.CTCSituacaoPortabilidade(Id, Codigo, Descricao) VALUES (5, '6', 'Decurso de prazo por STR não paga dentro do prazo')
INSERT FastConsig.dbo.CTCSituacaoPortabilidade(Id, Codigo, Descricao) VALUES (6, '7', 'Cancelada')
INSERT FastConsig.dbo.CTCSituacaoPortabilidade(Id, Codigo, Descricao) VALUES (7, '8', 'Liquidação Financeira Confirmada')
INSERT FastConsig.dbo.CTCSituacaoPortabilidade(Id, Codigo, Descricao) VALUES (8, '9', 'Liquidação Financeira Devolvida')
INSERT FastConsig.dbo.CTCSituacaoPortabilidade(Id, Codigo, Descricao) VALUES (9, '10', 'Decurso de prazo por não efetivação de nova STR após devolução de financeiro não reconhecido por parte da IF Originadora')
INSERT FastConsig.dbo.CTCSituacaoPortabilidade(Id, Codigo, Descricao) VALUES (10, '11', 'Decurso de prazo por não efetivação da portabilidade')
INSERT FastConsig.dbo.CTCSituacaoPortabilidade(Id, Codigo, Descricao) VALUES (11, '12', 'Portada')
INSERT FastConsig.dbo.CTCSituacaoPortabilidade(Id, Codigo, Descricao) VALUES (12, '13', 'Portabilidade Confirmada - Aguardando Transferência da Garantia')
INSERT FastConsig.dbo.CTCSituacaoPortabilidade(Id, Codigo, Descricao) VALUES (13, '14', 'Decurso de prazo por não informação dos dados para transferência de garantia')
INSERT FastConsig.dbo.CTCSituacaoPortabilidade(Id, Codigo, Descricao) VALUES (14, '15', 'Cancelada: Pré-Reserva de Garantia Recusada pelo FGO')
INSERT FastConsig.dbo.CTCSituacaoPortabilidade(Id, Codigo, Descricao) VALUES (15, '99', 'Cancelada pelo Banco Virtual (Uso Exclusivo Homologação Externa)')
GO
SET IDENTITY_INSERT FastConsig.dbo.CTCSituacaoPortabilidade OFF
GO