CREATE TABLE FastConsig.dbo.MotivoBloqueio (
  Id int IDENTITY,
  Descricao varchar(250) NOT NULL,
  Origem int NOT NULL,
  CONSTRAINT PK_MotivoBloqueio_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.MotivoBloqueio
  ADD CONSTRAINT FK_MotivoBloqueio_Origem FOREIGN KEY (Origem) REFERENCES dbo.OrigemBloqueio (Id)
GO
