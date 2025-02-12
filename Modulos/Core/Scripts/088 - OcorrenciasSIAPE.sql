CREATE TABLE FastConsig.dbo.OcorrenciasSIAPE (
  Id int IDENTITY,
  Codigo varchar(5) NULL,
  Descricao varchar(255) NOT NULL,
  Acao int NOT NULL,
  Ocorrencia int NULL,
  CONSTRAINT PK_OcorrenciasSIAPE PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.OcorrenciasSIAPE
  ADD CONSTRAINT OcorrenciasSIAPE_FK FOREIGN KEY (Ocorrencia) REFERENCES dbo.Ocorrencias (Id)
GO

ALTER TABLE FastConsig.dbo.OcorrenciasSIAPE
  ADD CONSTRAINT FK_OcorrenciasSIAPE_Acao FOREIGN KEY (Acao) REFERENCES dbo.OcorrenciasConsignadoAcao (Id)
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

SET IDENTITY_INSERT FastConsig.dbo.OcorrenciasSIAPE ON
GO
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (1, '0000', 'Serviço Realizado com Sucesso', 1, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (2, '0002', 'Órgão Inexistente', 4, 1)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (3, '0008', 'Convênio Inexistente', 4, 1)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (4, '0024', 'Número do contrato incorreto', 4, 1)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (5, '0029', 'Número do contrato existente', 4, 1)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (6, '0056', 'Órgão não está ativo', 2, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (7, '0087', 'Senha do funcionário expirada ou bloqueada', 4, 1)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (8, '0001', 'Serviço Realizado com Sucesso', 1, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (9, '2027', 'Valor da Prestação incorreto. I Órgão incorreto. I Matricula incorreta', 2, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (10, '2035', 'Servidor inativo', 2, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (11, '2046', 'CPF não confere com a matrícula', 2, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (12, '2048', 'Servidor falecido', 2, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (13, '2109', 'Valor da prestação não informado I órgão não informado I Matricula não informada', 2, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (14, '2215', 'Registro está sendo utilizado em outra operação', 2, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (15, '2282', 'Senha do servidor não autenticada', 4, 1)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (16, '4003', 'Nenhum contrato vigente', 2, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (17, '4004', 'Quantidade de contratos vigentes insuficiente', 2, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (18, '4005', 'Não foi possivel recuperar todos os contratos vigentes', 2, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (19, '4006', 'O contrato pertence a outro vínculo', 2, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (20, '4007', 'Situação do servidor não permite consignação', 2, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (21, '4008', 'Rubrica não possui autorização para realizar consignação', 2, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (22, '4009', 'Nenhum vínculo encontrado para este servidor', 4, 1)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (23, '4010', 'Valor e prazo iguais ao do contrato a ser alterado', 2, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (24, '4011', 'Consignatária sem rubrica associada para este órgão', 4, 1)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (25, '4012', 'Contrato renovado dentro do mês não pode ser excluido', 2, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (26, '4013', 'Contrato já se encontra quitado', 1, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (27, '4014', 'Contrato sem renovação', 1, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (28, '4015', 'Contrato sem rubrica disponível', 2, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (29, '4016', 'Servidor ou Pensionista com renovação no mês corrente', 2, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (30, '4017', 'Rubrica não pertence a esta consignatária', 2, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (31, '4018', 'Rubrica não pode ser tratada por mov. De consignação', 2, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (32, '4019', 'Servidor ou Pensionista bloqueado para rubrica/sequência', 2, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (33, '4020', 'Atualização noa permitida, conforme 3º do art. 25º', 3, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (34, '4021', 'Rubrica não é facultativa', 2, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (35, '4022', 'Prazo informado maior que o prazo estabelcido pelo MP', 2, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (36, '4023', 'Problemas com a consignatária', 3, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (37, '4024', 'Matrícula ou òrgão inválido', 2, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (38, '4025', 'Cronograma do Órgão não implantado', 3, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (39, '4026', 'Rubrica não cadastrada', 3, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (40, '4027', 'Rubrica desativada', 3, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (41, '4028', 'Situação funcional da rubrica imcopatível com a do servidor', 2, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (42, '4029', 'Rubrica com incopatibilidade determinada po decisão judicial', 2, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (43, '4030', 'Valor inferior ao minimo permitido', 2, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (44, '4031', 'Inclusão de rubrica/sequência já existente para o servidor/pensionista', 2, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (45, '4032', 'Beneficiário excluido de pagamento', 2, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (46, '4033', 'Beneficiário suspenso de pagamento', 2, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (47, '4034', 'Servidor/Pensionista sem contrato ativo', 4, 1)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (48, '4035', 'Contratos zerados', 4, 1)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (49, '4036', 'Tipo de consignação só permite amortização', 2, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (50, '4037', 'Cnotrato não pode desfazer renovação', 2, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (51, '4038', 'Rubrica/Sequência do contrato', 3, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (52, '4039', 'Contrato não pode ser alterado', 2, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (53, '4040', 'Já existe uma consignação de cartão vigente. Tipo de consignação', 2, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (54, '4041', 'Consignação de cartão deve possuir prazo igual a 1', 2, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (55, '4042', 'Não permitida renovação de Consignação de cartão', 2, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (56, '8001', 'CPF incorreto', 2, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (57, '8010', 'Consignatária inexistente', 3, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (58, '8014', 'Servidor inexistente', 2, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (59, '8017', 'Contrato não localizado', 4, 1)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (60, '8028', 'Código de origem da transação incorreto', 4, 1)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (61, '8030', 'Código identificação servidor incorreto', 4, 1)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (62, '8035', 'Registro Hold incorreto', 4, 1)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (63, '8036', 'Consignatária incorreta', 4, 1)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (64, '8039', 'Senha do funcionário incorreta', 4, 1)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (65, '8056', 'Senha da consignatária incorreta', 4, 1)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (66, '8058', 'Funcionário não tem margem para esta solicitação', 2, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (67, '8060', 'Senha da consignatária bloqueada', 4, 1)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (68, '8083', 'Senha da consignatária não informada', 4, 1)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (69, '8084', 'Senha do servidor da transação não informada', 4, 1)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (70, '8087', 'Condigo da companhia não informado', 4, 1)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (71, '8089', 'CPF do servidor não informado', 2, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (72, '8111', 'Código de origem da transação não informado', 4, 1)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (73, '8112', 'Código identificação servidor não informado', 4, 1)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (74, '8133', 'Ação não executada. Número de sequência indisponivel', 3, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (75, '8888', 'Serviço indisponível', 3, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (76, '3', 'Ativo', 1, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (77, '4', 'Renovado', 1, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (78, '5', 'Quintado', 1, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (79, '6', 'Encerrado Consignatária', 2, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (80, '7', 'Suspenso com Bloqueio de Margem Consignavel', 2, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (81, '8', 'Suspenso sem Bloqueio de Margem Consignavel', 2, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (82, '9', 'Portado', 2, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (83, '10', 'Aguardando Anuência', 3, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (84, '11', 'Anuência Recusada', 2, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (85, '12', 'Anuência Expirada', 4, 1)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (86, '13', 'Anuência Interrompida por Restrição', 2, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (87, '14', 'Aguardando Encerramento do Contrato Portado', 3, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (88, '15', 'Portabilidade Cancelada por Prazo', 2, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (89, '16', 'Encerrado por Falta de Autorização', 2, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (90, '0000', 'Ativo', 1, NULL)
INSERT FastConsig.dbo.OcorrenciasSIAPE(Id, Codigo, Descricao, Acao, Ocorrencia) VALUES (91, '4050', 'Rubrica  possui  restrição  de  consignação  ativa  com  o  servidor/pensionista', 2, NULL)
GO
SET IDENTITY_INSERT FastConsig.dbo.OcorrenciasSIAPE OFF
GO