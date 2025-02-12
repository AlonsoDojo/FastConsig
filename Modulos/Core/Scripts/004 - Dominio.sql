CREATE TABLE FastConsig.dbo.Dominio (
  Id int IDENTITY,
  URL varchar(100) NULL,
  Descricao varchar(100) NULL,
  TipoAutenticacao int NULL,
  Ativo bit NULL,
  CONSTRAINT PK_Dominio_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

SET IDENTITY_INSERT FastConsig.dbo.Dominio ON
GO
INSERT FastConsig.dbo.Dominio(Id, URL, Descricao, TipoAutenticacao, Ativo) VALUES (1, 'BMP', 'Local', 2, CONVERT(bit, 'True'))
INSERT FastConsig.dbo.Dominio(Id, URL, Descricao, TipoAutenticacao, Ativo) VALUES (2, 'promotorax.com', 'X', 1, CONVERT(bit, 'True'))
GO
SET IDENTITY_INSERT FastConsig.dbo.Dominio OFF
GO