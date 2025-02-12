CREATE VIEW ViewContratosREFINUtilizados AS 
select Pessoas.CpfCnpj AS CpfCnpj, Propostas.Id as Proposta, PropostaContratosREFIN.Empresa AS Empresa, PropostaContratosREFIN.Agencia AS Agencia, Contrato, RedeLojas, Loja, TipoBeneficio 
from PropostaContratosREFIN, Pessoas, PropostaOperacao, Compromissos, Propostas
where PropostaContratosREFIN.Proposta = Propostas.Id
and Status NOT in(9, 4, 5, 7)
AND Propostas.Id = PropostaOperacao.Proposta
AND Compromissos.Proposta = Propostas.Id
AND Compromissos.TipoCompromisso = 'CL'
AND Pessoas.Id = Compromissos.Pessoa

