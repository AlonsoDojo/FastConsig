CREATE TABLE FastConsig.dbo.TipoDocumento (
  Id int IDENTITY,
  Descricao varchar(100) NULL,
  Selecionavel bit NULL,
  CONSTRAINT PK_TipoDocumento_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO