CREATE VIEW ViewCTCFluxoPortabilidade AS 
select cp.Id, cp.TipoArquivo, d.Descricao as DescricaoArquivo, cp.Fase, f.Descricao as DescricaoFase, cp.Peso, c.Descricao as DescricaoPolitica, c.Metodo, cp.Entrada, cp.Saida, cp.TipoFluxo, tf.Descricao as DescricaoFluxo
from CTCPoliticaConfiguracaoExecucao cp, CTCPoliticas c, CTCDominioArquivo d, CTCFases f, CTCTipoFluxo tf 
where cp.Politica = c.Id 
and d.Id = cp.TipoArquivo
and f.Id = cp.Fase
and tf.Id = cp.TipoFluxo