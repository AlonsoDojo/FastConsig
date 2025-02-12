CREATE TABLE FastConsig.dbo.CTCMotivoDevolucaoLiquidacaoPortabilidade (
  Id int IDENTITY,
  Codigo varchar(2) NOT NULL,
  Descricao varchar(100) NOT NULL,
  CONSTRAINT PK_CTCMotivoDevolucaoLiquidacaoPortabilidade_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

CREATE UNIQUE INDEX IDX_CTCMotivoDevolucaoLiquidacaoPortabilidade_Codigo
  ON FastConsig.dbo.CTCMotivoDevolucaoLiquidacaoPortabilidade (Codigo)
  ON [PRIMARY]
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

SET IDENTITY_INSERT FastConsig.dbo.CTCMotivoDevolucaoLiquidacaoPortabilidade ON
GO
INSERT FastConsig.dbo.CTCMotivoDevolucaoLiquidacaoPortabilidade(Id, Codigo, Descricao) VALUES (1, '1', 'Conta destinatária do crédito encerrada')
INSERT FastConsig.dbo.CTCMotivoDevolucaoLiquidacaoPortabilidade(Id, Codigo, Descricao) VALUES (2, '2', 'Agência ou conta destinatária do crédito inválida')
INSERT FastConsig.dbo.CTCMotivoDevolucaoLiquidacaoPortabilidade(Id, Codigo, Descricao) VALUES (3, '78', 'Portabilidade não localizada')
INSERT FastConsig.dbo.CTCMotivoDevolucaoLiquidacaoPortabilidade(Id, Codigo, Descricao) VALUES (4, '79', 'Portabilidade recusada por divergência de valor')
INSERT FastConsig.dbo.CTCMotivoDevolucaoLiquidacaoPortabilidade(Id, Codigo, Descricao) VALUES (5, '81', 'Portabilidade retida pela instituição credora original')
INSERT FastConsig.dbo.CTCMotivoDevolucaoLiquidacaoPortabilidade(Id, Codigo, Descricao) VALUES (6, '82', 'Liquidação de portabilidade através de STR0047 efetuada mais de uma vez paa o mesmo NU')
INSERT FastConsig.dbo.CTCMotivoDevolucaoLiquidacaoPortabilidade(Id, Codigo, Descricao) VALUES (7, '83', 'Pagamento em data inválida')
INSERT FastConsig.dbo.CTCMotivoDevolucaoLiquidacaoPortabilidade(Id, Codigo, Descricao) VALUES (8, '84', 'Operação de portabilidade já liquidada pelo credor original')
GO
SET IDENTITY_INSERT FastConsig.dbo.CTCMotivoDevolucaoLiquidacaoPortabilidade OFF
GO