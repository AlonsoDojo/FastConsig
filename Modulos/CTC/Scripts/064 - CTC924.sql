CREATE TABLE FastConsig.dbo.CTC924 (
  Id int IDENTITY,
  Arquivo int NOT NULL,
  DataReferencia date NOT NULL,
  PeriodoInicial date NULL,
  PeriodoFinal date NULL,
  CONSTRAINT PK_CTC924_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.CTC924
  ADD CONSTRAINT FK_CTC924_Arquivo FOREIGN KEY (Arquivo) REFERENCES dbo.CTCArquivos (Id)
GO