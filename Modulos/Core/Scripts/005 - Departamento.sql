CREATE TABLE FastConsig.dbo.Departamento (
  id int IDENTITY,
  Descricao varchar(100) NOT NULL,
  CONSTRAINT PK_Departamento_id PRIMARY KEY CLUSTERED (id)
)
ON [PRIMARY]
GO