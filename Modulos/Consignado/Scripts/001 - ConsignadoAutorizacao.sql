CREATE TABLE FastConsig.dbo.ConsignadoAutorizacao (
  Id int IDENTITY,
  Cpf bigint NOT NULL,
  CpfRepresentante bigint NULL,
  NsuAutorizacaoDigital bigint NULL,
  DataHoraAutorizacaoDigital datetime NULL,
  CanalAutorizacaoDigital int NULL,
  TipoDocumentoIdentificacao int NULL,
  DocumentoIdentificacao varbinary(max) NULL,
  ChaveIdentificadora bigint NULL,
  TermoAutorizacaoBeneficiario varbinary(max) NULL,
  PossuiAssinaturaRogo bit NULL,
  TituloTermo varchar(255) NULL,
  AutorTermo varchar(255) NULL,
  CidadeAssinaturaTermo varchar(255) NULL,
  DataHoraCriacaoTermo datetime NULL,
  TokenAutorizacao varchar(255) NULL,
  DataValidadeAutorizacao date NOT NULL,
  ConsignadoDetalhe varchar(max) NULL,
  TipoConsignado int NULL,
  CodigoOrgao int NULL,
  CodigoMatricula int NULL,
  CONSTRAINT PK_ConsignadoAutorizacao PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
TEXTIMAGE_ON [PRIMARY]
GO