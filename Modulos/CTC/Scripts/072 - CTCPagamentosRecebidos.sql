CREATE TABLE FastConsig.dbo.CTCPagamentosRecebidos (
  Id int IDENTITY,
  Evento int NOT NULL,
  NumeroControle varchar(20) NOT NULL,
  DataBACEN datetime NOT NULL,
  ISPBDebitado varchar(8) NOT NULL,
  AgenciaDebitada varchar(4) NULL,
  ContaDebitada varchar(13) NULL,
  CNPJDebitado varchar(14) NULL,
  NomeClienteDebitado varchar(150) NULL,
  ISPBCreditado varchar(8) NOT NULL,
  AgenciaCreditada varchar(4) NULL,
  ContaCreditada varchar(13) NULL,
  CNPJCreditado varchar(14) NULL,
  NomeClienteCreditado varchar(150) NULL,
  ValorLancamento decimal(18, 2) NOT NULL,
  ISPBPrestador varchar(8) NULL,
  DataMovimento date NOT NULL,
  NUPortabilidade varchar(21) NOT NULL,
  Acatado bit NULL,
  Conciliado bit NULL,
  Devolvido bit NULL,
  UsuarioAcatador varchar(50) NULL,
  UsuarioDevolucao varchar(50) NULL,
  DataAcatamento datetime NULL,
  DataDevolucao datetime NULL,
  Devolucao int NULL,
  Requisicao int NULL,
  CONSTRAINT PK_CTCPagamentosRecebidos_Id PRIMARY KEY CLUSTERED (Id),
  CONSTRAINT KEY_CTCPagamentosRecebidos_Evento UNIQUE (Evento)
)
ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.CTCPagamentosRecebidos
  ADD CONSTRAINT FK_CTCPagamentosRecebidos_Requisicao FOREIGN KEY (Requisicao) REFERENCES dbo.CTCRequisicao (Id)
GO