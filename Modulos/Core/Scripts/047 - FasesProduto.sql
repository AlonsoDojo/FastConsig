CREATE TABLE FastConsig.dbo.FasesProduto (
  Id int IDENTITY,
  Produto int NOT NULL,
  Fase int NOT NULL,
  Ordem int NOT NULL,
  CONSTRAINT PK_FasesProduto_Id PRIMARY KEY CLUSTERED (Id),
  CONSTRAINT KEY_FasesProduto UNIQUE (Produto, Fase)
)
ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.FasesProduto
  ADD CONSTRAINT FK_FasesProduto_Fase FOREIGN KEY (Fase) REFERENCES dbo.Fases (Id)
GO

ALTER TABLE FastConsig.dbo.FasesProduto
  ADD CONSTRAINT FK_FasesProduto_Produto FOREIGN KEY (Produto) REFERENCES dbo.Produtos (Id)
GO