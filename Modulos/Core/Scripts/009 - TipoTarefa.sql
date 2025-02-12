CREATE TABLE FastConsig.dbo.TipoTarefa (
  Id int IDENTITY,
  Descricao varchar(100) NULL,
  CONSTRAINT PK_TipoTarefa_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO