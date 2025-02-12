CREATE TABLE FastConsig.dbo.AuditTable (
  ID int IDENTITY,
  KeyFieldID int NOT NULL,
  AuditActionTypeENUM int NOT NULL,
  DateTimeStamp datetime NOT NULL,
  DataModel varchar(max) NOT NULL,
  Changes varchar(max) NOT NULL,
  ValueBefore varchar(max) NOT NULL,
  ValueAfter varchar(max) NOT NULL,
  Usuario varchar(50) NOT NULL,
  CONSTRAINT PK_AuditLog PRIMARY KEY CLUSTERED (ID)
)
ON [PRIMARY]
TEXTIMAGE_ON [PRIMARY]
GO