CREATE TABLE FastConsig.dbo.JobFilaJobTentativa (
  Id bigint IDENTITY,
  IdFilaJob bigint NOT NULL,
  IdJobTentativa bigint NOT NULL,
  CONSTRAINT PK_JobFilaJobTentativa PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.JobFilaJobTentativa
  ADD CONSTRAINT FK_JobFilaJobTentativa_FilaJob FOREIGN KEY (IdFilaJob) REFERENCES dbo.JobFilaJob (Id)
GO

ALTER TABLE FastConsig.dbo.JobFilaJobTentativa
  ADD CONSTRAINT FK_JobFilaJobTentativa_JobTentativa FOREIGN KEY (IdJobTentativa) REFERENCES dbo.JobTentativa (Id)
GO