CREATE TABLE FastConsig.dbo.JobFila (
  Id bigint IDENTITY,
  Mensagem varchar(max) NOT NULL,
  IdStatus int NOT NULL,
  CONSTRAINT PK_Fila PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.JobFila
  ADD CONSTRAINT FK_Fila_FilaStatus FOREIGN KEY (IdStatus) REFERENCES dbo.JobFilaStatus (Id)
GO