CREATE TABLE FastConsig.dbo.EventoFuncionalidade (
  Id int IDENTITY,
  Nome varchar(100) NOT NULL,
  IdFuncionalidade int NOT NULL,
  CONSTRAINT PK_EventoFuncionalidade PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.EventoFuncionalidade
  ADD CONSTRAINT FK_EventoFuncionalidade_Funcionalidade FOREIGN KEY (IdFuncionalidade) REFERENCES dbo.Funcionalidade (Id)
GO


SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

SET IDENTITY_INSERT FastConsig.dbo.EventoFuncionalidade ON
GO
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (1, 'Restringir Visualização de Propostas na Fase PROSPECÇÃO', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (2, 'Restringir Visualização de Propostas na Fase CAPTURA', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (3, 'Restringir Visualização de Propostas na Fase MESA PROMOTORA', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (4, 'Restringir Visualização de Propostas na Fase CONSULTA', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (5, 'Restringir Visualização de Propostas na Fase ANÁLISE BACKOFFICE', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (6, 'Restringir Visualização de Propostas na Fase ANÁLISE PLD', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (7, 'Restringir Visualização de Propostas na Fase ASSINATURA DIGITAL', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (8, 'Restringir Visualização de Propostas na Fase AVERBAÇÃO', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (9, 'Restringir Visualização de Propostas na Fase INTEGRAÇÃO', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (10, 'Restringir Visualização de Propostas na Fase RETORNO CRITICA', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (11, 'Restringir Visualização Somentes as Propostas Capturadas ou sob Gerência', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (12, 'Restringir Visualização Somente as Propostas da Promotora', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (13, 'Master Promotora', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (14, 'Editar Usuário', 7)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (15, 'Restringir Visualização de Arquivos', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (16, 'Rejeitar Proposta', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (17, 'Restringir Visualização do Complemento da Ocorrência', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (18, 'Restringir Visualização do Usuário da Ocorrência', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (19, 'Visualizar Detalhes da Ocorrência', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (20, 'Complementar Informações em Ocorrências de Pendência na Fase de CAPTURA', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (21, 'Aprovar/Rejeitar Ocorrências da Fase CAPTURA', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (22, 'Aprovar/Rejeitar Ocorrências da Fase MESA PROMOTORA', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (23, 'Aprovar/Rejeitar Ocorrências da Fase CONSULTA', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (24, 'Aprovar/Rejeitar Ocorrências da Fase ANÁLISE DE BACKOFFICE', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (25, 'Aprovar/Rejeitar Ocorrências da Fase ANÁLISE DE PLD', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (26, 'Aprovar/Rejeitar Ocorrências da Fase ASSINATURA DIGITAL', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (27, 'Aprovar/Rejeitar Ocorrências da Fase AVERBAÇÃO', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (28, 'Aprovar/Rejeitar Ocorrências da Fase INTEGRAÇÃO', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (29, 'Visualizar Aba Consultas', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (30, 'Visualizar Aba Ocorrências', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (31, 'Visualizar Aba Checklist', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (32, 'Visualizar Aba Histórico de Alterações', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (33, 'Visualizar Aba Log', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (34, 'Desbloquear Proposta', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (35, 'Reenviar Link Combate a Fraude', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (36, 'Excluir Arquivo Anexado', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (37, 'Visualizar Aba Trilha Auditoria', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (38, 'Visualizar Aba Arquivos', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (39, 'Anexar Arquivos na Fase de INTEGRAÇÃO', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (40, 'Desbloquear Proposta', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (41, 'Desbloquear Proposta na Fase ANALISE PLD', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (42, 'Desbloquear Proposta na Fase ASSINATURA DIGITAL', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (43, 'Desbloquear Proposta na Fase AVERBAÇÃO', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (44, 'Desbloquear Proposta na Fase CAPTURA', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (45, 'Desbloquear Proposta na Fase CONSULTA', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (46, 'Desbloquear Proposta na Fase INTEGRAÇÃO', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (47, 'Desbloquear Proposta na Fase MESA PROMOTORA', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (48, 'Editar Propostas na Fase MESA PROMOTORA', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (49, 'Excluir Arquivo Anexado', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (50, 'Incluir Ocorrências na Fase AVERBAÇÃO', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (51, 'Incluir Ocorrências na Fase CAPTURA', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (52, 'Incluir Ocorrências na Fase CONSULTA', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (53, 'Incluir Ocorrências na Fase MESA PROMOTORA', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (54, 'Pendenciar Proposta', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (55, 'Pendenciar Proposta na fase ANÁLISE DE BACKOFFICE', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (56, 'Pendenciar Proposta na fase ANÁLISE DE PLD', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (57, 'Pendenciar Proposta na fase INTEGRAÇÃO', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (58, 'Reenviar Link Assinatura Digital', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (59, 'Rejeitar Proposta', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (60, 'Submeter Proposta na Fase RETORNO CRITICA', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (61, 'Desbloquear Proposta na Fase ANÁLISE DE BACKOFFICE', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (62, 'Submeter Proposta na Fase CAPTURA', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (63, 'Submeter Proposta na Fase MESA PROMOTORA', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (64, 'Submeter Proposta na Fase CONSULTA', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (65, 'Submeter Proposta na Fase ANÁLISE BACKOFFICE', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (66, 'Submeter Proposta na Fase ANÁLISE PLD', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (67, 'Submeter Proposta na Fase ASSINATURA DIGITAL', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (68, 'Submeter Proposta na Fase AVERBAÇÃO', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (69, 'Submeter Proposta na Fase INTEGRAÇÃO', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (70, 'Submeter Proposta na Fase RETORNO CRITICA', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (71, 'Incluir Ocorrências na Fase CAPTURA', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (72, 'Incluir Ocorrências na Fase MESA PROMOTORA', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (73, 'Incluir Ocorrências na Fase CONSULTA', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (74, 'Incluir Ocorrências na Fase ANÁLISE BACKOFFICE', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (75, 'Incluir Ocorrências na Fase ANÁLISE PLD', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (76, 'Incluir Ocorrências na Fase ASSINATURA DIGITAL', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (77, 'Incluir Ocorrências na Fase AVERBAÇÃO', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (78, 'Incluir Ocorrências na Fase INTEGRAÇÃO', 1)
INSERT FastConsig.dbo.EventoFuncionalidade(Id, Nome, IdFuncionalidade) VALUES (79, 'Incluir Ocorrências na Fase RETORNO CRITICA', 1)
GO
SET IDENTITY_INSERT FastConsig.dbo.EventoFuncionalidade OFF
GO