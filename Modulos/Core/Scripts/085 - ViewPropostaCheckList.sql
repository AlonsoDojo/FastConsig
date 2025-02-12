CREATE VIEW ViewPropostaCheckList AS
SELECT
  PropostaChecklist.Id
 ,PropostaChecklist.Proposta
 ,CheckListItens.Id AS IdItem
 ,CheckListItens.Descricao
 ,PropostaChecklist.Obrigatorio
 ,PropostaChecklist.TipoDocumento
 ,TipoDocumento.Descricao AS DocumentoNecessario
 ,(CASE
    WHEN PropostaChecklist.Obrigatorio = 0 THEN 1
    WHEN (SELECT
          COUNT(*)
        FROM PropostaArquivos Arquivos
        WHERE Arquivos.Proposta = PropostaChecklist.Proposta
        AND Arquivos.TipoDocumento = PropostaChecklist.TipoDocumento)
      > 0 THEN 1
    ELSE 0
  END) AS Cumprido
FROM PropostaChecklist
    ,CheckListItens
    ,TipoDocumento
WHERE PropostaChecklist.Item = CheckListItens.Id
AND TipoDocumento.Id = PropostaChecklist.TipoDocumento