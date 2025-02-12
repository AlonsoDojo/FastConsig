CREATE TABLE FastConsig.dbo.PoliticaParametroProduto (
  Id int IDENTITY,
  Politica int NOT NULL,
  Produto int NOT NULL,
  Parametros varchar(max) NULL,
  CONSTRAINT PK_PoliticaParametroProduto_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.PoliticaParametroProduto
  ADD CONSTRAINT FK_PoliticaParametroProduto_Politica FOREIGN KEY (Politica) REFERENCES dbo.Politicas (Id)
GO