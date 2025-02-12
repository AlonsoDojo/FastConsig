CREATE TABLE FastConsig.dbo.JobFilaJob (
  Id bigint IDENTITY,
  IdFila bigint NOT NULL,
  IdJob int NOT NULL,
  IdJobTentativa bigint NULL,
  Status varchar(20) NOT NULL,
  Content varchar(max) NULL,
  Predecessor int NULL DEFAULT (NULL),
  CONSTRAINT PK_JobFilaJob PRIMARY KEY CLUSTERED (Id),
  CONSTRAINT IX_JobFilaJob UNIQUE (IdFila, IdJob)
)
ON [PRIMARY]
TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.JobFilaJob
  ADD CONSTRAINT FK_JobFilaJob_JobFila FOREIGN KEY (IdFila) REFERENCES dbo.JobFila (Id)
GO

ALTER TABLE FastConsig.dbo.JobFilaJob
  ADD CONSTRAINT FK_JobFilaJob_Job FOREIGN KEY (IdJob) REFERENCES dbo.Job (Id)
GO