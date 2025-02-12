CREATE TABLE FastConsig.dbo.ValidadorRules (
  Id int IDENTITY,
  RuleName varchar(100) NOT NULL,
  IsList bit NULL,
  IsCustom bit NULL,
  Descricao varchar(max) NULL,
  CONSTRAINT PK_ValidadorRules_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
TEXTIMAGE_ON [PRIMARY]
GO