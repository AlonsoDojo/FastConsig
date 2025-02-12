CREATE TABLE FastConsig.dbo.Estados (
  Id char(2) NOT NULL,
  Nome varchar(50) NULL,
  CONSTRAINT PK_Estados PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

INSERT FastConsig.dbo.Estados(Id, Nome) VALUES (N'AC', 'Acre')
INSERT FastConsig.dbo.Estados(Id, Nome) VALUES (N'AL', 'Alagoas')
INSERT FastConsig.dbo.Estados(Id, Nome) VALUES (N'AM', 'Amazonas')
INSERT FastConsig.dbo.Estados(Id, Nome) VALUES (N'AP', 'Amapá')
INSERT FastConsig.dbo.Estados(Id, Nome) VALUES (N'BA', 'Bahia')
INSERT FastConsig.dbo.Estados(Id, Nome) VALUES (N'CE', 'Ceará')
INSERT FastConsig.dbo.Estados(Id, Nome) VALUES (N'DF', 'Distrito Federal')
INSERT FastConsig.dbo.Estados(Id, Nome) VALUES (N'ES', 'Espírito Santo')
INSERT FastConsig.dbo.Estados(Id, Nome) VALUES (N'GO', 'Goiás')
INSERT FastConsig.dbo.Estados(Id, Nome) VALUES (N'MA', 'Maranhão')
INSERT FastConsig.dbo.Estados(Id, Nome) VALUES (N'MG', 'Minas Gerais')
INSERT FastConsig.dbo.Estados(Id, Nome) VALUES (N'MS', 'Mato Grosso do Sul')
INSERT FastConsig.dbo.Estados(Id, Nome) VALUES (N'MT', 'Mato Grosso')
INSERT FastConsig.dbo.Estados(Id, Nome) VALUES (N'PA', 'Pará')
INSERT FastConsig.dbo.Estados(Id, Nome) VALUES (N'PB', 'Paraíba')
INSERT FastConsig.dbo.Estados(Id, Nome) VALUES (N'PE', 'Pernambuco')
INSERT FastConsig.dbo.Estados(Id, Nome) VALUES (N'PI', 'Piauí')
INSERT FastConsig.dbo.Estados(Id, Nome) VALUES (N'PR', 'Paraná')
INSERT FastConsig.dbo.Estados(Id, Nome) VALUES (N'RJ', 'Rio de Janeiro')
INSERT FastConsig.dbo.Estados(Id, Nome) VALUES (N'RN', 'Rio Grande do Norte')
INSERT FastConsig.dbo.Estados(Id, Nome) VALUES (N'RO', 'Rondônia')
INSERT FastConsig.dbo.Estados(Id, Nome) VALUES (N'RR', 'Roraima')
INSERT FastConsig.dbo.Estados(Id, Nome) VALUES (N'RS', 'Rio Grande do Sul')
INSERT FastConsig.dbo.Estados(Id, Nome) VALUES (N'SC', 'Santa Catarina')
INSERT FastConsig.dbo.Estados(Id, Nome) VALUES (N'SE', 'Sergipe')
INSERT FastConsig.dbo.Estados(Id, Nome) VALUES (N'SP', 'São Paulo')
INSERT FastConsig.dbo.Estados(Id, Nome) VALUES (N'TO', 'Tocantins')
GO
