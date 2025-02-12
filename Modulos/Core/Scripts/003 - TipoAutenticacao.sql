CREATE TABLE FastConsig.dbo.TipoAutenticacao (
  Id int IDENTITY,
  Descricao varchar(50) NULL,
  CONSTRAINT PK_TipoAutenticacao_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

SET IDENTITY_INSERT FastConsig.dbo.TipoAutenticacao ON
GO
INSERT FastConsig.dbo.TipoAutenticacao(Id, Descricao) VALUES (1, 'AD')
INSERT FastConsig.dbo.TipoAutenticacao(Id, Descricao) VALUES (2, 'Interna')
GO
SET IDENTITY_INSERT FastConsig.dbo.TipoAutenticacao OFF
GO