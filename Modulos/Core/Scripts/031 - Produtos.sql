CREATE TABLE FastConsig.dbo.Produtos (
  Id int NOT NULL,
  Nome varchar(255) NULL,
  Ativo bit NULL,
  PaginaPadrao varchar(80) NULL,
  ExibeBlocoCelularEmail bit NULL,
  ExibeBlocoDataNascimento bit NULL,
  GerentePadrao int NULL,
  Parametros varchar(max) NULL,
  Observacoes varchar(max) NULL,
  BuscaDadosCadastrais bit NULL,
  PermiteBuscarUltimoCadastro bit NULL,
  ExibeSelecaoTabelas bit NULL,
  ExibeValorSolicitado bit NULL,
  ExibePrazo bit NULL,
  AplicavelPF bit NULL,
  AplicavelPJ bit NULL,
  ExibirDatasSimulacao bit NULL,
  ExibeDataEmissao bit NULL,
  ExibeDataPrimeiroVencimento bit NULL,
  ExibeCaptcha bit NULL,
  ExibeNumeroBeneficio bit NULL,
  ValidaCertificado bit NULL,
  TipoCertificado int NULL,
  ExpirarProposta bit NULL,
  DiasExpiracao int NULL,
  ExibirFormaComunicacao bit NULL,
  ExibeOrgao bit NULL,
  ExibeEspecieBeneficio bit NULL,
  FamiliaProduto int NULL,
  ExibeInstituidor bit NULL,
  CONSTRAINT PK_Produtos PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.Produtos
  ADD CONSTRAINT FK_Produtos_FamiliaProduto FOREIGN KEY (FamiliaProduto) REFERENCES dbo.FamiliaProduto (Id)
GO

ALTER TABLE FastConsig.dbo.Produtos
  ADD CONSTRAINT FK_Produtos_TipoCertificado FOREIGN KEY (TipoCertificado) REFERENCES dbo.ProfissionaisCertificadosTipoCertificado (Id)
GO