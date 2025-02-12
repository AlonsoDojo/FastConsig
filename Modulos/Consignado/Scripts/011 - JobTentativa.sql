CREATE TABLE FastConsig.dbo.JobTentativa (
  Id bigint IDENTITY,
  IdJob int NOT NULL,
  IdJobStatus char(1) NOT NULL,
  DtProcessamento datetime NOT NULL,
  Retorno varchar(max) NULL,
  CONSTRAINT PK_JobTentativa PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
TEXTIMAGE_ON [PRIMARY]
GO