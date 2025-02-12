CREATE TABLE FastConsig.dbo.CTCRequisicao (
  Id int IDENTITY,
  IdentificacaoParticipanteAdministrado varchar(8) NOT NULL,
  NUPortabilidade varchar(21) NOT NULL,
  IFProponente varchar(8) NOT NULL,
  Contrato varchar(40) NOT NULL,
  CNPJBaseIFOriginadora varchar(8) NOT NULL,
  TipoContrato varchar(4) NULL,
  EnteConsignante varchar(2) NULL,
  CNPJCorrespondenteBancario varchar(14) NULL,
  TipoPessoa varchar(1) NULL,
  CpfCnpjCliente varchar(14) NOT NULL,
  NomeCliente varchar(150) NOT NULL,
  Telefone varchar(15) NULL,
  Email varchar(150) NULL,
  Endereco varchar(150) NULL,
  Numero varchar(15) NULL,
  Complemento varchar(50) NULL,
  Cidade varchar(50) NULL,
  UF varchar(2) NULL,
  Cep varchar(8) NULL,
  DataReferenciaSaldo date NULL,
  SaldoDevedor decimal(18, 2) NULL,
  JurosNominal decimal(12, 6) NULL,
  JurosEfetivo decimal(12, 6) NULL,
  Cet decimal(12, 6) NULL,
  Moeda varchar(2) NULL,
  IndiceRemuneracao varchar(2) NULL,
  RegimeAmortizacao varchar(2) NULL,
  DataContrato date NULL,
  QtdParcelasContrato int NULL,
  ValorFaceParcela decimal(18, 2) NULL,
  DataVencimentoPrimeiraParcela date NULL,
  DataVencimentoUltimaParcela date NULL,
  EnderecoCartaPortabilidade varchar(150) NULL,
  NumeroCartaPortabilidade varchar(15) NULL,
  ComplementoCartaPortabilidade varchar(50) NULL,
  CidadeCartaPortabilidade varchar(50) NULL,
  UFCartaPortabilidade varchar(2) NULL,
  CepCartaPortabilidade varchar(8) NULL,
  SituacaoPortabilidade varchar(2) NOT NULL,
  DataReferencia datetime NOT NULL,
  DataVencimentoRetencao datetime NOT NULL,
  DataVencimentoAceite datetime NOT NULL,
  Arquivo int NOT NULL,
  Fase int NOT NULL,
  TipoArquivo int NOT NULL,
  Status varchar(50) NULL,
  Mensagem varchar(max) NULL,
  TipoFluxo int NULL,
  NumeroBeneficio varchar(50) NULL,
  EspecieBeneficio int NULL,
  DataNascimento date NULL,
  UFBeneficio varchar(2) NULL,
  ProdutoOrigem varchar(6) NULL,
  MotivoRetencao varchar(3) NULL,
  MotivoCancelamento varchar(3) NULL,
  MotivoDecursoPrazo varchar(3) NULL,
  MotivoDevolucaoLiquidacao varchar(2) NULL,
  DataRespostaSaldo datetime NULL,
  DataRetencao datetime NULL,
  DataCancelamento datetime NULL,
  DataDecursoPrazo datetime NULL,
  DataDevolucaoLiquidacao datetime NULL,
  ObservacaoAceite varchar(max) NULL,
  ObservacaoRetencao varchar(max) NULL,
  ObservacaoCancelamento varchar(max) NULL,
  ObservacaoDecursodePrazo varchar(max) NULL,
  ObservacaoDevolucaoLiquidacao varchar(max) NULL,
  DataReferenciaSaldoResposta date NULL,
  UsuarioAceite varchar(50) NULL,
  SaldoAceiteInformado decimal(12, 6) NULL,
  DataReferenciaRetencao date NULL,
  UsuarioRetencao varchar(50) NULL,
  DataPagamento date NULL,
  UsuarioPagamento varchar(50) NULL,
  ValorPago decimal(12, 6) NULL,
  UsuarioCancelamento varchar(50) NULL,
  ValorRCOCalculado decimal(18, 2) NULL,
  ValorRCOApurado decimal(18, 2) NULL,
  CONSTRAINT PK_CTCRequisicao_Id PRIMARY KEY CLUSTERED (Id) WITH (FILLFACTOR = 80),
  CONSTRAINT KEY_CTCRequisicao_NUPortabilidade UNIQUE (NUPortabilidade)
)
ON [PRIMARY]
TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.CTCRequisicao
  ADD CONSTRAINT FK_CTCRequisicao_Arquivo FOREIGN KEY (Arquivo) REFERENCES dbo.CTCArquivos (Id)
GO

ALTER TABLE FastConsig.dbo.CTCRequisicao
  ADD CONSTRAINT FK_CTCRequisicao_EnteConsignante FOREIGN KEY (EnteConsignante) REFERENCES dbo.CTCEnteConsignante (Codigo)
GO

ALTER TABLE FastConsig.dbo.CTCRequisicao
  ADD CONSTRAINT FK_CTCRequisicao_Fase FOREIGN KEY (Fase) REFERENCES dbo.CTCFases (Id)
GO

ALTER TABLE FastConsig.dbo.CTCRequisicao
  ADD CONSTRAINT FK_CTCRequisicao_IndiceRemuneracao FOREIGN KEY (IndiceRemuneracao) REFERENCES dbo.CTCIndicadorRemuneracao (Codigo)
GO

ALTER TABLE FastConsig.dbo.CTCRequisicao
  ADD CONSTRAINT FK_CTCRequisicao_Moeda FOREIGN KEY (Moeda) REFERENCES dbo.CTCMoeda (Codigo)
GO

ALTER TABLE FastConsig.dbo.CTCRequisicao
  ADD CONSTRAINT FK_CTCRequisicao_MotivoCancelamento FOREIGN KEY (MotivoCancelamento) REFERENCES dbo.CTCMotivoCancelamentoPortabilidade (Codigo)
GO

ALTER TABLE FastConsig.dbo.CTCRequisicao
  ADD CONSTRAINT FK_CTCRequisicao_MotivoDecursoPrazo FOREIGN KEY (MotivoDecursoPrazo) REFERENCES dbo.CTCMotivoDecursoPrazoPortabilidade (Codigo)
GO

ALTER TABLE FastConsig.dbo.CTCRequisicao
  ADD CONSTRAINT FK_CTCRequisicao_MotivoDevolucaoLiquidacao FOREIGN KEY (MotivoDevolucaoLiquidacao) REFERENCES dbo.CTCMotivoDevolucaoLiquidacaoPortabilidade (Codigo)
GO

ALTER TABLE FastConsig.dbo.CTCRequisicao
  ADD CONSTRAINT FK_CTCRequisicao_MotivoRetencao FOREIGN KEY (MotivoRetencao) REFERENCES dbo.CTCMotivoRetencaoContrato (Codigo)
GO

ALTER TABLE FastConsig.dbo.CTCRequisicao
  ADD CONSTRAINT FK_CTCRequisicao_RegimeAmortizacao FOREIGN KEY (RegimeAmortizacao) REFERENCES dbo.CTCRegimeAmortizacao (Codigo)
GO

ALTER TABLE FastConsig.dbo.CTCRequisicao
  ADD CONSTRAINT FK_CTCRequisicao_SituacaoPortabilidade FOREIGN KEY (SituacaoPortabilidade) REFERENCES dbo.CTCSituacaoPortabilidade (Codigo)
GO

ALTER TABLE FastConsig.dbo.CTCRequisicao
  ADD CONSTRAINT FK_CTCRequisicao_TipoArquivo FOREIGN KEY (TipoArquivo) REFERENCES dbo.CTCDominioArquivo (Id)
GO

ALTER TABLE FastConsig.dbo.CTCRequisicao
  ADD CONSTRAINT FK_CTCRequisicao_TipoContrato FOREIGN KEY (TipoContrato) REFERENCES dbo.CTCTipoContrato (Codigo)
GO

ALTER TABLE FastConsig.dbo.CTCRequisicao
  ADD CONSTRAINT FK_CTCRequisicao_TipoFluxo FOREIGN KEY (TipoFluxo) REFERENCES dbo.CTCTipoFluxo (Id)
GO

EXEC sys.sp_addextendedproperty N'MS_Description'
                               ,N'Conteúdo ACTC102'
                               ,'SCHEMA'
                               ,N'dbo'
                               ,'TABLE'
                               ,N'CTCRequisicao'
GO