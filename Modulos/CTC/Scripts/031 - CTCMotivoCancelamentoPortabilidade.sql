CREATE TABLE FastConsig.dbo.CTCMotivoCancelamentoPortabilidade (
  Id int IDENTITY,
  Codigo varchar(3) NOT NULL,
  Descricao varchar(150) NOT NULL,
  Consignado bit NULL,
  CreditoImobiliario bit NULL,
  CreditoPessoal bit NULL,
  FinancimentoVeiculo bit NULL,
  OutrosCreditos bit NULL,
  ChequeEspecial bit NULL,
  AdiantamentoDepositante bit NULL,
  CapitalGiro bit NULL,
  Pronampe bit NULL,
  CONSTRAINT PK_CTCMotivoCancelamentoPortabilidade_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

CREATE UNIQUE INDEX IDX_CTCMotivoCancelamentoPortabilidade_Codigo
  ON FastConsig.dbo.CTCMotivoCancelamentoPortabilidade (Codigo)
  ON [PRIMARY]
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

SET IDENTITY_INSERT FastConsig.dbo.CTCMotivoCancelamentoPortabilidade ON
GO
INSERT FastConsig.dbo.CTCMotivoCancelamentoPortabilidade(Id, Codigo, Descricao, Consignado, CreditoImobiliario, CreditoPessoal, FinancimentoVeiculo, OutrosCreditos, ChequeEspecial, AdiantamentoDepositante, CapitalGiro, Pronampe) VALUES (1, '1', 'Desistência do devedor', CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'))
INSERT FastConsig.dbo.CTCMotivoCancelamentoPortabilidade(Id, Codigo, Descricao, Consignado, CreditoImobiliario, CreditoPessoal, FinancimentoVeiculo, OutrosCreditos, ChequeEspecial, AdiantamentoDepositante, CapitalGiro, Pronampe) VALUES (2, '2', 'Por motivos de política de crédito', CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'))
INSERT FastConsig.dbo.CTCMotivoCancelamentoPortabilidade(Id, Codigo, Descricao, Consignado, CreditoImobiliario, CreditoPessoal, FinancimentoVeiculo, OutrosCreditos, ChequeEspecial, AdiantamentoDepositante, CapitalGiro, Pronampe) VALUES (3, '3', 'Sobreposição de novo pedido de Portabilidade', CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'))
INSERT FastConsig.dbo.CTCMotivoCancelamentoPortabilidade(Id, Codigo, Descricao, Consignado, CreditoImobiliario, CreditoPessoal, FinancimentoVeiculo, OutrosCreditos, ChequeEspecial, AdiantamentoDepositante, CapitalGiro, Pronampe) VALUES (4, '4', 'Decurso de prazo por falta de informação do saldo devedor por parte da IF Originadora', CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'))
INSERT FastConsig.dbo.CTCMotivoCancelamentoPortabilidade(Id, Codigo, Descricao, Consignado, CreditoImobiliario, CreditoPessoal, FinancimentoVeiculo, OutrosCreditos, ChequeEspecial, AdiantamentoDepositante, CapitalGiro, Pronampe) VALUES (5, '5', 'Decurso de prazo por não efetivação de nova STR após devolução de financeiro não reconhecido por parte da IF Originadora', CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'))
INSERT FastConsig.dbo.CTCMotivoCancelamentoPortabilidade(Id, Codigo, Descricao, Consignado, CreditoImobiliario, CreditoPessoal, FinancimentoVeiculo, OutrosCreditos, ChequeEspecial, AdiantamentoDepositante, CapitalGiro, Pronampe) VALUES (6, '6', 'Decurso de prazo por STR não paga dentro do prazo', CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'))
INSERT FastConsig.dbo.CTCMotivoCancelamentoPortabilidade(Id, Codigo, Descricao, Consignado, CreditoImobiliario, CreditoPessoal, FinancimentoVeiculo, OutrosCreditos, ChequeEspecial, AdiantamentoDepositante, CapitalGiro, Pronampe) VALUES (7, '7', 'Divergência de valor ou STR não paga dentro do prazo', CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'))
INSERT FastConsig.dbo.CTCMotivoCancelamentoPortabilidade(Id, Codigo, Descricao, Consignado, CreditoImobiliario, CreditoPessoal, FinancimentoVeiculo, OutrosCreditos, ChequeEspecial, AdiantamentoDepositante, CapitalGiro, Pronampe) VALUES (8, '8', 'Portabilidade não localizada', CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'))
INSERT FastConsig.dbo.CTCMotivoCancelamentoPortabilidade(Id, Codigo, Descricao, Consignado, CreditoImobiliario, CreditoPessoal, FinancimentoVeiculo, OutrosCreditos, ChequeEspecial, AdiantamentoDepositante, CapitalGiro, Pronampe) VALUES (9, '9', 'Decurso de prazo por não efetivação da portabilidade', CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'))
INSERT FastConsig.dbo.CTCMotivoCancelamentoPortabilidade(Id, Codigo, Descricao, Consignado, CreditoImobiliario, CreditoPessoal, FinancimentoVeiculo, OutrosCreditos, ChequeEspecial, AdiantamentoDepositante, CapitalGiro, Pronampe) VALUES (10, '10', 'Portabilidade cancelada por falta de liquidação', CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'), CONVERT(bit, 'True'))
INSERT FastConsig.dbo.CTCMotivoCancelamentoPortabilidade(Id, Codigo, Descricao, Consignado, CreditoImobiliario, CreditoPessoal, FinancimentoVeiculo, OutrosCreditos, ChequeEspecial, AdiantamentoDepositante, CapitalGiro, Pronampe) VALUES (11, '11', 'Saldo devedor superior ao valor máximo de cobertura (Cheque Especial)', CONVERT(bit, 'False'), CONVERT(bit, 'False'), CONVERT(bit, 'False'), CONVERT(bit, 'False'), CONVERT(bit, 'False'), CONVERT(bit, 'True'), CONVERT(bit, 'False'), CONVERT(bit, 'False'), CONVERT(bit, 'False'))
INSERT FastConsig.dbo.CTCMotivoCancelamentoPortabilidade(Id, Codigo, Descricao, Consignado, CreditoImobiliario, CreditoPessoal, FinancimentoVeiculo, OutrosCreditos, ChequeEspecial, AdiantamentoDepositante, CapitalGiro, Pronampe) VALUES (12, '12', 'Cheque Especial sem saldo devedor (Cheque Especial)', CONVERT(bit, 'False'), CONVERT(bit, 'False'), CONVERT(bit, 'False'), CONVERT(bit, 'False'), CONVERT(bit, 'False'), CONVERT(bit, 'True'), CONVERT(bit, 'False'), CONVERT(bit, 'False'), CONVERT(bit, 'False'))
INSERT FastConsig.dbo.CTCMotivoCancelamentoPortabilidade(Id, Codigo, Descricao, Consignado, CreditoImobiliario, CreditoPessoal, FinancimentoVeiculo, OutrosCreditos, ChequeEspecial, AdiantamentoDepositante, CapitalGiro, Pronampe) VALUES (13, '13', 'Cancelada: Pré-Reserva de Garantia Recusada pelo FGO', CONVERT(bit, 'False'), CONVERT(bit, 'True'), CONVERT(bit, 'False'), CONVERT(bit, 'True'), CONVERT(bit, 'False'), CONVERT(bit, 'False'), CONVERT(bit, 'False'), CONVERT(bit, 'False'), CONVERT(bit, 'False'))
INSERT FastConsig.dbo.CTCMotivoCancelamentoPortabilidade(Id, Codigo, Descricao, Consignado, CreditoImobiliario, CreditoPessoal, FinancimentoVeiculo, OutrosCreditos, ChequeEspecial, AdiantamentoDepositante, CapitalGiro, Pronampe) VALUES (14, '14', 'Cancelada: Efetivação da Transferência de Garantia Recusada pelo  FGO', CONVERT(bit, 'False'), CONVERT(bit, 'True'), CONVERT(bit, 'False'), CONVERT(bit, 'True'), CONVERT(bit, 'False'), CONVERT(bit, 'False'), CONVERT(bit, 'False'), CONVERT(bit, 'False'), CONVERT(bit, 'False'))
INSERT FastConsig.dbo.CTCMotivoCancelamentoPortabilidade(Id, Codigo, Descricao, Consignado, CreditoImobiliario, CreditoPessoal, FinancimentoVeiculo, OutrosCreditos, ChequeEspecial, AdiantamentoDepositante, CapitalGiro, Pronampe) VALUES (15, '15', 'Decurso de Prazo por não informar dados para transferência de garantia', CONVERT(bit, 'False'), CONVERT(bit, 'True'), CONVERT(bit, 'False'), CONVERT(bit, 'True'), CONVERT(bit, 'False'), CONVERT(bit, 'False'), CONVERT(bit, 'False'), CONVERT(bit, 'False'), CONVERT(bit, 'True'))
INSERT FastConsig.dbo.CTCMotivoCancelamentoPortabilidade(Id, Codigo, Descricao, Consignado, CreditoImobiliario, CreditoPessoal, FinancimentoVeiculo, OutrosCreditos, ChequeEspecial, AdiantamentoDepositante, CapitalGiro, Pronampe) VALUES (16, '16', 'Decurso de prazo por falta de informação do saldo devedor por parte da IF Originadora (Pronampe)', CONVERT(bit, 'False'), CONVERT(bit, 'False'), CONVERT(bit, 'False'), CONVERT(bit, 'False'), CONVERT(bit, 'False'), CONVERT(bit, 'False'), CONVERT(bit, 'False'), CONVERT(bit, 'False'), CONVERT(bit, 'True'))
GO
SET IDENTITY_INSERT FastConsig.dbo.CTCMotivoCancelamentoPortabilidade OFF
GO