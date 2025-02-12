CREATE TABLE FastConsig.dbo.FasesProdutoValidador (
  Id int IDENTITY,
  FaseProduto int NOT NULL,
  Validador int NOT NULL,
  Ativo bit NULL,
  CONSTRAINT PK_FasesProdutoValidador_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.FasesProdutoValidador
  ADD CONSTRAINT FK_FasesProdutoValidador_FaseProduto FOREIGN KEY (FaseProduto) REFERENCES dbo.FasesProduto (Id)
GO

ALTER TABLE FastConsig.dbo.FasesProdutoValidador
  ADD CONSTRAINT FK_FasesProdutoValidador_Validador FOREIGN KEY (Validador) REFERENCES dbo.Validador (Id)
GO