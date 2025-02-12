CREATE TABLE FastConsig.dbo.Job (
  Id int IDENTITY,
  Name varchar(50) NOT NULL,
  Codigo varchar(50) NULL,
  Descricao varchar(150) NOT NULL,
  IdJobStatus char(1) NOT NULL,
  CONSTRAINT PK_Job PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.Job
  ADD CONSTRAINT FK_Job_IdJobStatus FOREIGN KEY (IdJobStatus) REFERENCES dbo.JobStatus (Id)
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

SET IDENTITY_INSERT FastConsig.dbo.Job ON
GO
INSERT FastConsig.dbo.Job(Id, Name, Codigo, Descricao, IdJobStatus) VALUES (1, 'DataPrevService - Averbação', 'I', 'Consignado DataPrevService - Averbação', 'O')
INSERT FastConsig.dbo.Job(Id, Name, Codigo, Descricao, IdJobStatus) VALUES (2, 'DataPrevService - Excluir Averbação', 'I', 'Consignado DataPrevService - Excluir Averbação', 'E')
INSERT FastConsig.dbo.Job(Id, Name, Codigo, Descricao, IdJobStatus) VALUES (3, 'SiapeService - Averbação', 'S', 'Consignado Siape  - Averbação', 'O')
INSERT FastConsig.dbo.Job(Id, Name, Codigo, Descricao, IdJobStatus) VALUES (4, 'SiapeService - Anuência', 'S', 'Consignado Siape  - Anuência', 'O')
INSERT FastConsig.dbo.Job(Id, Name, Codigo, Descricao, IdJobStatus) VALUES (5, 'DataPrevService - Refin', 'I', 'Consignado DataPrevService - Refinanciamento', 'O')
INSERT FastConsig.dbo.Job(Id, Name, Codigo, Descricao, IdJobStatus) VALUES (6, 'DataPrevService - Informação Complementar Contrato', 'I', 'Consignado DataPrevService - Informação Complementar Contrato', 'O')
INSERT FastConsig.dbo.Job(Id, Name, Codigo, Descricao, IdJobStatus) VALUES (7, 'DataPrevService - Taxa de Juros', 'I', 'Consignado DataPrevService - Envio taxa de juros diário', 'E')
INSERT FastConsig.dbo.Job(Id, Name, Codigo, Descricao, IdJobStatus) VALUES (8, 'SiapeService - Renovação', 'S', 'Consignado Siape  - REFIN', 'O')
GO
SET IDENTITY_INSERT FastConsig.dbo.Job OFF
GO