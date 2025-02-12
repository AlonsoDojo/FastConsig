CREATE TABLE FastConsig.dbo.ApplicationsLog (
  Id int IDENTITY,
  Application varchar(255) NULL,
  ApplicationGuid varchar(50) NULL,
  Environment varchar(3) NULL,
  [User] varchar(50) NULL,
  HostName varchar(200) NULL,
  MethodName varchar(200) NULL,
  FilePath varchar(max) NULL,
  LineNumber varchar(10) NULL,
  Parameters varchar(max) NULL,
  Thread varchar(255) NULL,
  Level varchar(50) NULL,
  Logger varchar(255) NULL,
  Context varchar(10) NULL,
  Date datetime NOT NULL,
  Message varchar(max) NULL,
  Exception varchar(max) NULL,
  InnerException varchar(max) NULL
)
ON [PRIMARY]
TEXTIMAGE_ON [PRIMARY]
GO

CREATE CLUSTERED INDEX IDX_ApplicationsLog
  ON FastConsig.dbo.ApplicationsLog (Date, Application)
  ON [PRIMARY]
GO