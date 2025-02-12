CREATE TABLE FastConsig.dbo.RamoAtividade (
  Id int NOT NULL,
  Descricao varchar(500) NOT NULL,
  TipoPessoa varchar(1) NULL,
  CONSTRAINT PK_RamoAtividade_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO