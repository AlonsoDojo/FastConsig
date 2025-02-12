CREATE TABLE FastConsig.dbo.CheckList (
  Id int IDENTITY,
  Descricao varchar(200) NOT NULL,
  CONSTRAINT PK_CheckList_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO