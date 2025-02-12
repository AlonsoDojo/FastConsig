CREATE TABLE FastConsig.dbo.CTC928ClienteProduto (
  Id int IDENTITY,
  Cliente int NOT NULL,
  Produto varchar(250) NOT NULL,
  CONSTRAINT PK_CTC928ClienteProduto_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.CTC928ClienteProduto
  ADD CONSTRAINT FK_CTC928ClienteProduto_Cliente FOREIGN KEY (Cliente) REFERENCES dbo.CTC928Clientes (Id)
GO