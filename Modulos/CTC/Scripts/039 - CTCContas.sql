CREATE TABLE FastConsig.dbo.CTCContas (
  Id int IDENTITY,
  ISPB varchar(8) NOT NULL,
  Descricao varchar(250) NOT NULL,
  CNPJ varchar(14) NOT NULL,
  Banco varchar(3) NOT NULL,
  Agencia varchar(4) NOT NULL,
  Conta varchar(13) NOT NULL,
  Ativo bit NOT NULL,
  CONSTRAINT PK_CTCContas_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.CTCContas
  ADD CONSTRAINT FK_CTCContas_Banco FOREIGN KEY (Banco) REFERENCES dbo.Bancos (Banco)
GO