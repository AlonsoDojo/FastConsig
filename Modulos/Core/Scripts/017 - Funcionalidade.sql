CREATE TABLE FastConsig.dbo.Funcionalidade (
  Id int IDENTITY,
  IdGrupoFuncionalidade int NULL,
  Nome varchar(50) NULL,
  Titulo varchar(75) NULL,
  Descricao varchar(max) NULL,
  Url varchar(250) NULL,
  Habilitado bit NULL,
  Sequencia smallint NULL,
  Visivel bit NOT NULL CONSTRAINT DF_Funcionalidade_Visivel DEFAULT (1),
  CONSTRAINT PK_Funcionalidade PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.Funcionalidade
  ADD CONSTRAINT FK_Funcionalidade_GrupoFuncionalidade FOREIGN KEY (IdGrupoFuncionalidade) REFERENCES dbo.GrupoFuncionalidade (Id)
GO


SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

SET IDENTITY_INSERT FastConsig.dbo.Funcionalidade ON
GO
INSERT FastConsig.dbo.Funcionalidade(Id, IdGrupoFuncionalidade, Nome, Titulo, Descricao, Url, Habilitado, Sequencia, Visivel) VALUES (1, 1, 'Monitor de Propostas', NULL, NULL, '/Credito/MonitorPropostas.aspx', CONVERT(bit, 'True'), NULL, CONVERT(bit, 'True'))
INSERT FastConsig.dbo.Funcionalidade(Id, IdGrupoFuncionalidade, Nome, Titulo, Descricao, Url, Habilitado, Sequencia, Visivel) VALUES (2, 1, 'Simulação', NULL, NULL, '/Credito/SimulacaoPropostas.aspx', CONVERT(bit, 'True'), NULL, CONVERT(bit, 'True'))
INSERT FastConsig.dbo.Funcionalidade(Id, IdGrupoFuncionalidade, Nome, Titulo, Descricao, Url, Habilitado, Sequencia, Visivel) VALUES (3, 2, 'Visualizar', NULL, NULL, '/Comunicados/VisualizarComunicados.aspx', CONVERT(bit, 'True'), NULL, CONVERT(bit, 'True'))
INSERT FastConsig.dbo.Funcionalidade(Id, IdGrupoFuncionalidade, Nome, Titulo, Descricao, Url, Habilitado, Sequencia, Visivel) VALUES (4, 3, 'Produtos', NULL, NULL, '/Configuracoes/ListarProdutos.aspx', CONVERT(bit, 'True'), NULL, CONVERT(bit, 'True'))
INSERT FastConsig.dbo.Funcionalidade(Id, IdGrupoFuncionalidade, Nome, Titulo, Descricao, Url, Habilitado, Sequencia, Visivel) VALUES (5, 4, 'Monitor Originador', NULL, NULL, '/Portabilidade/MonitorPortabilidadeOriginador.aspx', CONVERT(bit, 'True'), NULL, CONVERT(bit, 'True'))
INSERT FastConsig.dbo.Funcionalidade(Id, IdGrupoFuncionalidade, Nome, Titulo, Descricao, Url, Habilitado, Sequencia, Visivel) VALUES (6, 5, 'Relatórios', NULL, NULL, '/Relatorios/Relatórios.aspx', CONVERT(bit, 'True'), NULL, CONVERT(bit, 'True'))
INSERT FastConsig.dbo.Funcionalidade(Id, IdGrupoFuncionalidade, Nome, Titulo, Descricao, Url, Habilitado, Sequencia, Visivel) VALUES (7, 6, 'Usuários - Admin', NULL, NULL, '/Seguranca/UsuariosAdmin.aspx', CONVERT(bit, 'True'), NULL, CONVERT(bit, 'True'))
INSERT FastConsig.dbo.Funcionalidade(Id, IdGrupoFuncionalidade, Nome, Titulo, Descricao, Url, Habilitado, Sequencia, Visivel) VALUES (8, 6, 'Domínios', NULL, NULL, '/Seguranca/Dominios.aspx', CONVERT(bit, 'True'), NULL, CONVERT(bit, 'True'))
INSERT FastConsig.dbo.Funcionalidade(Id, IdGrupoFuncionalidade, Nome, Titulo, Descricao, Url, Habilitado, Sequencia, Visivel) VALUES (9, 6, 'Parâmetros Gerais', NULL, NULL, '/Seguranca/Parametros.aspx', CONVERT(bit, 'True'), NULL, CONVERT(bit, 'True'))
INSERT FastConsig.dbo.Funcionalidade(Id, IdGrupoFuncionalidade, Nome, Titulo, Descricao, Url, Habilitado, Sequencia, Visivel) VALUES (10, 6, 'Usuários', NULL, NULL, '/Seguranca/Usuarios.aspx', CONVERT(bit, 'True'), NULL, CONVERT(bit, 'True'))
INSERT FastConsig.dbo.Funcionalidade(Id, IdGrupoFuncionalidade, Nome, Titulo, Descricao, Url, Habilitado, Sequencia, Visivel) VALUES (11, 3, 'Políticas', NULL, NULL, '/Configuracoes/ListarPoliticas.aspx', CONVERT(bit, 'True'), NULL, CONVERT(bit, 'True'))
INSERT FastConsig.dbo.Funcionalidade(Id, IdGrupoFuncionalidade, Nome, Titulo, Descricao, Url, Habilitado, Sequencia, Visivel) VALUES (12, 3, 'Ocorrências', NULL, NULL, '/Configuracoes/ListarOcorrencias.aspx', CONVERT(bit, 'True'), NULL, CONVERT(bit, 'True'))
INSERT FastConsig.dbo.Funcionalidade(Id, IdGrupoFuncionalidade, Nome, Titulo, Descricao, Url, Habilitado, Sequencia, Visivel) VALUES (13, 3, 'Ocorrências INSS', NULL, NULL, '/Configuracoes/ListarOcorrenciasINSS.aspx', CONVERT(bit, 'True'), NULL, CONVERT(bit, 'True'))
INSERT FastConsig.dbo.Funcionalidade(Id, IdGrupoFuncionalidade, Nome, Titulo, Descricao, Url, Habilitado, Sequencia, Visivel) VALUES (14, 3, 'Ocorrências SIAPE', NULL, NULL, '/Configuracoes/ListarOcorrenciasSIAPE.aspx', CONVERT(bit, 'True'), NULL, CONVERT(bit, 'True'))
INSERT FastConsig.dbo.Funcionalidade(Id, IdGrupoFuncionalidade, Nome, Titulo, Descricao, Url, Habilitado, Sequencia, Visivel) VALUES (15, 3, 'Tipo de Benefício - INSS', NULL, NULL, '/Configuracoes/ListarTipoBeneficioINSS.aspx', CONVERT(bit, 'True'), NULL, CONVERT(bit, 'True'))
INSERT FastConsig.dbo.Funcionalidade(Id, IdGrupoFuncionalidade, Nome, Titulo, Descricao, Url, Habilitado, Sequencia, Visivel) VALUES (16, 3, 'Tarefas', NULL, NULL, '/Configuracoes/ListarTarefas.aspx', CONVERT(bit, 'True'), NULL, CONVERT(bit, 'True'))
INSERT FastConsig.dbo.Funcionalidade(Id, IdGrupoFuncionalidade, Nome, Titulo, Descricao, Url, Habilitado, Sequencia, Visivel) VALUES (17, 3, 'Arquivos Portabilidade', NULL, NULL, '/Configuracoes/ListarArquivosPortabilidade.aspx', CONVERT(bit, 'True'), NULL, CONVERT(bit, 'True'))
INSERT FastConsig.dbo.Funcionalidade(Id, IdGrupoFuncionalidade, Nome, Titulo, Descricao, Url, Habilitado, Sequencia, Visivel) VALUES (18, 4, 'Contas de Pagamento', NULL, NULL, '/Portabilidade/ContasPagamentoPortabilidade.aspx', CONVERT(bit, 'True'), NULL, CONVERT(bit, 'True'))
INSERT FastConsig.dbo.Funcionalidade(Id, IdGrupoFuncionalidade, Nome, Titulo, Descricao, Url, Habilitado, Sequencia, Visivel) VALUES (19, 4, 'Histórico de Arquivos', NULL, NULL, '/Portabilidade/HistoricoArquivosPortabilidade.aspx', CONVERT(bit, 'True'), NULL, CONVERT(bit, 'True'))
INSERT FastConsig.dbo.Funcionalidade(Id, IdGrupoFuncionalidade, Nome, Titulo, Descricao, Url, Habilitado, Sequencia, Visivel) VALUES (20, 4, 'Movimentação RCO', NULL, NULL, '/Portabilidade/MovimentacaoRCO.aspx', CONVERT(bit, 'True'), NULL, CONVERT(bit, 'True'))
INSERT FastConsig.dbo.Funcionalidade(Id, IdGrupoFuncionalidade, Nome, Titulo, Descricao, Url, Habilitado, Sequencia, Visivel) VALUES (21, 3, 'Promotoras', NULL, NULL, '/Configuracoes/ListarPromotoras.aspx', CONVERT(bit, 'True'), NULL, CONVERT(bit, 'True'))
INSERT FastConsig.dbo.Funcionalidade(Id, IdGrupoFuncionalidade, Nome, Titulo, Descricao, Url, Habilitado, Sequencia, Visivel) VALUES (22, 6, 'Perfil', NULL, NULL, '/Seguranca/Perfis.aspx', CONVERT(bit, 'True'), NULL, CONVERT(bit, 'True'))
INSERT FastConsig.dbo.Funcionalidade(Id, IdGrupoFuncionalidade, Nome, Titulo, Descricao, Url, Habilitado, Sequencia, Visivel) VALUES (23, 2, 'Cadastro', NULL, NULL, '/Comunicados/Comunicados.aspx', CONVERT(bit, 'True'), NULL, CONVERT(bit, 'True'))
INSERT FastConsig.dbo.Funcionalidade(Id, IdGrupoFuncionalidade, Nome, Titulo, Descricao, Url, Habilitado, Sequencia, Visivel) VALUES (24, 3, 'Motivos de Bloqueio', NULL, NULL, '/Configuracoes/ListarMotivosBloqueio.aspx', CONVERT(bit, 'True'), NULL, CONVERT(bit, 'True'))
INSERT FastConsig.dbo.Funcionalidade(Id, IdGrupoFuncionalidade, Nome, Titulo, Descricao, Url, Habilitado, Sequencia, Visivel) VALUES (25, 3, 'Motivos de Recusa', NULL, NULL, '/Configuracoes/ListarMotivosRecusa.aspx', CONVERT(bit, 'True'), NULL, CONVERT(bit, 'True'))
INSERT FastConsig.dbo.Funcionalidade(Id, IdGrupoFuncionalidade, Nome, Titulo, Descricao, Url, Habilitado, Sequencia, Visivel) VALUES (26, 3, 'Checklist', NULL, NULL, '/Configuracoes/ListarChecklist.aspx', CONVERT(bit, 'True'), NULL, CONVERT(bit, 'True'))
INSERT FastConsig.dbo.Funcionalidade(Id, IdGrupoFuncionalidade, Nome, Titulo, Descricao, Url, Habilitado, Sequencia, Visivel) VALUES (27, 3, 'Gerentes', NULL, NULL, '/Configuracoes/ListarGerentes.aspx', CONVERT(bit, 'True'), NULL, CONVERT(bit, 'True'))
INSERT FastConsig.dbo.Funcionalidade(Id, IdGrupoFuncionalidade, Nome, Titulo, Descricao, Url, Habilitado, Sequencia, Visivel) VALUES (28, 3, 'Rede de Lojas', NULL, NULL, '/Configuracoes/ListarRedeLojas.aspx', CONVERT(bit, 'True'), NULL, CONVERT(bit, 'True'))
INSERT FastConsig.dbo.Funcionalidade(Id, IdGrupoFuncionalidade, Nome, Titulo, Descricao, Url, Habilitado, Sequencia, Visivel) VALUES (29, 3, 'Lojas', NULL, NULL, '/Configuracoes/ListarLojas.aspx', CONVERT(bit, 'True'), NULL, CONVERT(bit, 'True'))
INSERT FastConsig.dbo.Funcionalidade(Id, IdGrupoFuncionalidade, Nome, Titulo, Descricao, Url, Habilitado, Sequencia, Visivel) VALUES (30, 3, 'Fases', NULL, NULL, '/Configuracoes/ListarFases.aspx', CONVERT(bit, 'True'), NULL, CONVERT(bit, 'True'))
INSERT FastConsig.dbo.Funcionalidade(Id, IdGrupoFuncionalidade, Nome, Titulo, Descricao, Url, Habilitado, Sequencia, Visivel) VALUES (31, 3, 'Status', NULL, NULL, '/Configuracoes/ListarStatus.aspx', CONVERT(bit, 'True'), NULL, CONVERT(bit, 'True'))
INSERT FastConsig.dbo.Funcionalidade(Id, IdGrupoFuncionalidade, Nome, Titulo, Descricao, Url, Habilitado, Sequencia, Visivel) VALUES (32, 3, 'Familia de Produtos', NULL, NULL, '/Configuracoes/ListarFamiliaProdutos.aspx', CONVERT(bit, 'True'), NULL, CONVERT(bit, 'True'))
INSERT FastConsig.dbo.Funcionalidade(Id, IdGrupoFuncionalidade, Nome, Titulo, Descricao, Url, Habilitado, Sequencia, Visivel) VALUES (33, 3, 'Tipo de Comunicação', NULL, NULL, '/Configuracoes/ListarTipoComunicacao.aspx', CONVERT(bit, 'True'), NULL, CONVERT(bit, 'True'))
INSERT FastConsig.dbo.Funcionalidade(Id, IdGrupoFuncionalidade, Nome, Titulo, Descricao, Url, Habilitado, Sequencia, Visivel) VALUES (34, 3, 'Auditoria', NULL, NULL, '/Configuracoes/ListarAuditoria.aspx', CONVERT(bit, 'True'), NULL, CONVERT(bit, 'True'))
INSERT FastConsig.dbo.Funcionalidade(Id, IdGrupoFuncionalidade, Nome, Titulo, Descricao, Url, Habilitado, Sequencia, Visivel) VALUES (35, 3, 'Tipo de Documento', NULL, NULL, '/Configuracoes/ListarTipoDocumento.aspx', CONVERT(bit, 'True'), NULL, CONVERT(bit, 'True'))
INSERT FastConsig.dbo.Funcionalidade(Id, IdGrupoFuncionalidade, Nome, Titulo, Descricao, Url, Habilitado, Sequencia, Visivel) VALUES (36, 6, 'Alterar Senha', NULL, NULL, '/Seguranca/AlterarSenha.aspx', CONVERT(bit, 'True'), NULL, CONVERT(bit, 'True'))
GO
SET IDENTITY_INSERT FastConsig.dbo.Funcionalidade OFF
GO