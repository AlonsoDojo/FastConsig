CREATE TABLE FastConsig.dbo.ValidadorModelos (
  Id int IDENTITY,
  Modelo varchar(250) NULL,
  Descricao varchar(max) NULL,
  CONSTRAINT PK_ValidadorModelos_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
TEXTIMAGE_ON [PRIMARY]
GO