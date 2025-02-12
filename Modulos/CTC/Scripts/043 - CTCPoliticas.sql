CREATE TABLE FastConsig.dbo.CTCPoliticas (
  Id int IDENTITY,
  Descricao varchar(255) NOT NULL,
  Metodo varchar(max) NOT NULL,
  TipoPolitica int NULL,
  Async bit NULL,
  Parametros varchar(max) NULL,
  CONSTRAINT PK_CTCPoliticas_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.CTCPoliticas
  ADD CONSTRAINT FK_CTCPoliticas_TipoPolitica FOREIGN KEY (TipoPolitica) REFERENCES dbo.TipoPolitica (Id)
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

SET IDENTITY_INSERT FastConsig.dbo.CTCPoliticas ON
GO
INSERT FastConsig.dbo.CTCPoliticas(Id, Descricao, Metodo, TipoPolitica, Async, Parametros) VALUES (1, 'Pula Fase - Requisição', 'FastConsig.CTC.Politicas.PulaFase', 1, CONVERT(bit, 'False'), NULL)
INSERT FastConsig.dbo.CTCPoliticas(Id, Descricao, Metodo, TipoPolitica, Async, Parametros) VALUES (2, 'Aguarda na Fase', 'FastConsig.CTC.Politicas.AguardaNaFase', 1, CONVERT(bit, 'False'), NULL)
INSERT FastConsig.dbo.CTCPoliticas(Id, Descricao, Metodo, TipoPolitica, Async, Parametros) VALUES (3, 'Cálculo das Ofertas para Retenção', 'FastConsig.CTC.Politicas.CalculoOfertasRetencao', 1, CONVERT(bit, 'False'), NULL)
INSERT FastConsig.dbo.CTCPoliticas(Id, Descricao, Metodo, TipoPolitica, Async, Parametros) VALUES (4, 'Busca Situação do Contrato no Originador', 'FastConsig.CTC.Politicas.BuscaSituacaoOriginador', 1, CONVERT(bit, 'False'), NULL)
INSERT FastConsig.dbo.CTCPoliticas(Id, Descricao, Metodo, TipoPolitica, Async, Parametros) VALUES (5, 'Processamento da Aceitação da Portabilidade', 'FastConsig.CTC.Politicas.ProcessamentoAceitacaoPortabilidade', 1, CONVERT(bit, 'False'), NULL)
INSERT FastConsig.dbo.CTCPoliticas(Id, Descricao, Metodo, TipoPolitica, Async, Parametros) VALUES (6, 'Aguarda na Fase - Aguardando Envio', 'FastConsig.CTC.Politicas.AguardaNaFaseAguardandoEnvio', 1, CONVERT(bit, 'False'), NULL)
INSERT FastConsig.dbo.CTCPoliticas(Id, Descricao, Metodo, TipoPolitica, Async, Parametros) VALUES (7, 'Aguarda na Fase - Pagamento', 'FastConsig.CTC.Politicas.AguardaNaFasePagamento', 1, CONVERT(bit, 'False'), NULL)
INSERT FastConsig.dbo.CTCPoliticas(Id, Descricao, Metodo, TipoPolitica, Async, Parametros) VALUES (8, 'Processamento da Retenção da Portabilidade', 'FastConsig.CTC.Politicas.ProcessamentoRetencaoPortabilidade', 1, CONVERT(bit, 'False'), NULL)
INSERT FastConsig.dbo.CTCPoliticas(Id, Descricao, Metodo, TipoPolitica, Async, Parametros) VALUES (9, 'Finalizar Fluxo', 'FastConsig.CTC.Politicas.FinalizarFluxo', 1, CONVERT(bit, 'False'), NULL)
INSERT FastConsig.dbo.CTCPoliticas(Id, Descricao, Metodo, TipoPolitica, Async, Parametros) VALUES (10, 'Processamento da Liquidação da Portabilidade', 'FastConsig.CTC.Politicas.ProcessamentoLiquidacaoPortabilidade', 1, CONVERT(bit, 'False'), NULL)
INSERT FastConsig.dbo.CTCPoliticas(Id, Descricao, Metodo, TipoPolitica, Async, Parametros) VALUES (11, 'Processamento do Cancelamento da Portabilidade', 'FastConsig.CTC.Politicas.ProcessamentoCancelamentoPortabilidade', 1, CONVERT(bit, 'False'), NULL)
INSERT FastConsig.dbo.CTCPoliticas(Id, Descricao, Metodo, TipoPolitica, Async, Parametros) VALUES (12, 'Envia Requisição para o Fluxo de Pagamento', 'FastConsig.CTC.Politicas.EnviaRequisicaoParaPagamento', 1, CONVERT(bit, 'False'), NULL)
GO
SET IDENTITY_INSERT FastConsig.dbo.CTCPoliticas OFF
GO