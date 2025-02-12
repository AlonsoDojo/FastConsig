CREATE TABLE FastConsig.dbo.CTC926 (
  Id int IDENTITY,
  Arquivo int NOT NULL,
  DataReferencia date NOT NULL,
  DataInicio date NOT NULL,
  DataFim date NOT NULL,
  CONSTRAINT PK_CTC926_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.CTC926
  ADD CONSTRAINT FK_CTC926_Arquivo FOREIGN KEY (Arquivo) REFERENCES dbo.CTCArquivos (Id)
GO