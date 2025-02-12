CREATE TABLE FastConsig.dbo.CTCMotivoRecusaEfetivacaoGarantiaFGO (
  Id int IDENTITY,
  Codigo varchar(3) NOT NULL,
  Descricao varchar(100) NOT NULL,
  CONSTRAINT PK_CTCMotivoRecusaFGO_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

CREATE UNIQUE INDEX IDX_CTCMotivoRecusaFGO_Codigo
  ON FastConsig.dbo.CTCMotivoRecusaEfetivacaoGarantiaFGO (Codigo)
  ON [PRIMARY]
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

SET IDENTITY_INSERT FastConsig.dbo.CTCMotivoRecusaEfetivacaoGarantiaFGO ON
GO
INSERT FastConsig.dbo.CTCMotivoRecusaEfetivacaoGarantiaFGO(Id, Codigo, Descricao) VALUES (1, '001', 'Código da Portabilidade NUCLEA inválido')
INSERT FastConsig.dbo.CTCMotivoRecusaEfetivacaoGarantiaFGO(Id, Codigo, Descricao) VALUES (2, '002', 'Código do Fundo Garantidor inválido')
INSERT FastConsig.dbo.CTCMotivoRecusaEfetivacaoGarantiaFGO(Id, Codigo, Descricao) VALUES (3, '003', 'Código ISPB do Agente Financeiro Origem inválido')
INSERT FastConsig.dbo.CTCMotivoRecusaEfetivacaoGarantiaFGO(Id, Codigo, Descricao) VALUES (4, '004', 'Código Identificador Externo da Operação Origem inválido')
INSERT FastConsig.dbo.CTCMotivoRecusaEfetivacaoGarantiaFGO(Id, Codigo, Descricao) VALUES (5, '005', 'Código do Tipo de Pessoa inválido')
INSERT FastConsig.dbo.CTCMotivoRecusaEfetivacaoGarantiaFGO(Id, Codigo, Descricao) VALUES (6, '006', 'Código Identificador do Mutuário na Receita Federal (CPF/CNPJ) inválido')
INSERT FastConsig.dbo.CTCMotivoRecusaEfetivacaoGarantiaFGO(Id, Codigo, Descricao) VALUES (7, '007', 'Data de Vencimento da Operação inválido')
INSERT FastConsig.dbo.CTCMotivoRecusaEfetivacaoGarantiaFGO(Id, Codigo, Descricao) VALUES (8, '008', 'Código ISPB do Agente Financeiro Destino inválido')
INSERT FastConsig.dbo.CTCMotivoRecusaEfetivacaoGarantiaFGO(Id, Codigo, Descricao) VALUES (9, '009', 'Número da Agência Destino inválido')
INSERT FastConsig.dbo.CTCMotivoRecusaEfetivacaoGarantiaFGO(Id, Codigo, Descricao) VALUES (10, '010', 'Código IBGE do Município da Agência Destino inválido')
INSERT FastConsig.dbo.CTCMotivoRecusaEfetivacaoGarantiaFGO(Id, Codigo, Descricao) VALUES (11, '011', 'Existe portabilidade validada ou efetivada com o mesmo Código de Portabilidade CIP')
INSERT FastConsig.dbo.CTCMotivoRecusaEfetivacaoGarantiaFGO(Id, Codigo, Descricao) VALUES (12, '012', 'Agente financeiro não localizado com o Código ISPB Origem')
INSERT FastConsig.dbo.CTCMotivoRecusaEfetivacaoGarantiaFGO(Id, Codigo, Descricao) VALUES (13, '013', 'Agente financeiro não localizado com o Código ISPB Destino')
INSERT FastConsig.dbo.CTCMotivoRecusaEfetivacaoGarantiaFGO(Id, Codigo, Descricao) VALUES (14, '014', 'Agente financeiro destino igual ao agente financeiro origem')
INSERT FastConsig.dbo.CTCMotivoRecusaEfetivacaoGarantiaFGO(Id, Codigo, Descricao) VALUES (15, '015', 'Operação de crédito origem não localizada')
INSERT FastConsig.dbo.CTCMotivoRecusaEfetivacaoGarantiaFGO(Id, Codigo, Descricao) VALUES (16, '016', 'O estado da operação perante o Fundo garantidor não permite sua portabilidade')
INSERT FastConsig.dbo.CTCMotivoRecusaEfetivacaoGarantiaFGO(Id, Codigo, Descricao) VALUES (17, '017', 'A Data de vencimento informada é diferente da cadastrada no Fundo Garantidor')
INSERT FastConsig.dbo.CTCMotivoRecusaEfetivacaoGarantiaFGO(Id, Codigo, Descricao) VALUES (18, '018', 'O Tipo de Pessoa informado é diferente do cadastrado no Fundo Garantidor')
INSERT FastConsig.dbo.CTCMotivoRecusaEfetivacaoGarantiaFGO(Id, Codigo, Descricao) VALUES (19, '019', 'O CPF/CNPJ informado é diferente do cadastrado no Fundo Garantidor')
INSERT FastConsig.dbo.CTCMotivoRecusaEfetivacaoGarantiaFGO(Id, Codigo, Descricao) VALUES (20, '020', 'Pendências da operação perante o Fundo Garantidor impedem sua portabilidade')
INSERT FastConsig.dbo.CTCMotivoRecusaEfetivacaoGarantiaFGO(Id, Codigo, Descricao) VALUES (21, '021', 'Existe portabilidade em andamento para esta operação')
INSERT FastConsig.dbo.CTCMotivoRecusaEfetivacaoGarantiaFGO(Id, Codigo, Descricao) VALUES (22, '022', 'A portabilidade extrapolaria o índice máximo de valores honrados do agente origem')
INSERT FastConsig.dbo.CTCMotivoRecusaEfetivacaoGarantiaFGO(Id, Codigo, Descricao) VALUES (23, '023', 'O agente destino não tem margem no Fundo Garantidor para a contratação desta operação')
INSERT FastConsig.dbo.CTCMotivoRecusaEfetivacaoGarantiaFGO(Id, Codigo, Descricao) VALUES (24, '024', 'Código da portabilidade GFG inválido')
INSERT FastConsig.dbo.CTCMotivoRecusaEfetivacaoGarantiaFGO(Id, Codigo, Descricao) VALUES (25, '025', 'Código Identificador Externo da Operação Destino inválido')
INSERT FastConsig.dbo.CTCMotivoRecusaEfetivacaoGarantiaFGO(Id, Codigo, Descricao) VALUES (26, '026', 'Código da Portabilidade GFG não localizado')
INSERT FastConsig.dbo.CTCMotivoRecusaEfetivacaoGarantiaFGO(Id, Codigo, Descricao) VALUES (27, '027', 'Procedimento não permitido para portabilidade no estado Efetivada')
INSERT FastConsig.dbo.CTCMotivoRecusaEfetivacaoGarantiaFGO(Id, Codigo, Descricao) VALUES (28, '028', 'Procedimento não permitido para portabilidade no estado Cancelada')
INSERT FastConsig.dbo.CTCMotivoRecusaEfetivacaoGarantiaFGO(Id, Codigo, Descricao) VALUES (29, '029', 'Procedimento não permitido para portabilidade no estado Expirada')
INSERT FastConsig.dbo.CTCMotivoRecusaEfetivacaoGarantiaFGO(Id, Codigo, Descricao) VALUES (30, '030', 'Procedimento não permitido para portabilidade no estado Rejeitada')
INSERT FastConsig.dbo.CTCMotivoRecusaEfetivacaoGarantiaFGO(Id, Codigo, Descricao) VALUES (31, '031', 'Existe operação com o mesmo Código Identificador Externo da Operação Destino')
INSERT FastConsig.dbo.CTCMotivoRecusaEfetivacaoGarantiaFGO(Id, Codigo, Descricao) VALUES (32, '032', 'O Código da Portabilidade NUCLEA não corresponde ao Código da Portabilidade GFG')
INSERT FastConsig.dbo.CTCMotivoRecusaEfetivacaoGarantiaFGO(Id, Codigo, Descricao) VALUES (33, '033', 'Solicitação de portabilidade rejeitada')
INSERT FastConsig.dbo.CTCMotivoRecusaEfetivacaoGarantiaFGO(Id, Codigo, Descricao) VALUES (34, '034', 'Código da Portabilidade NUCLEA não localizado')
INSERT FastConsig.dbo.CTCMotivoRecusaEfetivacaoGarantiaFGO(Id, Codigo, Descricao) VALUES (35, '035', 'Os dados informados são insuficientes para localizar a portabilidade')
INSERT FastConsig.dbo.CTCMotivoRecusaEfetivacaoGarantiaFGO(Id, Codigo, Descricao) VALUES (36, '036', 'Portabilidade não localizada pela combinação Fundo + Agente + Identificador Externo')
GO
SET IDENTITY_INSERT FastConsig.dbo.CTCMotivoRecusaEfetivacaoGarantiaFGO OFF
GO