CREATE TABLE FastConsig.dbo.CheckListItens (
  Id int IDENTITY,
  CheckList int NULL,
  Descricao varchar(200) NULL,
  Obrigatorio bit NULL,
  TipoDocumento int NULL,
  CONSTRAINT PK_CheckListItens_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.CheckListItens
  ADD CONSTRAINT FK_CheckListItens_CheckList FOREIGN KEY (CheckList) REFERENCES dbo.CheckList (Id)
GO

ALTER TABLE FastConsig.dbo.CheckListItens
  ADD CONSTRAINT FK_CheckListItens_TipoDocumento FOREIGN KEY (TipoDocumento) REFERENCES dbo.TipoDocumento (Id)
GO
