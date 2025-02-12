CREATE TABLE FastConsig.dbo.JobDetalhe (
  IdJob int NOT NULL,
  Type varchar(max) NULL,
  ConnectionString varchar(255) NULL,
  Debug bit NULL,
  LoggingType varchar(255) NULL,
  LoggingLocation varchar(255) NULL,
  LoggingMaximumSize bigint NULL,
  CONSTRAINT PK_JobDetalhe PRIMARY KEY CLUSTERED (IdJob)
)
ON [PRIMARY]
TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.JobDetalhe
  ADD CONSTRAINT FK_JobDetalhe_Job FOREIGN KEY (IdJob) REFERENCES dbo.Job (Id)
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

INSERT FastConsig.dbo.JobDetalhe(IdJob, Type, ConnectionString, Debug, LoggingType, LoggingLocation, LoggingMaximumSize) VALUES (1, 'FastConsig.Consignado.Jobs.DataPrev.Averbacao.Integracao, FastConsig.Consignado.Jobs.DataPrev.Averbacao, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null', NULL, CONVERT(bit, 'True'), 'Type="File"', 'C:\Robo\ConsignadoDataPrev\DataPrevServices', 1024)
INSERT FastConsig.dbo.JobDetalhe(IdJob, Type, ConnectionString, Debug, LoggingType, LoggingLocation, LoggingMaximumSize) VALUES (2, 'FastConsig.Consignado.Jobs.DataPrev.ExcluirAverbacao.Integracao, FastConsig.Consignado.Jobs.DataPrev.ExcluirAverbacao, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null', NULL, CONVERT(bit, 'True'), 'Type="File"', 'C:\Robo\ConsignadoDataPrev\DataPrevServices', 1024)
INSERT FastConsig.dbo.JobDetalhe(IdJob, Type, ConnectionString, Debug, LoggingType, LoggingLocation, LoggingMaximumSize) VALUES (3, 'FastConsig.Consignado.Jobs.SIAPE.Averbacao.Integracao, FastConsig.Consignado.Jobs.SIAPE.Averbacao, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null', NULL, CONVERT(bit, 'True'), 'Type="File"', 'C:\Robo\ConsignadoDataPrev\DataPrevServicesType="File"', 1024)
INSERT FastConsig.dbo.JobDetalhe(IdJob, Type, ConnectionString, Debug, LoggingType, LoggingLocation, LoggingMaximumSize) VALUES (4, 'FastConsig.Consignado.Jobs.SIAPE.Anuencia.Integracao, FastConsig.Consignado.Jobs.SIAPE.Anuencia, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null', NULL, CONVERT(bit, 'True'), 'Type="File"', 'C:\Robo\ConsignadoDataPrev\DataPrevServices', 1024)
INSERT FastConsig.dbo.JobDetalhe(IdJob, Type, ConnectionString, Debug, LoggingType, LoggingLocation, LoggingMaximumSize) VALUES (5, 'FastConsig.Consignado.Jobs.DataPrev.Refinanciamento.Integracao, FastConsig.Consignado.Jobs.DataPrev.Refinanciamento, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null', NULL, CONVERT(bit, 'True'), 'Type="File"', 'C:\Robo\ConsignadoDataPrev\DataPrevServices', 1024)
INSERT FastConsig.dbo.JobDetalhe(IdJob, Type, ConnectionString, Debug, LoggingType, LoggingLocation, LoggingMaximumSize) VALUES (6, 'FastConsig.Consignado.Jobs.DataPrev.InformacaoContrato.Integracao, FastConsig.Consignado.Jobs.DataPrev.InformacaoContrato, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null', NULL, CONVERT(bit, 'True'), 'Type="File"', 'C:\Robo\ConsignadoDataPrev\DataPrevServices', 1024)
INSERT FastConsig.dbo.JobDetalhe(IdJob, Type, ConnectionString, Debug, LoggingType, LoggingLocation, LoggingMaximumSize) VALUES (7, 'FastConsig.Consignado.Jobs.DataPrev.TaxaJuros.Integracao, FastConsig.Consignado.Jobs.DataPrev.TaxaJuros, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null', NULL, CONVERT(bit, 'True'), 'Type="File"', 'C:\Robo\ConsignadoDataPrev\DataPrevServices', 1024)
INSERT FastConsig.dbo.JobDetalhe(IdJob, Type, ConnectionString, Debug, LoggingType, LoggingLocation, LoggingMaximumSize) VALUES (8, 'FastConsig.Consignado.Jobs.SIAPE.Renovacao.Integracao, FastConsig.Consignado.Jobs.SIAPE.Renovacao, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null', NULL, CONVERT(bit, 'True'), 'Type="File"', 'C:\Robo\ConsignadoDataPrev\DataPrevServicesType="File"', 1024)
GO