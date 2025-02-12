CREATE TABLE FastConsig.dbo.CTC928Clientes (
  Id int IDENTITY,
  Arquivo int NOT NULL,
  NomeCliente varchar(150) NOT NULL,
  Cnpj varchar(14) NOT NULL,
  ISPB varchar(8) NOT NULL,
  CONSTRAINT PK_CTC928Clientes_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.CTC928Clientes
  ADD CONSTRAINT FK_CTC928Clientes_Arquivo FOREIGN KEY (Arquivo) REFERENCES dbo.CTC928 (Id)
GO