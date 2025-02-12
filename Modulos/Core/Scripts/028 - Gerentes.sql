CREATE TABLE FastConsig.dbo.Gerentes (
  Id int IDENTITY,
  Nome varchar(120) NOT NULL,
  Cpf varchar(14) NOT NULL,
  CONSTRAINT PK_Gerentes_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO