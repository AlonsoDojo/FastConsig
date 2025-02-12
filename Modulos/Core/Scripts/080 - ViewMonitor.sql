CREATE VIEW ViewMonitor AS 
SELECT
  p.Id AS Proposta
 ,p.DataCriacao AS DataCriacao
 ,pe.CpfCnpj AS CPFCNPJ
 ,pe.TipoPessoa AS TipoPessoa
 ,pe.Nome AS NomeProponente
 ,pe.NumeroBeneficio AS NumeroBeneficio
 ,pe.EspecieBeneficio AS EspecieBeneficio
 ,pe.DDDCelular AS DDDCelular
 ,pe.Celular AS Celular
 ,p.Fase AS Fase
 ,p.Status AS Status
 ,p.Gerente AS Gerente
 ,p.Usuario AS Usuario
 ,p.Promotora AS Promotora
 ,p.ProfissionalCertificado AS ProfissionalCertificado
 ,CAST(p.MotivoRecusa AS VARCHAR(MAX)) AS MotivoRecusa
 ,op.Produto
 ,op.ValorOperacao
 ,op.ValorFinanciadoTotal AS ValorFinanciado
 ,op.Prazo
 ,op.DataPrimeiroVencimento
 ,op.Tabela
 ,op.ContratoLegado
 ,op.PropostaLegado
 ,op.RedeLojas
 ,op.Loja
 ,op.Banco AS BancoLiquidacao
 ,op.Agencia AS AgenciaLiquidacao
 ,op.Conta AS ContaLiquidacao
 ,op.ValorLiberado
 ,p.DataUltimaAlteracao AS DataAtualizacao
 ,p.UsuarioProposta
 ,op.ValorParcela
 ,Lojas.Abreviatura AS NomeLoja
 ,Usuario.Nome AS NomeUsuarioProposta
 ,Produtos.FamiliaProduto AS FamiliaProduto
 ,CASE
    WHEN (SELECT
          COUNT(*)
        FROM PropostaOcorrencias oc
        WHERE oc.Proposta = p.Id
        AND oc.Ocorrencia = 77)
      > 0 THEN 'Não'
    ELSE 'Sim'
  END AS ComissaoNMP
 ,CASE
    WHEN p.Status IN (1, 4) THEN p.MensagemInterna
    ELSE NULL
  END AS MensagemPendencia
 ,(SELECT
      COUNT(*)
    FROM PropostaOcorrencias
    WHERE Proposta = p.Id
    AND Restritiva = 'S'
    AND Liberada = 0)
  AS AguardandoLiberacao
 ,(SELECT
      MIN(DataExecucao)
    FROM PropostaHistorico h
    WHERE h.Proposta = p.Id
    AND h.Fase = 9)
  AS DataIntegracao
FROM Propostas p
     LEFT JOIN Usuario
       ON (Usuario.Login = p.UsuarioProposta
           AND Usuario.Dominio <> 1)
    ,Compromissos c
    ,Pessoas pe
    ,PropostaOperacao op
     LEFT JOIN Lojas
       ON (lojas.RedeLoja = op.RedeLojas
           AND Lojas.Loja = op.Loja)
     LEFT JOIN Produtos
       ON (Produtos.Id = op.Produto)
WHERE c.Proposta = p.Id
AND c.TipoCompromisso = 'CL'
AND pe.Id = c.Pessoa
AND op.Proposta = p.Id
